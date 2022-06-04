using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;

namespace Bai03
{
    public partial class ucList : UserControl
    {
        private readonly List<TreeNode> _unselectableNodes = new List<TreeNode>();
        public Hashtable Users { get; set; }

        public TreeNode Node { get; set; }

        public ucList()
        {
            InitializeComponent();
            Users = new Hashtable();
        }

        private async void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUserForm = new wfAddUser();
            var result = addUserForm.ShowDialog();
            if (result != DialogResult.OK) return;

            try
            {
                await Auth(addUserForm.UserName, addUserForm.Password);
                MessageBox.Show(@"Login successful");
                Add(addUserForm.UserName, addUserForm.Password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static Task Auth(string username, string password)
        {
            var imapClient = new ImapClient();
            imapClient.Connect("imap.gmail.com", 993, true);
            imapClient.Authenticate(username, password);

            var smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 465, true);
            smtpClient.Authenticate(username, password);

            return Task.CompletedTask;
        }

        private async void Add(string username, string password)
        {
            if (Users.Contains(username))
            {
                MessageBox.Show(@"Already added");
                return;
            }

            var imapClient = new ImapClient();
            await imapClient.ConnectAsync("imap.gmail.com", 993, true);
            await imapClient.AuthenticateAsync(username, password);

            Users.Add(username, password);
            treeView1.Nodes.Add(username, username);
            _unselectableNodes.Add(treeView1.Nodes[username]);

            var folders = await imapClient.GetFoldersAsync(imapClient.PersonalNamespaces[0]);

            foreach (var folder in folders)
                treeView1.Nodes[username].Nodes.Add(folder.Name);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Node = treeView1.SelectedNode;
            var main = (Main)ParentForm;
            main?.userControl2.SetParameters(Node.Parent.Text, (string)Users[Node.Parent.Text], Node.Text);
            main?.userControl2.PopulateList();
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (!_unselectableNodes.Contains(e.Node)) return;

            if (e.Node.IsExpanded)
                e.Node.Collapse();
            else
                e.Node.ExpandAll();
            e.Cancel = true;
        }
    }
}
