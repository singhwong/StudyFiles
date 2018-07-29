using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6_字符串的截取
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mystr = "walker";
            //string mystr0 = mystr.Substring(2,2);
            //Console.WriteLine(mystr0);
            Console.WriteLine("请输入一个单词，不区分大小写");
            string mystr = Console.ReadLine();
            string firstCapital = mystr.Substring(0, 1).ToUpper();
            string otherCpaital = mystr.Substring(1).ToLower();
            Console.WriteLine("单词首字母大写"+firstCapital+otherCpaital);
            Console.ReadKey();
        }
    }
}
