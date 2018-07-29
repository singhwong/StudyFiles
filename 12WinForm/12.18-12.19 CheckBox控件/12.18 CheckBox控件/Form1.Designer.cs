namespace _12._18_CheckBox控件
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bcb = new System.Windows.Forms.CheckBox();
            this.icb = new System.Windows.Forms.CheckBox();
            this.ucb = new System.Windows.Forms.CheckBox();
            this.changebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 15F);
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 30);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(88, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "设置字型";
            // 
            // bcb
            // 
            this.bcb.AutoSize = true;
            this.bcb.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.bcb.Location = new System.Drawing.Point(82, 92);
            this.bcb.Name = "bcb";
            this.bcb.Size = new System.Drawing.Size(70, 24);
            this.bcb.TabIndex = 2;
            this.bcb.Text = "粗体";
            this.bcb.UseVisualStyleBackColor = true;
            // 
            // icb
            // 
            this.icb.AutoSize = true;
            this.icb.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.icb.Location = new System.Drawing.Point(82, 122);
            this.icb.Name = "icb";
            this.icb.Size = new System.Drawing.Size(68, 24);
            this.icb.TabIndex = 3;
            this.icb.Text = "斜体";
            this.icb.UseVisualStyleBackColor = true;
            // 
            // ucb
            // 
            this.ucb.AutoSize = true;
            this.ucb.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucb.Location = new System.Drawing.Point(82, 152);
            this.ucb.Name = "ucb";
            this.ucb.Size = new System.Drawing.Size(88, 24);
            this.ucb.TabIndex = 4;
            this.ucb.Text = "下划线";
            this.ucb.UseVisualStyleBackColor = true;
            // 
            // changebtn
            // 
            this.changebtn.Location = new System.Drawing.Point(92, 193);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(75, 23);
            this.changebtn.TabIndex = 5;
            this.changebtn.Text = "修改";
            this.changebtn.UseVisualStyleBackColor = true;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.changebtn);
            this.Controls.Add(this.ucb);
            this.Controls.Add(this.icb);
            this.Controls.Add(this.bcb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "设置字体类型";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bcb;
        private System.Windows.Forms.CheckBox icb;
        private System.Windows.Forms.CheckBox ucb;
        private System.Windows.Forms.Button changebtn;
    }
}

