using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._15_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //类型转换
            //隐式转换
            // char mychar = 'a';
            //int myint = 10;



            //Console.WriteLine(mychar);
            //Console.WriteLine(myint);

            ////myint = mychar;
            ////Console.WriteLine(myint);

            //mychar = checked((char)myint);
            //Console.WriteLine(mychar);
            int myint = 100;
            string mystr = "456";

            //myint = Convert.ToInt32(mystr);
            //mystr = Convert.ToString(myint);
            //mystr = myint.ToString();
            myint = int.Parse(mystr);
            Console.WriteLine(myint);









            Console.ReadKey();
        }
    }
}
