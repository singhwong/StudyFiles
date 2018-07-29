using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._10_本章小结及任务实施
{
    class Program
    {


        //乘法表方法的实现
        static void Multiple(int num)
        {
            Console.WriteLine("{0}的乘法表是:",num);
            for (int i = 1; i <= num; i++)
            {
                if (num % i != 0) continue;
                else
                {
                    Console.WriteLine("{0,2}×{1,2}={2,2}",i,num/i,num);

                }

            }

        }

        //加法表的实现
        static void Add(int num)
        {
            Console.WriteLine("{0}的加法表是:",num);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("{0,2}+{1,2}={2,2}",i,num-i,num);

            }


        }
        static void Main(string[] args)
        {
            //实现用户输入数字的加法表与乘法的输出
            //12
            //0+12=12 1+11=12   1*12=12 2*6=12 3*4=12
            Console.WriteLine("请输入一个数字:");
            int num = Convert.ToInt32(Console.ReadLine());
            Multiple(num);
            Console.WriteLine();
            Add(num);
            Console.ReadKey();

        }
    }
}
