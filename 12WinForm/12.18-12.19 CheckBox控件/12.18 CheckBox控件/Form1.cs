using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._18_CheckBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changebtn_Click(object sender, EventArgs e)
        {
            if (bcb.Checked)
            {
                if (icb.Checked)
                {
                    if (ucb.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font,FontStyle.Bold|FontStyle.Italic|FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
                    }
                }

                else
                {
                    if (ucb.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font,FontStyle.Bold);
                    }
                }
            }
            else
            {
                if (icb.Checked)
                {
                    if (ucb.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font,  FontStyle.Italic | FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
                    }
                }

                else
                {
                    if (ucb.Checked)
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
                    }
                    else
                    {
                        textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                    }
                }
            }
        }
    }
}
