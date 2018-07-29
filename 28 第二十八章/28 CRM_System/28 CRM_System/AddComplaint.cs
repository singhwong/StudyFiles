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
    public partial class AddComplaint : Form
    {
        public AddComplaint()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        database db = new database();

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            SelectClient sc = new SelectClient();
            DialogResult result = sc.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbClient.Text = sc.Person;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入投诉的主题！");
                tbTitle.Focus();
                return;
            }
            if (tbClient.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请选择投诉客户！");
                tbClient.Focus();
                return;
            }
            if (tbContent.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入投诉内容！");
                tbContent.Focus();
                return;
            }
            db.runSql("insert into complaint (title,client,type,mode,complaintTime,ComplaintObject,content)values"+
                
                "('"+tbTitle.Text.Trim()+"','"+
                tbClient.Text.Trim()+ "','" +
                dtpComplaintTime.Text+ "','" +
                cbbObject+ "','" +
                tbContent.Text+ "')"  );
            MessageBox.Show("添加投诉成功！");
        }
    }
}
