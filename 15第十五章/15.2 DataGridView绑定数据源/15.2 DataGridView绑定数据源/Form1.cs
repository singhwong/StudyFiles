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

namespace _15._2_DataGridView绑定数据源
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBindMode.DataSource = BindModeSource().Tables[0];
            dgvNonBindMode.DataSource = NonBindSource();
        }

        private DataSet BindModeSource()
        {
            string contr = "Server=.;user=sa;pwd=sa;database=csharpzxw";
            SqlConnection mycon = new SqlConnection(contr);
            DataSet myds = new DataSet();
            try
            {
                mycon.Open();
                string sql = "select name,gender from mytable001";
                SqlDataAdapter myda = new SqlDataAdapter(sql, mycon);
                myda.Fill(myds,"mytable001");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();
            }
            return myds;
        }

        private DataTable NonBindSource()
        {
            DataTable mydt = new DataTable();
            mydt.Columns.Add("name", Type.GetType("System.String"));
            mydt.Columns.Add("gender", Type.GetType("System.String"));
            string[,] mystr = { { "张三", "女" }, { "李四", "男" }, { "王五", "男" }, { "赵六", "女" }, { "何七", "男" }, { "刘八", "女" }, { "雪上行者", "男" } };
            for (int i = 0; i < mystr.Length / 2; i++)
            {
                DataRow mydr = mydt.NewRow();
                mydr[0] = mystr[i, 0];
                mydr[1] = mystr[i, 1];
                mydt.Rows.Add(mydr);

            }
            return mydt;


        }
    }
}
