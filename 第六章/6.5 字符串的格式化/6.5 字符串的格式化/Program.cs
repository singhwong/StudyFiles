using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5_字符串的格式化
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("{0:C}",21.3);
            //Console.WriteLine("字符串的格式化输出");
            //string s = string.Format("默认格式：－－－－－{0}\n"+"使用C格式：{0:C}\n"+"使用D格式：{0:D}\n"+"使用E格式：{1:E}\n"+"使用F格式:{1:F}\n"+"使用G格式：{0:G}\n"+ "使用N格式：{0:N}\n" + "使用P格式：{0:P1}\n" + "使用X格式：{0:X}\n",2100,2100.33);
            //Console.WriteLine(s);
            for (int i = 001; i < 051; i++)
            {

                string mystr = string.Format("{0:D3}",i);
               Console.WriteLine(mystr);
            }
            Console.ReadKey();
        }
    }
}
