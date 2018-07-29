using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._27_GroupBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string mystr = "";
            foreach (Control outctrl in groupBox1.Controls)
                if (outctrl is RadioButton)
                    if (((RadioButton)outctrl).Checked)
                        mystr = "您的种族是:" + outctrl.Text;
            foreach (Control outctrl in groupBox2.Controls)
                if (outctrl is RadioButton)
                    if (((RadioButton)outctrl).Checked)
                        mystr += "\n你的所属是:" + outctrl.Text;

            MessageBox.Show(mystr,"选择结果");
        }
    }
}
