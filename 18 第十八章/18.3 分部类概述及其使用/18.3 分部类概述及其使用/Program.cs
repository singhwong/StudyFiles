using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._3_分部类概述及其使用
{

    partial class arithmetic//阶乘
    {
        public int factorial(int num)
        {
            int factorial = 1;
            for (int i = num; i > 0; i--)
                factorial *= i;
            return factorial;
        }

    }

    partial class arithmetic //平方
    {
        public int square(int num)
        {
            return num * num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            arithmetic a = new arithmetic();
            int num = 5;
            Console.WriteLine("调用分部类的第一部分：{0}",a.factorial(num));
            Console.WriteLine("调用分部类的第二部分：{0}",a.square(num));
            Console.ReadKey();

        }
    }
}
