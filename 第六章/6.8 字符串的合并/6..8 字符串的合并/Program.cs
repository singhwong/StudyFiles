using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._._8_字符串的合并
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串的合并");
            string mystr1 = "51zxw";
            string mystr2 = "C#";
            string mystr3 = "Walker";
            string changeMystr = mystr1 + mystr2 + mystr3;
            Console.WriteLine("第一种方法(+)");
            Console.WriteLine(changeMystr);
            Console.WriteLine("第二种方法(Concat)");
            string changeMystr2 = string.Concat(mystr1,mystr2,mystr3);
            Console.WriteLine(changeMystr2);
            Console.WriteLine("第三种方法");
            string[] mystrArray = { "51zxw","C#","walker"};
            string changeMystr3 = string.Join("***", mystrArray);
            Console.WriteLine(changeMystr3);
            Console.ReadKey();
        }
    }
}
