using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._5_断点调试
{
    class Program
    {
        public static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = num; i > 0; i--)
                factorial *= i;
            return factorial;
        }
        static void Main(string[] args)
        {
            int i = 11;

            //for (;;) Console.WriteLine("死循环");     
            Console.WriteLine("断点调试"+(++i));
            Console.WriteLine(Factorial(i));//逐过程将此类语句也当成是一条普通语句,不会进入方法体内
            Console.WriteLine("断点调试" + (++i));
            Console.WriteLine("断点修改" + (++i));
            Console.WriteLine("断点调试" + (++i));
            Console.WriteLine("断点修改" + (++i));

            Console.WriteLine("断点调试" + (++i));
            Console.WriteLine("断点修改" + (++i));
            Console.WriteLine("断点调试" + (++i));
            Console.WriteLine("断点修改" + (++i));
            Console.WriteLine("断点调试" + (++i));
            Console.WriteLine("断点修改" + (++i));
            Console.WriteLine("断点调试" + (++i));
            Console.WriteLine("断点调试"+(++i));

            Console.ReadKey();
        }
    }
}
