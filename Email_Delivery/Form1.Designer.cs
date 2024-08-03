namespace Email_Delivery
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_send = new Button();
            groupBox1 = new GroupBox();
            cb_ssl = new CheckBox();
            txt_smtp = new TextBox();
            lbl_smtp = new Label();
            txt_port = new TextBox();
            lbl_port = new Label();
            txt_password = new TextBox();
            lbl_password = new Label();
            txt_username = new TextBox();
            lbl_username = new Label();
            lbl_to = new Label();
            txt_to = new TextBox();
            txt_cc = new TextBox();
            lbl_cc = new Label();
            txt_message = new TextBox();
            lbl_message = new Label();
            txt_subject = new TextBox();
            lbl_subject = new Label();
            btn_attachment = new Button();
            txt_attachment = new TextBox();
            OpenFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_send
            // 
            btn_send.Location = new Point(317, 55);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(75, 23);
            btn_send.TabIndex = 5;
            btn_send.Tag = "btn_button";
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_ssl);
            groupBox1.Controls.Add(txt_smtp);
            groupBox1.Controls.Add(lbl_smtp);
            groupBox1.Controls.Add(txt_port);
            groupBox1.Controls.Add(lbl_port);
            groupBox1.Controls.Add(txt_password);
            groupBox1.Controls.Add(lbl_password);
            groupBox1.Controls.Add(txt_username);
            groupBox1.Controls.Add(lbl_username);
            groupBox1.Controls.Add(btn_send);
            groupBox1.Location = new Point(99, 418);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 128);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // cb_ssl
            // 
            cb_ssl.AutoSize = true;
            cb_ssl.Checked = true;
            cb_ssl.CheckState = CheckState.Checked;
            cb_ssl.Location = new Point(317, 30);
            cb_ssl.Name = "cb_ssl";
            cb_ssl.Size = new Size(44, 19);
            cb_ssl.TabIndex = 1;
            cb_ssl.Text = "SSL";
            cb_ssl.UseVisualStyleBackColor = true;
            // 
            // txt_smtp
            // 
            txt_smtp.Location = new Point(185, 85);
            txt_smtp.Name = "txt_smtp";
            txt_smtp.Size = new Size(216, 23);
            txt_smtp.TabIndex = 4;
            txt_smtp.Text = "smtp.mailtrap.io";
            // 
            // lbl_smtp
            // 
            lbl_smtp.AutoSize = true;
            lbl_smtp.Location = new Point(147, 88);
            lbl_smtp.Name = "lbl_smtp";
            lbl_smtp.Size = new Size(38, 15);
            lbl_smtp.TabIndex = 12;
            lbl_smtp.Text = "Smtp:";
            // 
            // txt_port
            // 
            txt_port.Location = new Point(73, 85);
            txt_port.Name = "txt_port";
            txt_port.Size = new Size(62, 23);
            txt_port.TabIndex = 3;
            txt_port.Text = "587";
            // 
            // lbl_port
            // 
            lbl_port.AutoSize = true;
            lbl_port.Location = new Point(6, 88);
            lbl_port.Name = "lbl_port";
            lbl_port.Size = new Size(32, 15);
            lbl_port.TabIndex = 10;
            lbl_port.Text = "Port:";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(73, 56);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(224, 23);
            txt_password.TabIndex = 2;
            txt_password.Text = "57443731b6ed96";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(6, 59);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(60, 15);
            lbl_password.TabIndex = 8;
            lbl_password.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(73, 27);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(224, 23);
            txt_username.TabIndex = 0;
            txt_username.Text = "ed66531820346a";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(6, 30);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(63, 15);
            lbl_username.TabIndex = 6;
            lbl_username.Text = "Username:";
            // 
            // lbl_to
            // 
            lbl_to.AutoSize = true;
            lbl_to.Location = new Point(36, 21);
            lbl_to.Name = "lbl_to";
            lbl_to.Size = new Size(22, 15);
            lbl_to.TabIndex = 1;
            lbl_to.Text = "To:";
            // 
            // txt_to
            // 
            txt_to.Location = new Point(99, 18);
            txt_to.Name = "txt_to";
            txt_to.ScrollBars = ScrollBars.Horizontal;
            txt_to.Size = new Size(496, 23);
            txt_to.TabIndex = 0;
            txt_to.Text = "ed66531820346a@mailtrap.io";
            // 
            // txt_cc
            // 
            txt_cc.Location = new Point(99, 47);
            txt_cc.Name = "txt_cc";
            txt_cc.Size = new Size(496, 23);
            txt_cc.TabIndex = 1;
            // 
            // lbl_cc
            // 
            lbl_cc.AutoSize = true;
            lbl_cc.Location = new Point(36, 50);
            lbl_cc.Name = "lbl_cc";
            lbl_cc.Size = new Size(26, 15);
            lbl_cc.TabIndex = 1;
            lbl_cc.Text = "CC:";
            // 
            // txt_message
            // 
            txt_message.Location = new Point(99, 105);
            txt_message.Multiline = true;
            txt_message.Name = "txt_message";
            txt_message.ScrollBars = ScrollBars.Vertical;
            txt_message.Size = new Size(496, 259);
            txt_message.TabIndex = 3;
            txt_message.Text = "Multiple Attachments";
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Location = new Point(36, 108);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(56, 15);
            lbl_message.TabIndex = 1;
            lbl_message.Text = "Message:";
            // 
            // txt_subject
            // 
            txt_subject.Location = new Point(99, 76);
            txt_subject.Name = "txt_subject";
            txt_subject.Size = new Size(496, 23);
            txt_subject.TabIndex = 2;
            txt_subject.Text = "Hello World";
            // 
            // lbl_subject
            // 
            lbl_subject.AutoSize = true;
            lbl_subject.Location = new Point(36, 79);
            lbl_subject.Name = "lbl_subject";
            lbl_subject.Size = new Size(49, 15);
            lbl_subject.TabIndex = 1;
            lbl_subject.Text = "Subject:";
            // 
            // btn_attachment
            // 
            btn_attachment.Location = new Point(99, 370);
            btn_attachment.Name = "btn_attachment";
            btn_attachment.Size = new Size(119, 29);
            btn_attachment.TabIndex = 6;
            btn_attachment.Tag = "btn_button";
            btn_attachment.Text = "Add Attachments";
            btn_attachment.UseVisualStyleBackColor = true;
            btn_attachment.Click += btn_attachment_Click;
            // 
            // txt_attachment
            // 
            txt_attachment.Location = new Point(224, 374);
            txt_attachment.Multiline = true;
            txt_attachment.Name = "txt_attachment";
            txt_attachment.Size = new Size(371, 23);
            txt_attachment.TabIndex = 7;
            txt_attachment.Visible = false;
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "OpenFileDialog1";
            OpenFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 559);
            Controls.Add(txt_attachment);
            Controls.Add(btn_attachment);
            Controls.Add(txt_message);
            Controls.Add(lbl_message);
            Controls.Add(txt_subject);
            Controls.Add(lbl_subject);
            Controls.Add(txt_cc);
            Controls.Add(lbl_cc);
            Controls.Add(txt_to);
            Controls.Add(lbl_to);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Send Email";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_send;
        private GroupBox groupBox1;
        private Label lbl_to;
        private TextBox txt_to;
        private TextBox txt_cc;
        private Label lbl_cc;
        private TextBox txt_message;
        private Label lbl_message;
        private TextBox txt_subject;
        private Label lbl_subject;
        private TextBox txt_port;
        private Label lbl_port;
        private TextBox txt_password;
        private Label lbl_password;
        private TextBox txt_username;
        private Label lbl_username;
        private CheckBox cb_ssl;
        private TextBox txt_smtp;
        private Label lbl_smtp;
        private Button btn_attachment;
        private TextBox txt_attachment;
        private OpenFileDialog OpenFileDialog1;
    }
}
