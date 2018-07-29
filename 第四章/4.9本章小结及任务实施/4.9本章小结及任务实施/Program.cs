using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            //1232855秒是几天几小时几分几秒
            Console.WriteLine("请输入您想要计算的秒数");
            int time = Convert.ToInt32(Console.ReadLine());
            int day = time / (24 * 3600);
            int hour = time % (24 * 3600) / 3600;
            int min = time % 3600 / 60;
            int sec = time % 60;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒",time,day,hour,min,sec);
            Console.ReadKey();

        }
    }
}
