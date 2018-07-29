namespace _23._5_本章小结及任务实施
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
            this.btnPrintView = new System.Windows.Forms.Button();
            this.btnPrintCancel = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.SuspendLayout();
            // 
            // btnPrintView
            // 
            this.btnPrintView.Location = new System.Drawing.Point(79, 514);
            this.btnPrintView.Name = "btnPrintView";
            this.btnPrintView.Size = new System.Drawing.Size(200, 41);
            this.btnPrintView.TabIndex = 0;
            this.btnPrintView.Text = "打印预览";
            this.btnPrintView.UseVisualStyleBackColor = true;
            this.btnPrintView.Click += new System.EventHandler(this.btnPrintView_Click);
            // 
            // btnPrintCancel
            // 
            this.btnPrintCancel.Location = new System.Drawing.Point(373, 514);
            this.btnPrintCancel.Name = "btnPrintCancel";
            this.btnPrintCancel.Size = new System.Drawing.Size(200, 41);
            this.btnPrintCancel.TabIndex = 1;
            this.btnPrintCancel.Text = "取消预览";
            this.btnPrintCancel.UseVisualStyleBackColor = true;
            this.btnPrintCancel.Click += new System.EventHandler(this.btnPrintCancel_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(12, 12);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(643, 496);
            this.printPreviewControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 567);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.btnPrintCancel);
            this.Controls.Add(this.btnPrintView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintView;
        private System.Windows.Forms.Button btnPrintCancel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
    }
}

