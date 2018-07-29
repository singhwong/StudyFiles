using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3分支语句之三元运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户进行输入
            Console.WriteLine("请输入您需要比较的数值");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num < 10 ? "您输入的数值小于10" : "您输入的数值大于等于10");
            Console.ReadKey();
        }
    }
}
