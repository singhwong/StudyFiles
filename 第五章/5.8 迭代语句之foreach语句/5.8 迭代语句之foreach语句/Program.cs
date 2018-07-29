using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8_迭代语句之foreach语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 50; i++)
            //{

            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < =50; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //将语句识别为单词并逐行输出
            //语句用string类型  字母用char
            Console.WriteLine("请您输入一个英文句子");
            string str = Console.ReadLine();
            Console.WriteLine("您输入的句子包含以下的单词");
            foreach (char word in str)
            {
                if (char.IsWhiteSpace(word))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(word);
                    //word = 't';//foreach语句的迭代变量不允许重新赋值
                }
            }

            Console.ReadKey();
        }
    }
}
