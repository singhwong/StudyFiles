namespace _12._25_Panel控件
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
            this.btnRegular = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnAppearance = new System.Windows.Forms.Button();
            this.btnRemteDownload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRegular
            // 
            this.btnRegular.FlatAppearance.BorderSize = 0;
            this.btnRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegular.Location = new System.Drawing.Point(45, 32);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(75, 23);
            this.btnRegular.TabIndex = 0;
            this.btnRegular.Text = "常规";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(45, 78);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "下载";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnAppearance
            // 
            this.btnAppearance.FlatAppearance.BorderSize = 0;
            this.btnAppearance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppearance.Location = new System.Drawing.Point(45, 124);
            this.btnAppearance.Name = "btnAppearance";
            this.btnAppearance.Size = new System.Drawing.Size(75, 23);
            this.btnAppearance.TabIndex = 2;
            this.btnAppearance.Text = "外观";
            this.btnAppearance.UseVisualStyleBackColor = true;
            this.btnAppearance.Click += new System.EventHandler(this.btnAppearance_Click);
            // 
            // btnRemteDownload
            // 
            this.btnRemteDownload.FlatAppearance.BorderSize = 0;
            this.btnRemteDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemteDownload.Location = new System.Drawing.Point(45, 170);
            this.btnRemteDownload.Name = "btnRemteDownload";
            this.btnRemteDownload.Size = new System.Drawing.Size(75, 23);
            this.btnRemteDownload.TabIndex = 3;
            this.btnRemteDownload.Text = "远程下载";
            this.btnRemteDownload.UseVisualStyleBackColor = true;
            this.btnRemteDownload.Click += new System.EventHandler(this.btnRemteDownload_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(160, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 170);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 232);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemteDownload);
            this.Controls.Add(this.btnAppearance);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnRegular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "下载选项设置";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegular;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnAppearance;
        private System.Windows.Forms.Button btnRemteDownload;
        private System.Windows.Forms.Panel panel1;
    }
}

