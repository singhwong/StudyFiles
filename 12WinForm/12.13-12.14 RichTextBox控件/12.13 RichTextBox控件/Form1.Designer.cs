namespace _12._13_RichTextBox控件
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bluebtn = new System.Windows.Forms.Button();
            this.redbtn = new System.Windows.Forms.Button();
            this.ls18btn = new System.Windows.Forms.Button();
            this.ls20btn = new System.Windows.Forms.Button();
            this.kt18btn = new System.Windows.Forms.Button();
            this.itembtn = new System.Windows.Forms.Button();
            this.kt20btn = new System.Windows.Forms.Button();
            this.dwbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 15F);
            this.richTextBox1.Location = new System.Drawing.Point(13, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(414, 346);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.Location = new System.Drawing.Point(126, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "文本插入区(操作时请先选中文本)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(450, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "操作区";
            // 
            // bluebtn
            // 
            this.bluebtn.Location = new System.Drawing.Point(447, 53);
            this.bluebtn.Name = "bluebtn";
            this.bluebtn.Size = new System.Drawing.Size(75, 35);
            this.bluebtn.TabIndex = 3;
            this.bluebtn.Text = "蓝色";
            this.bluebtn.UseVisualStyleBackColor = true;
            this.bluebtn.Click += new System.EventHandler(this.bluebtn_Click);
            // 
            // redbtn
            // 
            this.redbtn.Location = new System.Drawing.Point(447, 92);
            this.redbtn.Name = "redbtn";
            this.redbtn.Size = new System.Drawing.Size(75, 35);
            this.redbtn.TabIndex = 4;
            this.redbtn.Text = "红色";
            this.redbtn.UseVisualStyleBackColor = true;
            this.redbtn.Click += new System.EventHandler(this.redbtn_Click);
            // 
            // ls18btn
            // 
            this.ls18btn.Location = new System.Drawing.Point(447, 131);
            this.ls18btn.Name = "ls18btn";
            this.ls18btn.Size = new System.Drawing.Size(75, 35);
            this.ls18btn.TabIndex = 5;
            this.ls18btn.Text = "隶书 18";
            this.ls18btn.UseVisualStyleBackColor = true;
            this.ls18btn.Click += new System.EventHandler(this.ls18btn_Click);
            // 
            // ls20btn
            // 
            this.ls20btn.Location = new System.Drawing.Point(447, 170);
            this.ls20btn.Name = "ls20btn";
            this.ls20btn.Size = new System.Drawing.Size(75, 35);
            this.ls20btn.TabIndex = 6;
            this.ls20btn.Text = "隶书 20";
            this.ls20btn.UseVisualStyleBackColor = true;
            this.ls20btn.Click += new System.EventHandler(this.ls20btn_Click);
            // 
            // kt18btn
            // 
            this.kt18btn.Location = new System.Drawing.Point(447, 209);
            this.kt18btn.Name = "kt18btn";
            this.kt18btn.Size = new System.Drawing.Size(75, 35);
            this.kt18btn.TabIndex = 7;
            this.kt18btn.Text = "楷体 18";
            this.kt18btn.UseVisualStyleBackColor = true;
            this.kt18btn.Click += new System.EventHandler(this.kt18btn_Click);
            // 
            // itembtn
            // 
            this.itembtn.Location = new System.Drawing.Point(447, 287);
            this.itembtn.Name = "itembtn";
            this.itembtn.Size = new System.Drawing.Size(75, 35);
            this.itembtn.TabIndex = 8;
            this.itembtn.Text = "项目符号";
            this.itembtn.UseVisualStyleBackColor = true;
            this.itembtn.Click += new System.EventHandler(this.itembtn_Click);
            // 
            // kt20btn
            // 
            this.kt20btn.Location = new System.Drawing.Point(447, 248);
            this.kt20btn.Name = "kt20btn";
            this.kt20btn.Size = new System.Drawing.Size(75, 35);
            this.kt20btn.TabIndex = 9;
            this.kt20btn.Text = "楷体 20";
            this.kt20btn.UseVisualStyleBackColor = true;
            this.kt20btn.Click += new System.EventHandler(this.kt20btn_Click);
            // 
            // dwbtn
            // 
            this.dwbtn.Location = new System.Drawing.Point(447, 326);
            this.dwbtn.Name = "dwbtn";
            this.dwbtn.Size = new System.Drawing.Size(75, 35);
            this.dwbtn.TabIndex = 10;
            this.dwbtn.Text = "底纹";
            this.dwbtn.UseVisualStyleBackColor = true;
            this.dwbtn.Click += new System.EventHandler(this.dwbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(447, 365);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 35);
            this.resetbtn.TabIndex = 11;
            this.resetbtn.Text = "复原";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.dwbtn);
            this.Controls.Add(this.kt20btn);
            this.Controls.Add(this.itembtn);
            this.Controls.Add(this.kt18btn);
            this.Controls.Add(this.ls20btn);
            this.Controls.Add(this.ls18btn);
            this.Controls.Add(this.redbtn);
            this.Controls.Add(this.bluebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bluebtn;
        private System.Windows.Forms.Button redbtn;
        private System.Windows.Forms.Button ls18btn;
        private System.Windows.Forms.Button ls20btn;
        private System.Windows.Forms.Button kt18btn;
        private System.Windows.Forms.Button itembtn;
        private System.Windows.Forms.Button kt20btn;
        private System.Windows.Forms.Button dwbtn;
        private System.Windows.Forms.Button resetbtn;
    }
}

