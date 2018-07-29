using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._11_跳转语句之return语句
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

            
            Console.WriteLine("请输入三个整数，按回车键确认每个数的输入：");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
                average(a,b,c);
                //double average = (a+b+c)/3;
                //double Average = average(a,b,c);
            //Console.ReadLine();
}
        }

        static void  average(int a, int b, int c)
        {
            Console.WriteLine("您输入三个整数的平均值是：{0}", (a + b + c) / 3);

            return ;
        }      
    }
}
