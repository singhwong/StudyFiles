using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4_迭代语句之while语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //输出1-50到屏幕上
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //利用while可以大量简化重复执行的代码

            int num = 1;
            while (num <= 50)
            {
                Console.WriteLine(num);
                num++;

            }
            Console.ReadKey();
        }
    }
}
