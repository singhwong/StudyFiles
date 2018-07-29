using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._10_DataGridView隔行显示不同颜色
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“csharpzxwDataSet.mytable001”中。您可以根据需要移动或删除它。
            this.mytable001TableAdapter.Fill(this.csharpzxwDataSet.mytable001);

            //for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            //{
            //    if (i % 2 == 0)
            //        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
            //    else
            //        this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Violet;

            //}
            this.dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Peru;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.SaddleBrown;


        }
    }
}
