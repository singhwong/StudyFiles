using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2_枚举
{
    //在此处声明枚举,它与结构的作用很类似,所以位置一样,但同时,枚举也可以在结构中被调用

    public enum Gender
    {
        男,
        女

    }
    public enum Week
    {
        星期一,
        星期二,
        星期三,
        星期四=4,
        星期五,
        星期六=10,
        星期日

    }
    class Program
    {
        static void Main(string[] args)
        {
            Gender zsgender = Gender.男;
            Console.WriteLine((int)zsgender);
            //(int)实现将枚举转换为整型
            Console.WriteLine(zsgender.ToString());

            int myint = 10;
            Console.WriteLine((Week)myint);
            //(枚举名)实现将整型转换为枚举

            Week myWorkDay = Week.星期四;
            Console.WriteLine((int)myWorkDay);
            //将枚举转换为字符串 不能用(string) 只能用myWorkDay.ToString();Convert.ToString(myWorkDay);
            Console.WriteLine(myWorkDay);
            //将字符串转换为枚举值,
            string mystr2 = "123";
            Console.WriteLine((Week)Enum.Parse(typeof(Week), mystr2)); 
            //如果需要转换的字符串不是数字,而且枚举值中不含有该值, 就会报异常
            //如果需要转换的字符串是数字,且不包含该值,但不报异常

            Console.ReadKey();



        }
    }
}
