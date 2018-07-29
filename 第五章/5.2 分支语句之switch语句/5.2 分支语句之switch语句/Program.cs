using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_分支语句之switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入1显示星期一，依次类推
            Console.WriteLine("请输入月分数");
            int month = int.Parse(Console.ReadLine());
            //if (week == 1) Console.WriteLine("星期一");
            //if (week == 2) Console.WriteLine("星期二");
            //if (week == 3) Console.WriteLine("星期三");
            //if (week == 4) Console.WriteLine("星期四");
            //if (week == 5) Console.WriteLine("星期五");
            //if (week == 6) Console.WriteLine("星期六");
            //if (week == 7) Console.WriteLine("星期日");

            //switch (week)
            //{
            //    case 1: Console.WriteLine("星期一"); break;
            //    case 2: Console.WriteLine("星期二"); break;
            //    case 3: Console.WriteLine("星期三"); break;
            //    case 4: Console.WriteLine("星期四"); break;
            //    case 5: Console.WriteLine("星期五"); break;
            //    case 6: Console.WriteLine("星期六"); break;
            //    case 7: Console.WriteLine("星期日"); break;
            //    default: Console.WriteLine("您的输入有误"); break;



            //}

            //判断2015年每个月份的天数
            //31天：1、3、5、7、8、10、12
            //30天：4、6、9、11
            //28天：2

            switch(month)
{
                case 2: Console.WriteLine("本月有28天");break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("本月有30天");break;
                default: Console.WriteLine("本月有31天");break;

            }


            Console.ReadLine();

        }
    }
}
