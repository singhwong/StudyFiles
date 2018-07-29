using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2常量
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 5;
            const double pi=3.14;
            Console.WriteLine("此圆的周长是"+2*pi*r);
            Console.WriteLine("此圆的面积是"+pi*pi*r);//输出一行，并下移光标

            Console.Write(@"是个什么东西\n");//只输出，不下移光标 转义字符\n
            Console.Write("光标在哪里");

            string strSQL = @"SELECT * FROM HumanResources.Employee AS e
 INNER JOIN Person.Contact AS c
  ON e.ContactID = c.ContactID
  ORDER BY c.LastName";



            Console.ReadKey();
        }
    }
}
