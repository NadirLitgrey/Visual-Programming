using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Mail
{
    public partial class Form1 : Form
    {
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {

            NetworkCredential login= new NetworkCredential(txtUserName.Text, txtPass.Text);
            SmtpClient client =client = new SmtpClient("smtp.gmail.com");
            ;
            MailMessage msg;

            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            
            msg = new MailMessage { From = new MailAddress(txtUserName.Text, "Admin", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtTo.Text));
            
            if (!string.IsNullOrEmpty(txtCC.Text))
                msg.To.Add(new MailAddress(txtCC.Text));
            
            msg.Subject = txtSubject.Text;
            
            msg.Body = txtMessage.Text;
            if (filePath.Length > 0)
            {
                msg.Attachments.Add(new Attachment(filePath));
            }
            msg.BodyEncoding = Encoding.UTF8;
            
            msg.IsBodyHtml = true;
            
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
            string userstate = "Sending....";
            client.SendAsync(msg, userstate);
        }
        private static void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {

            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Mail sent Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == DialogResult.OK) {
                string path = opd.FileName.ToString();
                filePath = path;
            }

        }
    }
}