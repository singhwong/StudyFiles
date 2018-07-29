using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._16_类型转换_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double mydouble = 5.5;
            int myint = 100;
            string mystring = "256";
            string stringResult;
            int intResult;
            //string→int

            //(int) 此方法不适用于将string转换为int,只能转换数值类型为int,而不能转换引用类型
            //不会进四舍五入,直接舍掉小数
            //intResult = (int)mydouble;
            //Console.WriteLine(intResult);

            //Convert.ToInt32() 它会将空值NULL转换为0
            //0-4:直接舍掉
            //5:看整数位,4.5 5  6 返回一个临近的偶数
            //6-9:进位

            //intResult = Convert.ToInt32(mydouble);
            //Console.WriteLine(intResult);

            ////int.Parse();不能转换空值 只能将string转换为int
            //intResult = int.Parse(mystring);
            //Console.WriteLine(intResult);

            //int→string
            //强制括号转换只能转换数值类型的 stringResult = (string)myint;
            stringResult = Convert.ToString(myint);

            stringResult = myint.ToString();

           

            Console.ReadKey();
        }
    }
}
