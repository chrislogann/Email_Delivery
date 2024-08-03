using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Diagnostics.Eventing.Reader;
using System.ComponentModel;


namespace Email_Delivery
{
    public partial class Form1 : Form
    {

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public Form1()
        {
            InitializeComponent();
        }

        List<string> filename_list = new List<string>();

        private void btn_attachment_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string path = OpenFileDialog1.FileNames.ToString();


                for (int i = 0; i < OpenFileDialog1.FileNames.Count(); i++)
                {
                    filename_list.Add(OpenFileDialog1.FileNames[i].ToString());
                    MessageBox.Show(OpenFileDialog1.FileNames[i]);
                }

            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(txt_username.Text, txt_password.Text);
            client = new SmtpClient(txt_smtp.Text);
            client.Port = Convert.ToInt32(txt_port.Text);
            client.EnableSsl = cb_ssl.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txt_username.Text + txt_smtp.Text.Replace("smtp.", "@"), "Test", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txt_to.Text));
            if (!string.IsNullOrWhiteSpace(txt_cc.Text)) { msg.To.Add(new MailAddress(txt_cc.Text)); }
            msg.Subject = txt_subject.Text;
            msg.Body = txt_message.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;

            foreach (string file in filename_list)
            {
                msg.Attachments.Add(new Attachment(file));
            }

            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
        }


        private static void SendCompletedCallback(Object send, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled) { MessageBox.Show(string.Format("{0} send canceled", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            if (e.Error != null) { MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else { MessageBox.Show("Your message has been sent successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
// emaildeliverytest2024@gmail.com, TEST1234, llzs axxp epyx wvar, BTC1NG42RRK783VA4R3815HH






