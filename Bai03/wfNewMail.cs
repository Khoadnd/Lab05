using System;
using System.Collections;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

namespace Bai03
{
    public partial class wfNewMail : Form
    {
        private readonly Hashtable _users;
        private string _userName;
        private string _password;
        public wfNewMail(Hashtable usersHashtable)
        {
            InitializeComponent();
            _users = usersHashtable;
            foreach (var user in _users.Keys)
                cmbFrom.Items.Add((string)user);
        }

        private void cmbFrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _userName = cmbFrom.Text;
            _password = (string)_users[_userName];
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(_userName));
                email.To.Add(MailboxAddress.Parse(txtTo.Text.Trim()));
                email.Subject = txtSubject.Text;
                email.Body = new TextPart(TextFormat.RichText) { Text = rtxtBody.Text.Trim() };

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 465, true);
                    smtp.Authenticate(_userName, _password);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Close();
            }
            finally
            {
                MessageBox.Show(@"Sent!");
                Close();
            }
        }
    }
}
