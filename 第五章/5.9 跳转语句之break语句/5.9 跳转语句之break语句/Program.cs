using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._9_跳转语句之break语句
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("输出1-500的数字，每行10个");
            for (int i = 1; i < 501; i++)
            {
                if ((i % 2 == 0) && (i % 3 == 0) && (i % 4 == 0) && (i % 5 == 0) && (i % 6 == 0) && (i % 7 == 0))
                {
                    Console.Write(i);
                    Console.WriteLine();
                    Console.WriteLine(i+"就是我们想要的那个数");
                    break;
                }

                if (i % 10 == 0) Console.WriteLine(i);
                else
                {

                    Console.Write(i+" ");
                    if (i < 10) Console.Write(" ");
                    if (i < 100) Console.Write(" ");
                }

            }
            Console.ReadLine();
        }
    }
}
