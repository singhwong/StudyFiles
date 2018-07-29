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

namespace _15._7_DataGridView_直接修改数据
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection GetConnection()
        {
            string constr = "Server=.;user=sa;pwd=sa;database=csharpzxw";
            SqlConnection mycon = new SqlConnection(constr);
            return mycon;
        }
        private void dgvBind()
        {
            SqlConnection mycon = GetConnection();
            try
            {
                mycon.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from mytable001", mycon);
                DataTable table = new DataTable();
                sda.Fill(table);
                this.dataGridView1.AutoGenerateColumns = true;
                this.dataGridView1.DataSource = table;
                this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBind();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection mycon = GetConnection();
            try
            {
                mycon.Open();

                string mystr1=dataGridView1.Columns[e.ColumnIndex].HeaderText+"="+"'"+dataGridView1.CurrentCell.Value.ToString()+"'";
                string mystr2=dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string updateSql = "update mytable001 set "+mystr1+" where id="+mystr2;
                SqlCommand mycom = new SqlCommand(updateSql, mycon);
                mycom.ExecuteNonQuery();
                dgvBind();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mycon.Close();
            }

        }
    }
}
