using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._5_ListView控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] myCountry = { { "China","中国","北京"}, { "Korea","韩国","首尔"} , { "Canada","加拿大","渥太华"}, { "America", "美国", "纽约" }, { "Japan", "日本", "东京" }, { "Singnapore", "新加坡", "新加坡" }, { "UK", "英国", "伦敦" }, { "Vietnam", "越南", "河内" } };
            for (int i = 0; i < myCountry.Length/3; i++)
            {
                ListViewItem mylvi = listView1.Items.Add(i.ToString());
                mylvi.ImageIndex = i;
                mylvi.SubItems.Add(myCountry[i,0]);
                mylvi.SubItems.Add(myCountry[i, 1]);
                mylvi.SubItems.Add(myCountry[i, 2]);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "LargeIcon") listView1.View = View.LargeIcon;
            if (comboBox1.SelectedItem.ToString() == "SmallIcon") listView1.View = View.SmallIcon;
            if (comboBox1.SelectedItem.ToString() == "List") listView1.View = View.List;
            if (comboBox1.SelectedItem.ToString() == "Details") listView1.View = View.Details;
            if (comboBox1.SelectedItem.ToString() == "Tile") listView1.View = View.Tile;

        }
    }
}
