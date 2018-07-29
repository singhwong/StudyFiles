﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._4_DataGridView隐藏行列
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“csharpzxwDataSet.mytable001”中。您可以根据需要移动或删除它。
            this.mytable001TableAdapter.Fill(this.csharpzxwDataSet.mytable001);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mystr = button1.Text;
            if (mystr == "隐藏部门列")
            {
                dataGridView1.Columns[4].Visible = false;
                mystr = "显示部门列";
            }
            else
            {
                dataGridView1.Columns[4].Visible = true;
                mystr = "隐藏部门列";

            }

            button1.Text = mystr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mystr = button2.Text;
            if (mystr == "隐藏雪上行者行")
            {
                dataGridView1.Rows[6].Visible = false;
                mystr = "显示雪上行者行";
            }
            else
            {
                dataGridView1.Rows[6].Visible = true;
                mystr = "隐藏雪上行者行";
            }
            button2.Text = mystr;
       
        }
    }
}
