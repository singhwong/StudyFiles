using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._3_DataGridView获取当前单元格
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

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取行列索引

            //1种方式
            //int row = e.RowIndex + 1;
            //int col = e.ColumnIndex + 1;


            //2种方式
            //int row = dataGridView1.CurrentCell.RowIndex + 1;
            //int col = dataGridView1.CurrentCell.ColumnIndex + 1;

            //3种方式
            //int row = dataGridView1.CurrentCellAddress.Y + 1;
            int col = dataGridView1.CurrentCellAddress.X + 1;

            //4种行的引用
            int row = dataGridView1.CurrentRow.Index + 1;

            //获取单元格的内容value
            //1种方式
            //string cell = dataGridView1.Rows[row-1].Cells[col-1].Value.ToString();
            //2种方式

            string cell = dataGridView1.CurrentCell.Value.ToString();

            


            MessageBox.Show("你点击的是:第"+row.ToString()+"行,第"+col.ToString()+"列\n内容为:"+cell);

        }
    }
}
