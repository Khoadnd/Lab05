using System;
using System.ComponentModel;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;

namespace Bai02
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pageSelector.Visible = true;
            pageSelector.Enabled = false;
            progressBar.Visible = true;
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.Value = 0;
            backgroundWorker.RunWorkerAsync();
            btnLogin.Enabled = false;
            //var a = new Thread(GetMailAndView);
            //a.Start();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (e.UserState != null)
                lstListMail.Items.Add((ListViewItem)e.UserState);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            lstListMail.Items.Clear();
            var backgroundWorker = sender as BackgroundWorker;
            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(txtEmail.Text.Trim(), txtPassword.Text.Trim());

                    if (!client.IsConnected) return;

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    lblTotal.Text = @"Total: " + inbox.Count.ToString();
                    lblRecent.Text = @"Recent: " + inbox.Recent.ToString();
                    pageSelector.Maximum = decimal.Ceiling((decimal)inbox.Count / 50);

                    var start = (pageSelector.Value - 1) * 50;
                    lblViews.Text = @"Viewing: " + start + @" - " + (start + 50);
                    for (var i = start; i < start + 50; ++i)
                    {
                        if (i >= inbox.Count)
                            break;
                        var message = inbox.GetMessage((int)i);
                        var item = new ListViewItem(message.Subject);

                        var from = new
                            ListViewItem.ListViewSubItem(item, message.From.ToString());
                        item.SubItems.Add(from);

                        var date = new
                            ListViewItem.ListViewSubItem(item, message.Date.ToString());
                        item.SubItems.Add(date);
                        backgroundWorker.ReportProgress((int)(i % 50 * 2), item);
                    }

                    client.Disconnect(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnLogin.Enabled = true;
                progressBar.Visible = false;
                pageSelector.Enabled = true;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void pageSelector_ValueChanged(object sender, EventArgs e)
        {
            btnLogin.PerformClick();
        }
    }
}
