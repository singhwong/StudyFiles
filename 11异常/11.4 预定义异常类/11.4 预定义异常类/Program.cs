using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._4_预定义异常类
{
    class Program
    {
        static int DivideByTwo(int num)
        {
            if (num % 2 == 1) throw new ArgumentException("此处必须为偶数","num");
                return num / 2;

        }
        static void Main(string[] args)
        {
            //int[] myint = {1,2,3,4,5,6,7,8,9,0 };
            //try
            //{
            //    for (int i = 0; i < 11; i++) Console.WriteLine(myint[i]);

            //}
            //catch (IndexOutOfRangeException exIOR)
            //{
            //    Console.WriteLine(exIOR.Message.ToString());
            //}

            //string mystr = null;
            //try
            //{
            //    Console.WriteLine(mystr.ToString());

            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message.ToString());
            //}
            try
            {
                Console.WriteLine(DivideByTwo(9));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.ReadKey();
        }
    }
}
