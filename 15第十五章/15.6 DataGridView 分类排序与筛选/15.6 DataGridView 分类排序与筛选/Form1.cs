using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._6_DataGridView_分类排序与筛选
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[3],ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataView dv;
            dv = new DataView(this.csharpzxwDataSet.mytable001,"department='开发部'","age Asc",DataViewRowState.CurrentRows);
            dataGridView1.DataSource = dv;

        }
    }
}
