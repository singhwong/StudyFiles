using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace _24._5_本章小结及任务实施
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string myEmail = tbSendAccount.Text;
            string myPwd = tbSendPwd.Text;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.From = new MailAddress(myEmail);
            mail.To.Add(new MailAddress(tbAcceptAccount.Text));
            mail.Subject = tbSubject.Text;
            mail.Body = tbBody.Text;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            SmtpClient client = new SmtpClient(tbSendServer.Text);
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(myEmail.Substring(0, myEmail.IndexOf('@')), myPwd);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(mail);
                MessageBox.Show("利用自己编写的邮件发送器成功发送了邮件！");
                tbSubject.Text = null;
                tbBody.Text = null;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }
    }
}
