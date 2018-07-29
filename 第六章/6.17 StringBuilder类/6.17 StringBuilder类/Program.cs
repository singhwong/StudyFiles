using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;//引入命名空间
using System.Threading.Tasks;

namespace _6._17_StringBuilder类
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder mystringBuilder = new StringBuilder("http://www.51zxw.net");
            Console.WriteLine("=================Append===================");
            //追加对应的字符串
            Console.WriteLine(mystringBuilder.Append("是一个神奇的网站"));
            Console.WriteLine("==================Insert===================");
            //在对应位置插入指定的字符串
            Console.WriteLine(mystringBuilder.Insert(20,"\n"));
            Console.WriteLine("======================Remove==============");
            //移除从索引开始位置的N个字符
            Console.WriteLine(mystringBuilder.Remove(20,1));
            Console.WriteLine("====================Replace===============");
            Console.WriteLine(mystringBuilder.Replace("神奇","强大"));
            Console.WriteLine("======================AppendFormat=======");
            //按照指定的格式来添加对应的字符串
            int saveMoney = 2000;
            Console.WriteLine(mystringBuilder.AppendFormat("并且为我省了{0:C}",saveMoney));
            Console.WriteLine("=========================AppendLine=======");
            Console.WriteLine(mystringBuilder.AppendLine("这句话会自动换行"));

            Console.ReadKey();

        }
    }
}
