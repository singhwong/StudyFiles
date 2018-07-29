using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_字符串的比较
{
    class Program
    {
        static void Main(string[] args)
        {

            //==  !=

            //Equals
            string mystr1 = "Hello";
            string mystr2 = "HELLO";
            Console.WriteLine(string.Equals(mystr1,mystr2));

            Console.WriteLine(string.Compare(mystr1,mystr2,true));
            Console.WriteLine(mystr1.CompareTo(mystr2));
            Console.ReadKey();
        }
    }
}
