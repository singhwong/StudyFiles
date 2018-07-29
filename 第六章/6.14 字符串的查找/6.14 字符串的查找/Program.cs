using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._14_字符串的查找
{
    class Program
    {
        static void Main(string[] args)
        {
            //IndexOf方法
            //string mystr = "12351zxw45651zxw";
            ////              0123456789ABCDEF
            //int myReturnVal1 = mystr.IndexOf("51zxw");
            //int myReturnVal2 = mystr.LastIndexOf("51zxw");

            //Console.WriteLine(myReturnVal1);
            //Console.WriteLine(myReturnVal2);

            Console.WriteLine("请您输入一个字符串,我们来判断是否包含51zxw及它出现第一次和最后一次的位置");
            string mystr = Console.ReadLine();
            int myReturnVal1 = mystr.IndexOf("51zxw");
            int myReturnVal2 = mystr.LastIndexOf("51zxw");
            if (myReturnVal1 < 0) Console.WriteLine("您输入的字符串不包含51zxw");
            else
            {
                Console.WriteLine("您输入的字符串包含51zxw,它第一次出现的位置是第{0}位,最后一次出现的位置是第{1}位", myReturnVal1+1,myReturnVal2+1);

            }
            Console.ReadKey();
        }
    }
}
