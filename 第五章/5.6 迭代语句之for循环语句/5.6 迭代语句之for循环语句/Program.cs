using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6_迭代语句之for循环语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //求输入数的阶乘
            //1！＝1 2!=2×1 3！＝3×2×1
            //Console.WriteLine("请输入需要计算阶乘的数");
            //for(;;)
            //{ 
            //int a =int.Parse(Console.ReadLine());
            //int jc = 1;
            //for (int i=1;i<=a;i++)
            //{
            //    jc *= i;
            //}
            //Console.WriteLine("阶乘的结果是"+jc);
            Console.WriteLine("＝＝＝＝＝＝＝＝＝＝＝＝＝＝九九乘法表＝＝＝＝＝＝＝＝＝＝＝＝");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}×{1}＝{2} ", j, i, j * i);
                    if (i * j < 10) Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
         
        }
    }
}
