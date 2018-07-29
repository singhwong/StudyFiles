using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._12_跳转语句之goto语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("5的阶乘等于几？根据以下选项选择正确答案，回车键确认：");
            Console.WriteLine("1. 5!=5\n2. 5!=10\n3. 5!=20\n4. 5!=60");
            error:
            {
                a++;
                if (a > 1) Console.WriteLine("很遗憾,您答错了,请重新输入答案.");

            }
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                case 2:
                case 3: goto error;
                case 4:goto right;
                default:
                    Console.WriteLine("您选择的选项不存在");
                    goto end;

            }

            right:

            Console.WriteLine("恭喜您，答对了！");
            end:
            Console.ReadKey();

        }
    }
}
