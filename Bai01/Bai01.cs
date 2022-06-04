using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Lab05
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (var smtpClient = new SmtpClient("127.0.0.1"))
            {
                var mailFrom = txtFrom.Text.Trim();
                var mailTo = txtTo.Text.Trim();
                var password = txtPassword.Text.Trim();
                var basicCredential = new NetworkCredential(mailFrom, password);
                using (var message = new MailMessage())
                {
                    var fromAddress = new MailAddress(mailFrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = txtSubject.Text.Trim();
                    message.IsBodyHtml = true;
                    message.Body = txtBody.Text;
                    message.To.Add(mailTo);

                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        MessageBox.Show(@"Send completed!");
                        txtTo.Clear();
                        txtSubject.Clear();
                        txtBody.Clear();
                    }
                }
            }
        }
    }
}
