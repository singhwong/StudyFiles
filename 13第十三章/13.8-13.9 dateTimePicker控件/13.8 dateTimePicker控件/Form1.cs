using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._8_dateTimePicker控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            string tg = "甲乙丙丁戊己庚辛壬癸";
            string dz = "子丑寅卯辰巳午未申酉戌亥";
            string sx = "鼠牛虎兔龙蛇马羊猴鸡狗猪";
            int year = dateTimePicker1.Value.Year;
            label1.Text = "您选择的年为:农历" + tg[(year - 4) % 10] + dz[(year - 4) % 12] + "年,是" + sx[(year - 4) % 12] + "年";
        }
    }
}
