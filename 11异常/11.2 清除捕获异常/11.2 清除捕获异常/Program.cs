using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2_清除捕获异常
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myint = { 0,2,4,6,8,10,12,14,16,18,20};

            try
            {
                for (int i = 0; i < myint.Length; i++)
                {

                    Console.WriteLine("720÷{0}={1}", myint[i], 720 / myint[i]);

                }
            }
            catch (SystemException myex)
            {
                Console.WriteLine(myex.Message.ToString());
                Console.WriteLine(myex.InnerException);
            }
            finally
            {
                Console.WriteLine("我什么时候都会执行,无论发生异常与否");
            }


          
            Console.ReadKey();
        }
    }
}
