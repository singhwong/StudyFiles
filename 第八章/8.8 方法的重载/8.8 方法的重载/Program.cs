using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._8_方法的重载
{
    class Program
    {

        //写在同一类中
        //求圆面积
        static void WriteArea(int radius)
        {
            double area = System.Math.PI * radius * radius;
            Console.WriteLine("您求圆的面积是:"+area);
        }

        //求矩形面积
        static void WriteArea(int width, int length)
        {
            int area = width * length;
            Console.WriteLine("您求的矩形的面积是:"+area);
        }

        //求三角形面积
        static void WriteArea(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double area = System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("您求的三角形的面积是:"+area);

        }
        static void Main(string[] args)
        {
            //利用方法的重载进行调用方法
            WriteArea(3,4,5);
            WriteArea(25);
            WriteArea(10, 20);
            Console.ReadKey();

        }
    }
}
