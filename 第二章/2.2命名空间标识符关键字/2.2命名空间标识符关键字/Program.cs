using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using @class = System.Console;

namespace _2._2命名空间标识符关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("这是一条 输出语句");

            @class.WriteLine("这是一条别名输出语句");
            Console.ReadKey();
        }
    }
}
