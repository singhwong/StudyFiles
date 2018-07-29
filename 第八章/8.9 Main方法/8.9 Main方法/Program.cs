using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._9_Main方法
{
    class Program
    {

        //Main方法有四种表现形式
        //(1)public static void Main()
        //(2)public static int Main()
        //(3)public static void Main(string [] args)
        //(4)public static int Main(string[] args)
        static void Main(string[] args)
        {
            //参看命令行参数数组长度
            Console.WriteLine("{0}个命令行参数被指定",args.Length);
            foreach (string outstr in args) Console.WriteLine(outstr);
            Console.ReadKey();
        }
    }
}
