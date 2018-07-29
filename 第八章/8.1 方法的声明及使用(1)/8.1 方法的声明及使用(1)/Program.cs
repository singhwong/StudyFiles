using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_方法的声明及使用_1_
{
    class Program
    {
        //写两个方法分别用于计算圆的周长与面积,并进行对应的调 用
        static void Factorial(int num)//void表示没有返回值,有返回值的话,直接用对应的类型替换void
        {

            int factorial = 1;
            for (int i = num; i > 0; i--) factorial *= i;
            Console.WriteLine("{0}的阶乘是:{1}",num,factorial);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {

            Factorial(8);
            Factorial(7);
            Factorial(6);
            Factorial(5);
           int c= Add(25.3,26);
            Console.WriteLine(c);
            Console.ReadKey();
            //实现8,7,6,5的阶乘

            ////8的阶乘
            //int factorial = 1;
            //for (int i = 8; i > 0; i--) factorial *= i;
            //Console.WriteLine("8的阶乘是:"+factorial);
            ////7的阶乘
            //factorial = 1;
            //for (int i = 7; i > 0; i--) factorial *= i;
            //Console.WriteLine("7的阶乘是:"+factorial);
            ////6的阶乘
            //factorial = 1;
            //for (int i = 6; i > 0; i--) factorial *= i;
            //Console.WriteLine("6的阶乘是:" + factorial);
            ////5的阶乘
            //factorial = 1;
            //for (int i = 5; i > 0; i--) factorial *= i;
            //Console.WriteLine("5的阶乘是:" + factorial);





        }
    }
}
