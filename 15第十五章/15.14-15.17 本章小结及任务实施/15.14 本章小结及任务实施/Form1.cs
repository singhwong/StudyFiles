using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._14_本章小结及任务实施
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int valTotalNum =100;//总条数
        DataTable dt;
        int valPerPage = 20;//每页条 数
        int pageNum = 0;//页数
        int pageCurrent =1;//当前页序号
        int valCurrent = 0;//当前条数
        int valStartIndex = 0;//当前页起始条数
        int valEndIndex = 0;//当前页终止的条数

        private void dtGenerate()
        {
            dt = new DataTable("ClerkSalary");
            dt.Columns.Add("姓名", Type.GetType("System.String"));
            dt.Columns.Add("性别", Type.GetType("System.String"));
            dt.Columns.Add("工资", Type.GetType("System.Int32"));
            string familyName = "赵钱孙李周吴郑王冯陈楮卫蒋沈韩杨朱秦尤许何吕施张孔曹严华金魏陶姜";
            string LastName =@"嘉哲俊博妍乐佳涵晨宇怡泽子凡悦思奕依浩泓彤冰媛凯伊淇淳洁茹清吉源渊
和函妤宜云琪菱宣沂健信欣可洋萍荣榕含佑明雄梅芝英义淑卿乾亦芬萱昊芸天岚昕尧鸿棋琳孜娟宸林乔琦丞安毅
凌泉坤晴竹娴婕恒渝菁龄弘佩勋宁元栋盈江卓春晋逸沅倩昱绮海圣承民智棠容羚峰钰涓新莉恩羽妮旭维家泰诗谚
阳彬书苓汉蔚坚茵耘喆国仑良裕融致富德易虹纲筠奇平蓓真之凰桦玫利强村沛汶锋彦延庭霞冠益劭钧薇亭瀚桓东
滢恬瑾达群国茜先洲溢楠基轩月美心茗丹森学文";
            string gender = "男女";
            Random rd = new Random();
            for (int i = 0; i < valTotalNum; i++)
            {
                
                string name = familyName[rd.Next(0, familyName.Length)].ToString() + LastName[rd.Next(0, LastName.Length)].ToString() + LastName[rd.Next(0, LastName.Length)].ToString();
                string Gender = gender[rd.Next(0, gender.Length)].ToString();
                int salary = rd.Next(1800,10000);
                dt.Rows.Add(new object[] { name,Gender,salary});

                //DataRow dr = dt.NewRow();
                //dr[0] = familyName[rd.Next(0, familyName.Length)].ToString() + LastName[rd.Next(0, LastName.Length)].ToString() + LastName[rd.Next(0, LastName.Length)].ToString();
                //dr[1] = gender[rd.Next(0, gender.Length)].ToString();
                //dr[2] = rd.Next(1800, 10000);
                //dt.Rows.Add(dr);
            }

        }//生成源数据表
        private void loadData()
        {
            DataTable dtTemp = dt.Clone();
            if (pageCurrent == pageNum) valEndIndex = valTotalNum - 1;//只有一页
            else valEndIndex = pageCurrent * valPerPage - 1;//不止一页
            valStartIndex = valCurrent;
            toolStripTextBox1.Text = pageCurrent.ToString();
            toolStripLabel1.Text = "/" + Convert.ToString(pageNum);
            //从源数据表中读取当前的数据
            for (int i = valStartIndex; i <= valEndIndex; i++)
            {
                dtTemp.ImportRow(dt.Rows[i]);
                valCurrent++;
            }
            bindingSource1.DataSource = dtTemp;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Pink;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Violet;

        }//加载当前页数据
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dtGenerate();
                pageNum = (valTotalNum % valPerPage == 0) ? (valTotalNum / valPerPage) : (1 + valTotalNum / valPerPage);
                loadData();
               

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle myrec = new Rectangle(e.RowBounds.Location.X,e.RowBounds.Location.Y,dataGridView1.RowHeadersWidth,e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1 + valStartIndex).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, myrec, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
            if (e.RowIndex >= dataGridView1.Rows.Count - 1) return;
            var row = dataGridView1.Rows[e.RowIndex];
            Color oldForeColor = new Color();
            Color oldBackColor = new Color();
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

        private void bindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "上一页")
            {
                pageCurrent--;
                if (pageCurrent <= 0)
                {
                    MessageBox.Show("已经是第一页");
                    pageCurrent++;
                    return;
                }
                else
                {
                    valCurrent = valPerPage * (pageCurrent-1);
                }
                loadData();
            }
            if (e.ClickedItem.Text == "下一页")
            {
                pageCurrent++;
                if (pageCurrent > pageNum)
                {
                    pageCurrent--;
                    MessageBox.Show("已经是最后一页");
                    return;
                }
                else
                {
                    valCurrent = valPerPage * (pageCurrent-1);
                }
                loadData();
            }


        
        }
    }
}
