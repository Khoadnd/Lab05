using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;

namespace Bai03
{
    public partial class ucView : UserControl
    {
        private string _username;
        private string _password;
        private string _folder;
        public ucView()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public void SetParameters(string username, string password, string folder)
        {
            _username = username;
            _password = password;
            _folder = folder;
            pageSelector.Value = 1;
        }

        public async Task PopulateList()
        {
            pageSelector.Visible = true;
            pageSelector.Enabled = false;
            progressBar.Visible = true;
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.Value = 0;
            var temp = (Main)ParentForm;
            temp.userControl1.treeView1.Enabled = false;
            var arguments = new List<object>
            {
                _username,
                _password,
                _folder
            };
            while (backgroundWorker.IsBusy)
            {
                Console.WriteLine(@"Waiting backgroundworker... @ucView.PopulateList");
                Thread.Sleep(100);
            }
            await Task.Run(() => backgroundWorker.RunWorkerAsync(arguments));
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var genericArguments = e.Argument as List<object>;
            var arguments = genericArguments?.Cast<string>().ToList();
            lstListMail.Items.Clear();
            var backgroundWorker = sender as AbortableBackgroundWorker;
            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(arguments[0].Trim(), arguments[1].Trim());

                    if (!client.IsConnected) return;

                    var folder = client.GetFolder(arguments[2]);
                    if (folder == null)
                    {
                        client.Disconnect(true);
                        return;
                    }
                    folder.Open(FolderAccess.ReadOnly);
                    //var inbox = client.Inbox;
                    //inbox.Open(FolderAccess.ReadOnly);

                    lblTotal.Text = @"Total: " + folder.Count.ToString();
                    lblRecent.Text = @"Recent: " + folder.Recent.ToString();
                    if (folder.Count == 0)
                    {
                        MessageBox.Show(@"Folder is empty!");
                        return;
                    }
                    pageSelector.Maximum = decimal.Ceiling((decimal)folder.Count / 50);

                    var start = (pageSelector.Value - 1) * 50;
                    lblViews.Text = @"Viewing: " + start + @" - " + (start + 50);
                    for (var i = start; i < start + 50; ++i)
                    {
                        if (i >= folder.Count)
                            break;
                        var message = folder.GetMessage((int)i);
                        var item = new ListViewItem(message.Subject == "" ? "<no subject>" : message.Subject);

                        var from = new
                            ListViewItem.ListViewSubItem(item, message.From.ToString());
                        item.SubItems.Add(from);

                        var date = new
                            ListViewItem.ListViewSubItem(item, message.Date.ToString());
                        item.SubItems.Add(date);
                        backgroundWorker.ReportProgress((int)(i % 50 * 2), item);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                progressBar.Visible = false;
                pageSelector.Enabled = true;
                var _ = (Main)ParentForm;
                _.userControl1.treeView1.Enabled = true;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (e.UserState != null)
                lstListMail.Items.Add((ListViewItem)e.UserState);
        }

        private async void pageSelector_ValueChanged(object sender, EventArgs e)
        {
            while (backgroundWorker.IsBusy)
            {
                Console.WriteLine(@"Background worker currently busy, waiting... @ucView::pageSelector");
                Thread.Sleep(100);
            }
            await PopulateList();
        }

        private void lstListMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lstListMail.Enabled = false;
                webBrowser1.DocumentText = @"Loading...";
                if (lstListMail.SelectedItems.Count <= 0)
                    return;

                var selectedIndex = lstListMail.SelectedIndices[0];
                if (selectedIndex >= 0)
                {
                    var imapClient = new ImapClient();
                    imapClient.Connect("imap.gmail.com", 993, true);
                    imapClient.Authenticate(_username, _password);

                    var folder = imapClient.GetFolder(_folder);
                    folder.Open(FolderAccess.ReadOnly);
                    var min = ((int)pageSelector.Value - 1) * 50;
                    var items = folder.Fetch(min, min + 50 > folder.Count ? folder.Count : min + 50,
                        MessageSummaryItems.UniqueId);
                    var message = folder.GetMessage(items[selectedIndex].UniqueId);
                    if (message == null)
                    {
                        MessageBox.Show(@"Can't retrieve message!");
                        return;
                    }

                    webBrowser1.DocumentText = message.HtmlBody + message.TextBody;
                }
                lstListMail.Enabled = true;
            }
            );
        }
    }
}
