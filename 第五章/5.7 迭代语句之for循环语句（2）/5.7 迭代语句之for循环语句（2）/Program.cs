using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7_迭代语句之for循环语句_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================九九乘法表=====================");
            //使用for循环时，一般在for循环语句进行声明循环计次的变量
            for (int i = 1; i < 10; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}×{1}＝{2} ",j,i,j*i);
                    if (i * j < 10) Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
