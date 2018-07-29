using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _25._5删除注册表信息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey sys = hklm.OpenSubKey("System", true);
            foreach (string site in sys.GetSubKeyNames())
            {
                if (site == "51zxw")
                {
                    try { sys.DeleteSubKeyTree(site); }
                    catch (Exception ex) { MessageBox.Show(ex.ToString());}
                    
                    MessageBox.Show("删除成功");
                }
            }
        }
    }
}
