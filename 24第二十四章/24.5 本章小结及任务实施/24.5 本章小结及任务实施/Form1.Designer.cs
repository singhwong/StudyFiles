namespace _24._5_本章小结及任务实施
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSendAccount = new System.Windows.Forms.TextBox();
            this.tbSendPwd = new System.Windows.Forms.TextBox();
            this.tbSendServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAcceptAccount = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSendPwd);
            this.groupBox1.Controls.Add(this.tbSendServer);
            this.groupBox1.Controls.Add(this.tbSendAccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "账户信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tbBody);
            this.groupBox2.Controls.Add(this.tbSubject);
            this.groupBox2.Controls.Add(this.tbAcceptAccount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(868, 387);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "邮箱账户";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "邮箱密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "邮箱服务器";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "邮箱服务器地址可登录网页邮箱进行查看，如：smtp.126.com";
            // 
            // tbSendAccount
            // 
            this.tbSendAccount.Location = new System.Drawing.Point(127, 40);
            this.tbSendAccount.Name = "tbSendAccount";
            this.tbSendAccount.Size = new System.Drawing.Size(200, 21);
            this.tbSendAccount.TabIndex = 1;
            // 
            // tbSendPwd
            // 
            this.tbSendPwd.Location = new System.Drawing.Point(438, 40);
            this.tbSendPwd.Name = "tbSendPwd";
            this.tbSendPwd.PasswordChar = '★';
            this.tbSendPwd.Size = new System.Drawing.Size(232, 21);
            this.tbSendPwd.TabIndex = 2;
            // 
            // tbSendServer
            // 
            this.tbSendServer.Location = new System.Drawing.Point(127, 86);
            this.tbSendServer.Name = "tbSendServer";
            this.tbSendServer.Size = new System.Drawing.Size(200, 21);
            this.tbSendServer.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "收件人地址";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "邮件的主题";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "邮件的正文内容";
            // 
            // tbAcceptAccount
            // 
            this.tbAcceptAccount.Location = new System.Drawing.Point(127, 36);
            this.tbAcceptAccount.Name = "tbAcceptAccount";
            this.tbAcceptAccount.Size = new System.Drawing.Size(312, 21);
            this.tbAcceptAccount.TabIndex = 4;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(127, 81);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(312, 21);
            this.tbSubject.TabIndex = 5;
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(127, 145);
            this.tbBody.Multiline = true;
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(708, 236);
            this.tbBody.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 76);
            this.button1.TabIndex = 7;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "发送前请确认各项都准确填写";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "邮件发送器（自学网）";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSendPwd;
        private System.Windows.Forms.TextBox tbSendServer;
        private System.Windows.Forms.TextBox tbSendAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbAcceptAccount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

