using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_CRM_System
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        common com = new common();
        database db = new database();

        //显示客户的方法
        private void showCustomer()
        {
            com.bindDGV(dataGridView1,"select * from customer order by id desc");
        }
        private void client_Load(object sender, EventArgs e)
        {
            showCustomer();
        }

        //添加客户
        private void showForm(int t)
        {
            Addclient ac = new Addclient();
            ac.ID = t;
            DialogResult result = ac.ShowDialog();
            if (result == DialogResult.OK)
            {
                showCustomer();
            }
        }

        //修改客户
        private void modclient()
        {
            if (dataGridView1.RowCount > 0)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    if (value != null && value != string.Empty)
                    {
                        showForm(int.Parse(value));
                    }
                    else
                    {
                        MessageBox.Show("所选择行不存在数据");
                    }
                }
                else
                {
                    MessageBox.Show("请选择一行要修改的数据！");
                }
            }
            else
            {
                MessageBox.Show("目前没有任何数据");
            }
        }

        private void delClient()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    string selectID = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                    if (selectID != null && selectID != string.Empty)
                    {
                        db.runSql("delete customer where id="+selectID);
                    }
                }
                showCustomer();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tslblAdd")
            {
                modclient();
            }
            if (e.ClickedItem.Name == "tslblMod")
            {
                modclient();
            }
            if (e.ClickedItem.Name == "tslblDel")
            {
                DialogResult status = MessageBox.Show("你确认删除所选择的行吗？", "确认对话框", MessageBoxButtons.YesNo);
                if (status == DialogResult.Yes)
                { modclient(); }
                
            }



        }
    }
}
