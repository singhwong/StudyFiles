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
    public partial class cbbServiceMode : Form
    {
        public cbbServiceMode()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        database db = new database();

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectClient sc = new SelectClient();
            DialogResult result = sc.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbServiceClient.Text = sc.Person;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbServiceTitle.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入投诉的标题！");
                tbServiceTitle.Focus();
                return;
            }
            if (tbServiceClient.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请点击右侧按钮进行选择客户！");
                btnSelect.Focus();
                return;
            }
            if (tbServiceContent.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入服务内容");
                tbServiceContent.Focus();
                return;
            }
            db.runSql("insert into services(title,userName,serviceType,serviceMode,StartTime,EndTime,ServiceConten,feedback,note,result)values"+"('" 
                + tbServiceTitle.Text.Trim() + "','" + tbServiceClient.Text.Trim() + "','" 
                + cbbServiceType.Text + "','" + cbbServicesMode.Text + "','" + dtpStartTime.Text 
                + "','" + dtpEndTime.Text + "','" + tbServiceContent.Text + "','" 
                + cbbServiceFeedback.Text + "','" + tbServiceNote.Text + "','" + cbbResult.Text + "')");
            MessageBox.Show("添加成功！");
        }
    }
}
