using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._21ComboBox_ListBox_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] mystr = { "语文","数学","英语","物理","化学","生物"};
            for (int i = 0; i < mystr.Length; i++)
            {
                comboBox1.Items.Add(mystr[i]);
                listBox1.Items.Add(mystr[i]);
                checkedListBox1.Items.Add(mystr[i]);

            }
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";


        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label6.Text = comboBox1.SelectedItem.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = listBox1.SelectedItem.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = checkedListBox1.SelectedItem.ToString();
            label9.Text = "";
            foreach (string outstr in checkedListBox1.CheckedItems)
            {
                label9.Text += outstr + " ";            }

        }
    }
}
