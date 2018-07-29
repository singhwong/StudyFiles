using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._13_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            Console.WriteLine("请输入三个整数，我们将给您算出中间数和它的阶乘");
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int middleNum = 0;
            //a是中间值，那么有两种情况，b是最小值或都b是最大值
            //b
            //c
            if (a >= b && a <= c || a >= c && a <= b)
            {
                Console.WriteLine(a + "是中间值");
                middleNum = a;

            }
            if (b >= a && b <= c || b >= c && b <= a)
            {
                Console.WriteLine(b + "是中间值");
                middleNum = b;
            }
            if (c >= a && c <= b || c >= b && c <= a)
            {
                Console.WriteLine(c + "是中间值");
                middleNum = c;
            }

            int result = 1;
            for (int i = 1; i <= middleNum; i++)
            {
                result *= i;
            }
            Console.WriteLine("它的阶乘是" + result);
        }

            Console.ReadKey();



        }
    }
}
