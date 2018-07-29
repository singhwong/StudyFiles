using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._7_字符串的分割
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr = "51zxw-C#-Walker=6.7字符串的分割";
            Console.WriteLine("原字符串为"+mystr);
            //Console.WriteLine("用－分割后的字符串为：");
            //string[] changeMystr = mystr.Split('-');
            //foreach (string outstr in changeMystr) Console.Write(outstr+"\t");


            Console.WriteLine("用－和＝分割后的字符串为：");
            string[] changeMystr = mystr.Split(new char[] { '-','='});
            foreach (string outstr in changeMystr) 
			{			
			 Console.Write(outstr+"\t");
			}
            Console.ReadKey();
			//string[] splitstr = mystr.Split(new char[]{'-','='});
        }
    }
}
