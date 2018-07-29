using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10, var2 = 7;
            var1 += var2;
            Console.WriteLine("var1 = 10, var2 = 7,那么var1+=var2的值是{0}", var1);
            var1 = 10;
            var2 = 7;
            var1 -= var2;
            Console.WriteLine("var1 = 10, var2 = 7,那么var1-=var2的值是" + var1);
            var1 = 10;
            var2 = 7;
            var1 *= var2;
            Console.WriteLine("var1 = 10, var2 = 7,那么var1*=var2的值是" + var1);
            var1 = 10;
            var2 = 7;
            var1 /= var2;
            Console.WriteLine("var1 = 10, var2 = 7,那么var1/=var2的值是" + var1);
            var1 = 10;
            var2 = 7;
            var1 %= var2;
            Console.WriteLine("var1 = 10, var2 = 7,那么var1%=var2的值是" + var1);



            Console.ReadKey();

        }
    }
}
