using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 5;
            //int c = a + b;
            //Console.WriteLine(c);
            //Console.ReadKey();

            Console.WriteLine("请输入您的语文成绩");
            double Chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入您的数学成绩");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("您的总分是{0}分，您的平均分是{1}分",math+Chinese,(math+Chinese)/2);
            Console.ReadKey();
        }
    }
}
