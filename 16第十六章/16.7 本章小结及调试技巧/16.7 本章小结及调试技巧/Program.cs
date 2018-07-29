using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._7_本章小结及调试技巧
{
    class Program
    {
        public static int sum(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {

            int a = 10;
            int[] myint = {1,2,3,4,5,6,78,9,8,2,5,545,52,54,87 };
            for (int i = 1; i < 5; i++)
                Console.WriteLine(a*i);
            foreach (int outint in myint)
                Console.WriteLine(outint);
            sum(a,myint[5]);
            myint[5] = 11000;
            sum(a, myint[5]);
            Console.ReadKey();
        }
    }
}
