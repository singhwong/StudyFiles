using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8_构造函数与析构函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clerk zsClerk = new Clerk();
            //zsClerk.Name = "张三";
            //zsClerk.Gender = Gender.男;
            //zsClerk.Age = 25;
            //zsClerk.Department = "人力部";
            //zsClerk.Write();
            Clerk zsClerk = new Clerk("张三",Gender.男,25,"人力部");

            zsClerk.Write();

            Clerk lsClker = new Clerk("李四",Gender.女,30);
            lsClker.Write2();

        



            Console.ReadKey();


        }
    }
}
