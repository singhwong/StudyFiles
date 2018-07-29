using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10_字符串的删除_移除_
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过Remove方法来实现字符串的移除

            //第一种方法 从指定位置开始移除后边的字符串
            string mystr = "www.51zxw.net//12345\\5464";
            string changeMystr = mystr.Remove(13);
            Console.WriteLine("用一个参数实现Remove的结果");
            Console.WriteLine(changeMystr);
            //第二种方法 从指定位置开始移除指定位数的字符串
            string mystr2 = "www.51zxw.com.net";
            string changeMystr2 = mystr2.Remove(9,4);
            Console.WriteLine("用两个参数实现Remove的结果");
            Console.WriteLine(changeMystr2);
            Console.ReadKey();

        }
    }
}
