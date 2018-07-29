using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5_迭代语句之do._.while语句
{
    class Program
    {
        static void Main(string[] args)
        {

            //输出1-50到屏幕上
            //int num = 0;
            //do
            //{
            //    num++;
            //    Console.WriteLine(num);
            //} while (num !=0);
            double Balance=0;
            double Rate = 0;
            int Year = 0;
            double TargetBalance = 0;
            Console.WriteLine("请输入您的本金");
            Balance = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入当前的利率百分比");
            Rate = double.Parse(Console.ReadLine())/100;
            Console.WriteLine("请输入您的目标收益");
            //验证输入的有效性
            do
            {
                TargetBalance = double.Parse(Console.ReadLine());
                if (TargetBalance <= Balance) Console.WriteLine("您没有必要存钱，请重新输入一个比本金大的收益");

            } while (TargetBalance<=Balance);
            do
            {
                Balance *= (Rate+1);
                Year++;

            } while (Balance<TargetBalance);
            Console.WriteLine("您将在{0}年内，获得{1}元的收益",Year,Balance);

            Console.ReadLine();
        }
    }
}
