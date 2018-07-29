using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._13_字符串的替换
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串的替换
            //C#中实现的方法是 非静态方法Replace
       
            string mystr = "http://www.51zxw.net";
            Console.WriteLine("替换前字符串为:"+mystr);
            Console.WriteLine("C#利用Replace进行替换的结果"+mystr.Replace('w', 'W'));
            Console.ReadKey();
        }
    }
}
