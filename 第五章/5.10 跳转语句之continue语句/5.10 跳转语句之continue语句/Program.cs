using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._10_跳转语句之continue语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("50以内的奇数有：");
            for (int i = 1; i < 51; i++)
            {
                if (i % 2 == 0) continue;
                //continue语句用于停止本次迭代，并非跳出迭代语句
                Console.Write(i+"\t");
            }
            Console.ReadLine();

        }
    }
}
