using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._9_字符串的插入与填充
{
    class Program
    {
        static void Main(string[] args)
        {

            //字符串的插入
            string mystr = "www.51zx.net";
            string insertMystr = mystr.Insert(8,"w");
            Console.WriteLine("字符串的插入");
            Console.WriteLine(insertMystr);
            //PadRight用来在字符串的结尾处添加指定(重复)字符以达到指定的总长度,总长度直接用数字来指定
            string padStr = "abc";
            string padStr2 = "abcd";
            string padStr3 = "efghi";
            string padRightStr = padStr.PadRight(6, '/')+"\n"+padStr2.PadRight(6,'/')+"\n"+padStr3.PadRight(6,'/');
            Console.WriteLine("字符串结尾处填充");
            Console.WriteLine(padRightStr);
            //PadLeft用来在字符串的开头处添加指定的字符以达到我们指定的总长度
            string padLeftStr = padStr.PadLeft(6) + "\n" + padStr2.PadLeft(6) + "\n" + padStr3.PadLeft(6);
            Console.WriteLine("字符串开始位置填充");
            Console.WriteLine(padLeftStr);
            

            Console.ReadKey();
        }
    }
}
