using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._18_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个字符串,每个字符串以回车确认输入,我们将会以\"|\"来进行分隔 :");
            string mystr1 = Console.ReadLine();
            string mystr2 = Console.ReadLine();
            string maxstr;
            if (string.Compare(mystr1, mystr2) > 0) maxstr = mystr1;
            else maxstr = mystr2;
            Console.WriteLine("您输入的两个字符串分别是:{0},{1}",mystr1,mystr2);
            //利用SubString来进行分隔
            Console.WriteLine("拆分较大字符串后的结果是:");
            for (int i = 0; i < maxstr.Length; i++)
            {
                Console.Write(maxstr.Substring(i, 1));
                if(i!=maxstr.Length-1)Console.Write("|");
            }
            Console.ReadKey();
        }
    }
}
