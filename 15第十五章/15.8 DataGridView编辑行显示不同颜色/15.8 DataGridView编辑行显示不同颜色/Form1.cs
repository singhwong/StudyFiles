﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._8_DataGridView编辑行显示不同颜色
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

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= dataGridView1.Rows.Count - 1) return;
            Color oldForeColor = new Color();
            Color oldBackColor = new  Color();

            var row = dataGridView1.Rows[e.RowIndex];
            if (row == dataGridView1.CurrentRow)
            {
                if (row.DefaultCellStyle.ForeColor != Color.White)
                {
                    oldForeColor = row.DefaultCellStyle.ForeColor;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                if (row.DefaultCellStyle.BackColor != Color.Blue)
                {
                    oldBackColor = row.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.BackColor = Color.Blue;
                }

            }
            else
            {
                row.DefaultCellStyle.ForeColor = oldForeColor;
                row.DefaultCellStyle.BackColor = oldBackColor;
            }

        }
    }
}
