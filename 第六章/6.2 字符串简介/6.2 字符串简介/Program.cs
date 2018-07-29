using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2_字符串简介
{
    class Program
    {
        static void Main(string[] args)
        {
            //string字符串，可以看成是一个没有上限的存储
            //char类型，它是一个0-2^16
            string mystr1 = "这是一句中文";
            string mystr2 = "1234567980";
            string mystr3 = "abcdefg";
            Console.WriteLine(mystr1);
            Console.WriteLine(mystr2);
            Console.WriteLine(mystr3);
            Console.ReadKey();
        }
    }
}
