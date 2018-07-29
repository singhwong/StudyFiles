using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _15._11_DataDridView分页显示
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlDataAdapter pagingDA;
        private DataSet pagingDS = new DataSet();
        private int StartVal = 0;//起始值
        private int valPerPage = 3;//每页显示的内容
        private int totalValNumber;//总条数
        private int currentPage = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            string constr = "Server=.;user=sa;pwd=sa;database=csharpzxw";
            SqlConnection mycon = new SqlConnection(constr);
            try
            {
                mycon.Open();
                string sql = "select * from mytable001";
                pagingDA = new SqlDataAdapter(sql, mycon);
                pagingDA.Fill(pagingDS, "mytable001");
                mycon.Close();
                totalValNumber = pagingDS.Tables[0].Rows.Count;
                //总页数计算
                int totalPageNumber = (totalValNumber % valPerPage == 0) ? (totalValNumber / valPerPage) : (totalValNumber / valPerPage + 1);
                toolStripLabel1.Text = "/" + totalPageNumber;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void LoadData()
        {
            currentPage = StartVal / valPerPage + 1;
            toolStripTextBox1.Text = currentPage.ToString();
            pagingDS.Clear();
            pagingDA.Fill(pagingDS, StartVal, valPerPage, "mytable001");
            bindingSource1.DataSource = pagingDS.Tables[0];
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;

        }

        private void bindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "上一页")
            {
                StartVal = StartVal - valPerPage;
                if (StartVal < 0)
                {
                    MessageBox.Show("已经是第一页");
                    StartVal = 0;
                    return;
                }
            }
            if (e.ClickedItem.Text == "下一页")
            {
                StartVal = StartVal + valPerPage;
                if (StartVal > totalValNumber)
                {
                    MessageBox.Show("已经是最后一页");
                    StartVal = StartVal - valPerPage;
                    return;
                }
            }
            LoadData();

        }
    }
}
