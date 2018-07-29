using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._12_字符串的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#当中复制字符串是通过Copy和CopyTo来实现的
            //Copy  静态方法:string.方法来进行引用
            string mystr = "http://www.51zxw.net";
            string copyMystr = string.Copy(mystr);
            Console.WriteLine(copyMystr);
            //CopyTo 非静态方法
            char[] mycharArray = new char[20];

            mystr.CopyTo(7,mycharArray,0,13);
            Console.WriteLine("CopyTo实现复制的结果是:");
            Console.WriteLine(mycharArray);
            Console.ReadKey();
        }
    }
}
