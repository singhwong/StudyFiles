using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_分支语句之if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断变量a中存放数值与10的关系
            Console.WriteLine("请输入数值，判断它与10的关系：");
            int a = int.Parse(Console.ReadLine());
            //int.Parse用于将屏幕输入的语句转换为整型
            if (a<10)
            {
                Console.WriteLine("您输入的数什小于10");
            }
           else if (a==10)
            {
                Console.WriteLine("您输入的数值等于10");
            }
           else//如果前边的if语句一条也没有执行，那就执行else语句
           //如果执行了其中一条if句语，那就不会执行else语句
            {
                Console.WriteLine("您输入的数值大于10");
            }
            Console.ReadKey();
        }
    }
}
