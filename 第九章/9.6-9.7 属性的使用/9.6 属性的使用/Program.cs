using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6_属性的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //将类实例化,并分别赋值,并调用其中的方法
            Clerk zsClerk = new Clerk();
            zsClerk.Name = "张三";
            zsClerk.Gender = '中';
            zsClerk.Age = -25;
            zsClerk.Department = "人力部";
            zsClerk.Workyears = 5;
            zsClerk.Write();
            Console.ReadKey();
        }
    }
}
