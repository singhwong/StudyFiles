namespace _12._20_RadioButton控件
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.userbtn = new System.Windows.Forms.Label();
            this.pwdbtn = new System.Windows.Forms.Label();
            this.usertb = new System.Windows.Forms.TextBox();
            this.pwdtb = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(90, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "管理员";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "来宾";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // userbtn
            // 
            this.userbtn.AutoSize = true;
            this.userbtn.Location = new System.Drawing.Point(71, 28);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(41, 12);
            this.userbtn.TabIndex = 2;
            this.userbtn.Text = "用户名";
            // 
            // pwdbtn
            // 
            this.pwdbtn.AutoSize = true;
            this.pwdbtn.Location = new System.Drawing.Point(71, 62);
            this.pwdbtn.Name = "pwdbtn";
            this.pwdbtn.Size = new System.Drawing.Size(41, 12);
            this.pwdbtn.TabIndex = 3;
            this.pwdbtn.Text = "密  码";
            // 
            // usertb
            // 
            this.usertb.Location = new System.Drawing.Point(136, 25);
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(100, 21);
            this.usertb.TabIndex = 4;
            // 
            // pwdtb
            // 
            this.pwdtb.Location = new System.Drawing.Point(136, 59);
            this.pwdtb.Name = "pwdtb";
            this.pwdtb.PasswordChar = '★';
            this.pwdtb.Size = new System.Drawing.Size(100, 21);
            this.pwdtb.TabIndex = 5;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(105, 134);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "登录";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pwdtb);
            this.Controls.Add(this.usertb);
            this.Controls.Add(this.pwdbtn);
            this.Controls.Add(this.userbtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "登录窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label userbtn;
        private System.Windows.Forms.Label pwdbtn;
        private System.Windows.Forms.TextBox usertb;
        private System.Windows.Forms.TextBox pwdtb;
        private System.Windows.Forms.Button loginbtn;
    }
}

