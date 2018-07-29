using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person myperson = new Person();
            myperson.Name = "老白";
            myperson.Age = 213;
            myperson.Gender = '中';
            myperson.CHLSS();
            Console.WriteLine() ;
            Console.ReadKey();
        }
    }
}
