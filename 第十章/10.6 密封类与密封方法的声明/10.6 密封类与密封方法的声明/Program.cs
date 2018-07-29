using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6_密封类与密封方法的声明
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 myclass2 = new Class2();
            myclass2.Write();

            Class3 myclass3 = new Class3();
            myclass3.NewWirte();
            Console.ReadKey();
        }
    }
}
