using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_预定义异常类_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool mybool = true;
            //try
            //{
            //    char mychar = Convert.ToChar(mybool);
            //    Console.WriteLine(mychar);
            //}
            //catch(InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message.ToString());
            //}

            //string[] mystr = { "Cat","Dog","Pig"};
            //object[] myobj = mystr;
            //try
            //{
            //    foreach (object outobj in myobj)
            //    {
            //        Console.WriteLine(outobj);
            //        Console.WriteLine(outobj.GetType());
            //        myobj[2] = 13;
            //    }
            //}
            //catch (ArrayTypeMismatchException ex)
            //{
            //    Console.WriteLine(ex.Message.ToString());
            //}
            
            try
            {
                //int num = 10;
                //Console.WriteLine(num/0);
                byte mybyte = Convert.ToByte(Console.ReadLine());
                Console.WriteLine(mybyte);
            }

            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
           
            Console.ReadKey();
        }
    }
}
