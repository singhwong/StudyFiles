using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._6_自定义异常类
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("这行代码在引发异常前被执行");
                string mystr = "我是我自己定义的异常,由我要自学网制作";
                throw new MyException(mystr);
                Console.WriteLine("由于引发了异常,这行代码不会被执行");
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message.ToString());
               // Console.WriteLine("我是我自己定义的异常,由我要自学网制作");

            }
            Console.ReadKey();
        }
    }
}
