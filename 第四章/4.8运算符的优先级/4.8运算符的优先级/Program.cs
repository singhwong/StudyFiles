using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8运算符的优先级
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 3;
            bool mybool = false;
            mybool = (var1 <= 4) && (var1 >= 2);
            Console.WriteLine(mybool);
            Console.ReadKey();
        }
    }
}
