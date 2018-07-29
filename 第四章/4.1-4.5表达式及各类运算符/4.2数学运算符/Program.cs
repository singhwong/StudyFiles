using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 3;
            //int c = a %b;
            //int d = +a;
            //int e = -a;
            ////double    d = 5.0;
            ////double e = 3.0;
            ////double f = d/ e;
            //Console.WriteLine("d的值是{0},e的值是{1}",d,e);

            int var1 = 10;
            int var2;
            var2 = var1++;//var2=10,var1=11
            Console.WriteLine(var1);
            Console.WriteLine(var2);


            var2 = ++var1;//var1=12 var2=12
            Console.WriteLine(var1);
            Console.WriteLine(var2);



            Console.ReadKey();            
        }
    }
}
