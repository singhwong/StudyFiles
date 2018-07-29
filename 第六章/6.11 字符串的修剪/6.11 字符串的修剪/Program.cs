using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._11_字符串的修剪
{
    class Program
    {
        static void Main(string[] args)
        {

            //字符串的修剪通过Trim()来实现
            string userName = "    walker     ";
            Console.WriteLine("原字符串是:"+userName+"|");
            Console.WriteLine("把空格修剪后是:"+userName.Trim()+"|");
            //修剪开始用TrimStart()
            Console.WriteLine("修剪开始空格后是:"+userName.TrimStart()+"|");

            //修剪结尾用TrimEnd()
            Console.WriteLine("修剪结尾空格后是:" + userName.TrimEnd() + "|");
            //将"#%%##%#http://www.51zxw.net#%"修剪为"http://www.51zxw.net"
            string mywebsite = "#%%##%#http://www.51zxw.net#%";
            Console.WriteLine("修剪其他字符的方法1:"+mywebsite.Trim('#','%'));
            Console.WriteLine("修剪其他字符的方法2:" + mywebsite.Trim("#%".ToCharArray()));

            Console.ReadKey();
        }
    }
}
