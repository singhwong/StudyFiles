namespace _28_CRM_System
{
    partial class AddComplaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.btnSelectClient = new System.Windows.Forms.Button();
            this.cbbComplaintType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbComplaintMode = new System.Windows.Forms.ComboBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.dtpComplaintTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbObject = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "投诉主题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "投诉客户";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(29, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "投诉类型 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(29, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "投诉时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(29, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "投诉内容";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(98, 23);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(373, 21);
            this.tbTitle.TabIndex = 1;
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(98, 58);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(332, 21);
            this.tbClient.TabIndex = 2;
            // 
            // btnSelectClient
            // 
            this.btnSelectClient.Location = new System.Drawing.Point(437, 58);
            this.btnSelectClient.Name = "btnSelectClient";
            this.btnSelectClient.Size = new System.Drawing.Size(34, 23);
            this.btnSelectClient.TabIndex = 3;
            this.btnSelectClient.Text = "...";
            this.btnSelectClient.UseVisualStyleBackColor = true;
            this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
            // 
            // cbbComplaintType
            // 
            this.cbbComplaintType.FormattingEnabled = true;
            this.cbbComplaintType.Location = new System.Drawing.Point(98, 94);
            this.cbbComplaintType.Name = "cbbComplaintType";
            this.cbbComplaintType.Size = new System.Drawing.Size(144, 20);
            this.cbbComplaintType.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.Location = new System.Drawing.Point(263, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "投诉方式";
            // 
            // cbbComplaintMode
            // 
            this.cbbComplaintMode.FormattingEnabled = true;
            this.cbbComplaintMode.Location = new System.Drawing.Point(332, 94);
            this.cbbComplaintMode.Name = "cbbComplaintMode";
            this.cbbComplaintMode.Size = new System.Drawing.Size(138, 20);
            this.cbbComplaintMode.TabIndex = 4;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(97, 168);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(373, 64);
            this.tbContent.TabIndex = 1;
            // 
            // dtpComplaintTime
            // 
            this.dtpComplaintTime.Location = new System.Drawing.Point(99, 133);
            this.dtpComplaintTime.Name = "dtpComplaintTime";
            this.dtpComplaintTime.Size = new System.Drawing.Size(143, 21);
            this.dtpComplaintTime.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F);
            this.label7.Location = new System.Drawing.Point(263, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "投诉对象";
            // 
            // cbbObject
            // 
            this.cbbObject.FormattingEnabled = true;
            this.cbbObject.Location = new System.Drawing.Point(332, 132);
            this.cbbObject.Name = "cbbObject";
            this.cbbObject.Size = new System.Drawing.Size(138, 20);
            this.cbbObject.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(99, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(266, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 290);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpComplaintTime);
            this.Controls.Add(this.cbbObject);
            this.Controls.Add(this.cbbComplaintMode);
            this.Controls.Add(this.cbbComplaintType);
            this.Controls.Add(this.btnSelectClient);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddComplaint";
            this.Text = "投诉";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.ComboBox cbbComplaintType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbComplaintMode;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.DateTimePicker dtpComplaintTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbObject;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}