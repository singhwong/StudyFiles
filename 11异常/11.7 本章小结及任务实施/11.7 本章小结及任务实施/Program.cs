using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._7_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数:");
            try
            {
                int myint = int.Parse(Console.ReadLine());
                double mydouble = 1.0 / myint;
                Console.WriteLine("该数的倒数是:" + mydouble);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("产生除零异常");
            }
            catch (OverflowException)
            {
                Console.WriteLine("溢出异常");
            }

            catch (FormatException)
            {
                Console.WriteLine("转换异常");
            }
            catch (Exception)
            {
                Console.WriteLine("其他异常");
            }

            Console.ReadKey();
        }
    }
}
