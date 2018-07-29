using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _18._2_创建迭代器最常用的方法
{
    class Program
    {
        //public static IEnumerable SimpleDemo()
        //{
        //    yield return "string1";
        //    yield return "string2";
        //    yield return "string3";
        //    yield break;
        //    yield return "string4";
        //    yield return "string5";


        //}
        public class Months : IEnumerable
        {
            string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < month.Length; i++)
                {
                    yield return month[i];
                }
            }
        }


        static void Main(string[] args)
        {
            //foreach (string item in SimpleDemo())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            Months mon = new Months();
            foreach (string m in mon)
            {
                Console.WriteLine(m);
            }
            Console.ReadKey();

        }
    }
}
