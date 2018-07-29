namespace _29_Lottery
{
    partial class main
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnG = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnZX6 = new System.Windows.Forms.RadioButton();
            this.rbtnZX3 = new System.Windows.Forms.RadioButton();
            this.rbtnZX = new System.Windows.Forms.RadioButton();
            this.rbtnDX = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbSpaceValue = new System.Windows.Forms.CheckBox();
            this.tbSpaceValue = new System.Windows.Forms.TextBox();
            this.cbSG = new System.Windows.Forms.CheckBox();
            this.cbID = new System.Windows.Forms.CheckBox();
            this.tbSG = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbBG = new System.Windows.Forms.CheckBox();
            this.cbAC = new System.Windows.Forms.CheckBox();
            this.tbBG = new System.Windows.Forms.TextBox();
            this.tbAC = new System.Windows.Forms.TextBox();
            this.cbBS = new System.Windows.Forms.CheckBox();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.tbBS = new System.Windows.Forms.TextBox();
            this.btnSpaceValue = new System.Windows.Forms.Button();
            this.btnSG = new System.Windows.Forms.Button();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.cbAve = new System.Windows.Forms.CheckBox();
            this.btnID = new System.Windows.Forms.Button();
            this.btnBG = new System.Windows.Forms.Button();
            this.cbMid = new System.Windows.Forms.CheckBox();
            this.tbAve = new System.Windows.Forms.TextBox();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.tbMid = new System.Windows.Forms.TextBox();
            this.cbSpan = new System.Windows.Forms.CheckBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAve = new System.Windows.Forms.Button();
            this.cbMax = new System.Windows.Forms.CheckBox();
            this.tbSpan = new System.Windows.Forms.TextBox();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnSpan = new System.Windows.Forms.Button();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "投注结果";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(228, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnG);
            this.groupBox2.Controls.Add(this.btnS);
            this.groupBox2.Controls.Add(this.tbG);
            this.groupBox2.Controls.Add(this.tbS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(259, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "号码设置";
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(519, 25);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(35, 23);
            this.btnG.TabIndex = 2;
            this.btnG.Text = "...";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnG_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(340, 25);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(35, 23);
            this.btnS.TabIndex = 2;
            this.btnS.Text = "...";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(413, 27);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(100, 21);
            this.tbG.TabIndex = 1;
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(234, 27);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 21);
            this.tbS.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "个位";
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(159, 25);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(35, 23);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "...";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "十位";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(53, 27);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 21);
            this.tbB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "百位";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnZX6);
            this.groupBox3.Controls.Add(this.rbtnZX3);
            this.groupBox3.Controls.Add(this.rbtnZX);
            this.groupBox3.Controls.Add(this.rbtnDX);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(259, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(563, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // rbtnZX6
            // 
            this.rbtnZX6.AutoSize = true;
            this.rbtnZX6.Location = new System.Drawing.Point(457, 21);
            this.rbtnZX6.Name = "rbtnZX6";
            this.rbtnZX6.Size = new System.Drawing.Size(77, 16);
            this.rbtnZX6.TabIndex = 1;
            this.rbtnZX6.TabStop = true;
            this.rbtnZX6.Text = "组选6投注";
            this.rbtnZX6.UseVisualStyleBackColor = true;
            // 
            // rbtnZX3
            // 
            this.rbtnZX3.AutoSize = true;
            this.rbtnZX3.Location = new System.Drawing.Point(335, 20);
            this.rbtnZX3.Name = "rbtnZX3";
            this.rbtnZX3.Size = new System.Drawing.Size(77, 16);
            this.rbtnZX3.TabIndex = 1;
            this.rbtnZX3.TabStop = true;
            this.rbtnZX3.Text = "组选3投注";
            this.rbtnZX3.UseVisualStyleBackColor = true;
            // 
            // rbtnZX
            // 
            this.rbtnZX.AutoSize = true;
            this.rbtnZX.Location = new System.Drawing.Point(213, 20);
            this.rbtnZX.Name = "rbtnZX";
            this.rbtnZX.Size = new System.Drawing.Size(71, 16);
            this.rbtnZX.TabIndex = 1;
            this.rbtnZX.TabStop = true;
            this.rbtnZX.Text = "组选投注";
            this.rbtnZX.UseVisualStyleBackColor = true;
            // 
            // rbtnDX
            // 
            this.rbtnDX.AutoSize = true;
            this.rbtnDX.Location = new System.Drawing.Point(91, 20);
            this.rbtnDX.Name = "rbtnDX";
            this.rbtnDX.Size = new System.Drawing.Size(71, 16);
            this.rbtnDX.TabIndex = 1;
            this.rbtnDX.TabStop = true;
            this.rbtnDX.Text = "单选投注";
            this.rbtnDX.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "投注类型：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTake);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.cbSpaceValue);
            this.groupBox4.Controls.Add(this.tbSpaceValue);
            this.groupBox4.Controls.Add(this.cbSG);
            this.groupBox4.Controls.Add(this.cbID);
            this.groupBox4.Controls.Add(this.tbSG);
            this.groupBox4.Controls.Add(this.tbID);
            this.groupBox4.Controls.Add(this.cbBG);
            this.groupBox4.Controls.Add(this.cbAC);
            this.groupBox4.Controls.Add(this.tbBG);
            this.groupBox4.Controls.Add(this.tbAC);
            this.groupBox4.Controls.Add(this.cbBS);
            this.groupBox4.Controls.Add(this.cbMin);
            this.groupBox4.Controls.Add(this.tbBS);
            this.groupBox4.Controls.Add(this.btnSpaceValue);
            this.groupBox4.Controls.Add(this.btnSG);
            this.groupBox4.Controls.Add(this.tbMin);
            this.groupBox4.Controls.Add(this.cbAve);
            this.groupBox4.Controls.Add(this.btnID);
            this.groupBox4.Controls.Add(this.btnBG);
            this.groupBox4.Controls.Add(this.cbMid);
            this.groupBox4.Controls.Add(this.tbAve);
            this.groupBox4.Controls.Add(this.btnAC);
            this.groupBox4.Controls.Add(this.btnBS);
            this.groupBox4.Controls.Add(this.tbMid);
            this.groupBox4.Controls.Add(this.cbSpan);
            this.groupBox4.Controls.Add(this.btnMin);
            this.groupBox4.Controls.Add(this.btnAve);
            this.groupBox4.Controls.Add(this.cbMax);
            this.groupBox4.Controls.Add(this.tbSpan);
            this.groupBox4.Controls.Add(this.btnMid);
            this.groupBox4.Controls.Add(this.btnSpan);
            this.groupBox4.Controls.Add(this.tbMax);
            this.groupBox4.Controls.Add(this.btnMax);
            this.groupBox4.Location = new System.Drawing.Point(259, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 271);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(461, 231);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(75, 23);
            this.btnTake.TabIndex = 3;
            this.btnTake.Text = "投注";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(380, 231);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbSpaceValue
            // 
            this.cbSpaceValue.AutoSize = true;
            this.cbSpaceValue.Location = new System.Drawing.Point(30, 235);
            this.cbSpaceValue.Name = "cbSpaceValue";
            this.cbSpaceValue.Size = new System.Drawing.Size(60, 16);
            this.cbSpaceValue.TabIndex = 0;
            this.cbSpaceValue.Text = "码距值";
            this.cbSpaceValue.UseVisualStyleBackColor = true;
            // 
            // tbSpaceValue
            // 
            this.tbSpaceValue.Location = new System.Drawing.Point(111, 233);
            this.tbSpaceValue.Name = "tbSpaceValue";
            this.tbSpaceValue.Size = new System.Drawing.Size(218, 21);
            this.tbSpaceValue.TabIndex = 1;
            // 
            // cbSG
            // 
            this.cbSG.AutoSize = true;
            this.cbSG.Location = new System.Drawing.Point(312, 190);
            this.cbSG.Name = "cbSG";
            this.cbSG.Size = new System.Drawing.Size(84, 16);
            this.cbSG.TabIndex = 0;
            this.cbSG.Text = "十个绝对值";
            this.cbSG.UseVisualStyleBackColor = true;
            // 
            // cbID
            // 
            this.cbID.AutoSize = true;
            this.cbID.Location = new System.Drawing.Point(30, 193);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(48, 16);
            this.cbID.TabIndex = 0;
            this.cbID.Text = "ID值";
            this.cbID.UseVisualStyleBackColor = true;
            // 
            // tbSG
            // 
            this.tbSG.Location = new System.Drawing.Point(396, 188);
            this.tbSG.Name = "tbSG";
            this.tbSG.Size = new System.Drawing.Size(100, 21);
            this.tbSG.TabIndex = 1;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(111, 191);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 1;
            // 
            // cbBG
            // 
            this.cbBG.AutoSize = true;
            this.cbBG.Location = new System.Drawing.Point(312, 147);
            this.cbBG.Name = "cbBG";
            this.cbBG.Size = new System.Drawing.Size(84, 16);
            this.cbBG.TabIndex = 0;
            this.cbBG.Text = "百个绝对值";
            this.cbBG.UseVisualStyleBackColor = true;
            // 
            // cbAC
            // 
            this.cbAC.AutoSize = true;
            this.cbAC.Location = new System.Drawing.Point(30, 150);
            this.cbAC.Name = "cbAC";
            this.cbAC.Size = new System.Drawing.Size(48, 16);
            this.cbAC.TabIndex = 0;
            this.cbAC.Text = "AC值";
            this.cbAC.UseVisualStyleBackColor = true;
            // 
            // tbBG
            // 
            this.tbBG.Location = new System.Drawing.Point(396, 145);
            this.tbBG.Name = "tbBG";
            this.tbBG.Size = new System.Drawing.Size(100, 21);
            this.tbBG.TabIndex = 1;
            // 
            // tbAC
            // 
            this.tbAC.Location = new System.Drawing.Point(111, 148);
            this.tbAC.Name = "tbAC";
            this.tbAC.Size = new System.Drawing.Size(100, 21);
            this.tbAC.TabIndex = 1;
            // 
            // cbBS
            // 
            this.cbBS.AutoSize = true;
            this.cbBS.Location = new System.Drawing.Point(312, 102);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(84, 16);
            this.cbBS.TabIndex = 0;
            this.cbBS.Text = "百十绝对值";
            this.cbBS.UseVisualStyleBackColor = true;
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Location = new System.Drawing.Point(30, 105);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(60, 16);
            this.cbMin.TabIndex = 0;
            this.cbMin.Text = "最小码";
            this.cbMin.UseVisualStyleBackColor = true;
            // 
            // tbBS
            // 
            this.tbBS.Location = new System.Drawing.Point(397, 100);
            this.tbBS.Name = "tbBS";
            this.tbBS.Size = new System.Drawing.Size(100, 21);
            this.tbBS.TabIndex = 1;
            // 
            // btnSpaceValue
            // 
            this.btnSpaceValue.Location = new System.Drawing.Point(335, 231);
            this.btnSpaceValue.Name = "btnSpaceValue";
            this.btnSpaceValue.Size = new System.Drawing.Size(35, 23);
            this.btnSpaceValue.TabIndex = 2;
            this.btnSpaceValue.Text = "...";
            this.btnSpaceValue.UseVisualStyleBackColor = true;
            this.btnSpaceValue.Click += new System.EventHandler(this.btnSpaceValue_Click);
            // 
            // btnSG
            // 
            this.btnSG.Location = new System.Drawing.Point(502, 186);
            this.btnSG.Name = "btnSG";
            this.btnSG.Size = new System.Drawing.Size(35, 23);
            this.btnSG.TabIndex = 2;
            this.btnSG.Text = "...";
            this.btnSG.UseVisualStyleBackColor = true;
            this.btnSG.Click += new System.EventHandler(this.btnSG_Click);
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(111, 103);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(100, 21);
            this.tbMin.TabIndex = 1;
            // 
            // cbAve
            // 
            this.cbAve.AutoSize = true;
            this.cbAve.Location = new System.Drawing.Point(312, 58);
            this.cbAve.Name = "cbAve";
            this.cbAve.Size = new System.Drawing.Size(60, 16);
            this.cbAve.TabIndex = 0;
            this.cbAve.Text = "平均值";
            this.cbAve.UseVisualStyleBackColor = true;
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(217, 189);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(35, 23);
            this.btnID.TabIndex = 2;
            this.btnID.Text = "...";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // btnBG
            // 
            this.btnBG.Location = new System.Drawing.Point(502, 143);
            this.btnBG.Name = "btnBG";
            this.btnBG.Size = new System.Drawing.Size(35, 23);
            this.btnBG.TabIndex = 2;
            this.btnBG.Text = "...";
            this.btnBG.UseVisualStyleBackColor = true;
            this.btnBG.Click += new System.EventHandler(this.btnBG_Click);
            // 
            // cbMid
            // 
            this.cbMid.AutoSize = true;
            this.cbMid.Location = new System.Drawing.Point(30, 61);
            this.cbMid.Name = "cbMid";
            this.cbMid.Size = new System.Drawing.Size(60, 16);
            this.cbMid.TabIndex = 0;
            this.cbMid.Text = "中间码";
            this.cbMid.UseVisualStyleBackColor = true;
            // 
            // tbAve
            // 
            this.tbAve.Location = new System.Drawing.Point(396, 56);
            this.tbAve.Name = "tbAve";
            this.tbAve.Size = new System.Drawing.Size(100, 21);
            this.tbAve.TabIndex = 1;
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(217, 146);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(35, 23);
            this.btnAC.TabIndex = 2;
            this.btnAC.Text = "...";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnBS
            // 
            this.btnBS.Location = new System.Drawing.Point(502, 98);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(35, 23);
            this.btnBS.TabIndex = 2;
            this.btnBS.Text = "...";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // tbMid
            // 
            this.tbMid.Location = new System.Drawing.Point(111, 59);
            this.tbMid.Name = "tbMid";
            this.tbMid.Size = new System.Drawing.Size(100, 21);
            this.tbMid.TabIndex = 1;
            // 
            // cbSpan
            // 
            this.cbSpan.AutoSize = true;
            this.cbSpan.Location = new System.Drawing.Point(312, 18);
            this.cbSpan.Name = "cbSpan";
            this.cbSpan.Size = new System.Drawing.Size(48, 16);
            this.cbSpan.TabIndex = 0;
            this.cbSpan.Text = "跨度";
            this.cbSpan.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(217, 101);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(35, 23);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "...";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAve
            // 
            this.btnAve.Location = new System.Drawing.Point(502, 54);
            this.btnAve.Name = "btnAve";
            this.btnAve.Size = new System.Drawing.Size(35, 23);
            this.btnAve.TabIndex = 2;
            this.btnAve.Text = "...";
            this.btnAve.UseVisualStyleBackColor = true;
            this.btnAve.Click += new System.EventHandler(this.btnAve_Click);
            // 
            // cbMax
            // 
            this.cbMax.AutoSize = true;
            this.cbMax.Location = new System.Drawing.Point(30, 21);
            this.cbMax.Name = "cbMax";
            this.cbMax.Size = new System.Drawing.Size(60, 16);
            this.cbMax.TabIndex = 0;
            this.cbMax.Text = "最大码";
            this.cbMax.UseVisualStyleBackColor = true;
            // 
            // tbSpan
            // 
            this.tbSpan.Location = new System.Drawing.Point(396, 16);
            this.tbSpan.Name = "tbSpan";
            this.tbSpan.Size = new System.Drawing.Size(100, 21);
            this.tbSpan.TabIndex = 1;
            // 
            // btnMid
            // 
            this.btnMid.Location = new System.Drawing.Point(217, 57);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(35, 23);
            this.btnMid.TabIndex = 2;
            this.btnMid.Text = "...";
            this.btnMid.UseVisualStyleBackColor = true;
            this.btnMid.Click += new System.EventHandler(this.btnMid_Click);
            // 
            // btnSpan
            // 
            this.btnSpan.Location = new System.Drawing.Point(502, 14);
            this.btnSpan.Name = "btnSpan";
            this.btnSpan.Size = new System.Drawing.Size(35, 23);
            this.btnSpan.TabIndex = 2;
            this.btnSpan.Text = "...";
            this.btnSpan.UseVisualStyleBackColor = true;
            this.btnSpan.Click += new System.EventHandler(this.btnSpan_Click);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(111, 19);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 21);
            this.tbMax.TabIndex = 1;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(217, 17);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(35, 23);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "...";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(36, 385);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(59, 12);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "投注：0注";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(130, 385);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(83, 12);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "投注金额：0元";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 436);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "main";
            this.Text = "投注";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnZX6;
        private System.Windows.Forms.RadioButton rbtnZX3;
        private System.Windows.Forms.RadioButton rbtnZX;
        private System.Windows.Forms.RadioButton rbtnDX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSpaceValue;
        private System.Windows.Forms.TextBox tbSpaceValue;
        private System.Windows.Forms.CheckBox cbSG;
        private System.Windows.Forms.CheckBox cbID;
        private System.Windows.Forms.TextBox tbSG;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.CheckBox cbBG;
        private System.Windows.Forms.CheckBox cbAC;
        private System.Windows.Forms.TextBox tbBG;
        private System.Windows.Forms.TextBox tbAC;
        private System.Windows.Forms.CheckBox cbBS;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.TextBox tbBS;
        private System.Windows.Forms.Button btnSpaceValue;
        private System.Windows.Forms.Button btnSG;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.CheckBox cbAve;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnBG;
        private System.Windows.Forms.CheckBox cbMid;
        private System.Windows.Forms.TextBox tbAve;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.TextBox tbMid;
        private System.Windows.Forms.CheckBox cbSpan;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnAve;
        private System.Windows.Forms.CheckBox cbMax;
        private System.Windows.Forms.TextBox tbSpan;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnSpan;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblSum;
    }
}

