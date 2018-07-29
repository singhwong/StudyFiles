using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_捕获异常
{
    class Program
    {
        static void Main(string[] args)
        {

            //利用try catch语句来捕获数组的越界问题

            int[] myint = { 0,2,4,6,8,10,12,16,18,20};
            try
            {
                for (int i = 0; i <= myint.Length; i++)
                    Console.Write(myint[i].ToString() + " ");
            }


            //此条 语句虽然可以捕获异常,并给出提示,但并不能很智能的描述异常的原因.
            //catch
            //{
            //    Console.WriteLine("异常已经发生");

            //}

            catch (Exception myex)
            {
                Console.WriteLine(myex.Message.ToString());
            }


           
            Console.ReadKey();
        }
    }
}
