namespace _13._5_ListView控件
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEngName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IliSmall = new System.Windows.Forms.ImageList(this.components);
            this.iLiLarge = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(177, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "查看";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "LargeIcon",
            "SmallIcon",
            "List",
            "Details",
            "Tile"});
            this.comboBox1.Location = new System.Drawing.Point(246, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chEngName,
            this.chCountry,
            this.chCapital});
            this.listView1.LargeImageList = this.iLiLarge;
            this.listView1.Location = new System.Drawing.Point(12, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(554, 380);
            this.listView1.SmallImageList = this.IliSmall;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "序号";
            this.chID.Width = 85;
            // 
            // chEngName
            // 
            this.chEngName.Text = "英文名";
            this.chEngName.Width = 112;
            // 
            // chCountry
            // 
            this.chCountry.Text = "国家";
            this.chCountry.Width = 84;
            // 
            // chCapital
            // 
            this.chCapital.Text = "首都";
            this.chCapital.Width = 94;
            // 
            // IliSmall
            // 
            this.IliSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IliSmall.ImageStream")));
            this.IliSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.IliSmall.Images.SetKeyName(0, "中国.png");
            this.IliSmall.Images.SetKeyName(1, "韩国.ico");
            this.IliSmall.Images.SetKeyName(2, "加拿大.ico");
            this.IliSmall.Images.SetKeyName(3, "美国.png");
            this.IliSmall.Images.SetKeyName(4, "日本.png");
            this.IliSmall.Images.SetKeyName(5, "新加坡.png");
            this.IliSmall.Images.SetKeyName(6, "英国.png");
            this.IliSmall.Images.SetKeyName(7, "越南.png");
            // 
            // iLiLarge
            // 
            this.iLiLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLiLarge.ImageStream")));
            this.iLiLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.iLiLarge.Images.SetKeyName(0, "中国.png");
            this.iLiLarge.Images.SetKeyName(1, "韩国.ico");
            this.iLiLarge.Images.SetKeyName(2, "加拿大.ico");
            this.iLiLarge.Images.SetKeyName(3, "美国.png");
            this.iLiLarge.Images.SetKeyName(4, "日本.png");
            this.iLiLarge.Images.SetKeyName(5, "新加坡.png");
            this.iLiLarge.Images.SetKeyName(6, "英国.png");
            this.iLiLarge.Images.SetKeyName(7, "越南.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 459);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chEngName;
        private System.Windows.Forms.ColumnHeader chCountry;
        private System.Windows.Forms.ColumnHeader chCapital;
        private System.Windows.Forms.ImageList IliSmall;
        private System.Windows.Forms.ImageList iLiLarge;
    }
}

