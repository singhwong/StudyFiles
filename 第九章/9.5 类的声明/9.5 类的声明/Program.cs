using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5_类的声明
{
    class Program
    {

        static void Main(string[] args)
        {
            //将类实例化,就是将类指定给某个对象
            Clerk zsClerk = new Clerk();
            zsClerk._name = "张三";
            zsClerk._gender = Gender.男;
            zsClerk._age = 25;
            zsClerk._department = "人力部";
            zsClerk._workYears = 5;
            string mystr = "李四";
            //调用非静态的方法

            zsClerk.Write();
            //实例化
            Clerk lsClerk = new Clerk();
            lsClerk._name = "李四";
            lsClerk._gender = Gender.女;
            lsClerk._age = 35;
            lsClerk._department = "财务部";
            lsClerk._workYears = 3;
            mystr = "张三";
            lsClerk.Write();

            Console.WriteLine(zsClerk._name);
            Console.WriteLine(lsClerk._name);
            Console.WriteLine(mystr);
            Console.WriteLine(mystr);

            Console.ReadKey();




        }
    }
}
