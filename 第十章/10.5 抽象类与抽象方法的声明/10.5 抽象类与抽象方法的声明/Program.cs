using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5_抽象类与抽象方法的声明
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 myclass = new Class1();
            PowB myPowB = new PowB();
            myPowB.PowMethod(2,10);
            PowC myPowC = new PowC();
            myPowC.PowMethod(2,10);
            Console.ReadKey();
        }


    }
}
