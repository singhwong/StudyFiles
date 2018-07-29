using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._7_其他运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str1 = "我的名字叫";
            //string str2 = "雪上行者";
            //string str3 = str1 + str2;
            //Console.WriteLine(str3);
            //Console.WriteLine("我是用于输出到屏幕" + "这个是利用加号进行连接的");
            // Console.ReadKey();

            //int a = 10;
            //double b = 3.14;
            //string c = "我要自学网";
            //bool mybool = false;
            //mybool = a is int;
            //Console.WriteLine("a is int\t"+mybool);
            //mybool = b is double;
            //Console.WriteLine("b is double\t"+mybool);
            //mybool = c is string;
            //Console.WriteLine("c is string\t"+mybool);
            //Console.ReadKey();
            //// \t跳到下一个制表位

            //输出语句“I have 数量 pen”


            //Console.WriteLine("请输入您拥有的钢笔数量");
            //int qty = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("I have {0} pen{1}",qty,qty>1?"s":"");

            //判定用户输入的数字与5的关系

            Console.WriteLine("请您输入需要比较的数");
            int num = Convert.ToInt32(Console.ReadLine());
            string str=num>=5?"大于等于":"小于";
            Console.WriteLine("您输入的数字{0}5",str);

            Console.ReadLine();
        }
    }
}
