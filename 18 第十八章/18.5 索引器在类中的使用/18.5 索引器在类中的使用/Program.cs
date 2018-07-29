using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._5_索引器在类中的使用
{
    class Program
    {
        public class indexText//访问类实例
        {
            private int[] array = new int[10];
            public int this[int index]
            {
                get
                { if (index < 0 || index >= 10) return 0;
                    else return array[index];
                }
                set
                {
                    if (index >= 0 && index < 10) array[index] = value;
                }
            }

        }
        public class weekIndex//访问类成员
        {
            string[] Week = { "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期日" };
            private int getDay(string weekText)
            {
                int i = 0;
                foreach (string day in Week)
                {
                    if (day == weekText) return i;
                    i++;
                }
                return -1;

            }
            public int this[string week]
            {
                get { return getDay(week); }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("访问类实例的结果:");
            indexText Arr = new indexText();
            Arr[-5] = 5;
            Arr[0] = 15;
            Arr[1] = 30;
            Arr[2] = 60;
            Arr[11] = 65;
            Console.WriteLine("Arr[-5]={0}",Arr[-5]);
            Console.WriteLine("Arr[0]={0}", Arr[0]);
            Console.WriteLine("Arr[1]={0}", Arr[1]);
            Console.WriteLine("Arr[2]={0}", Arr[2]);
            Console.WriteLine("Arr[11]={0}", Arr[11]);
            Console.WriteLine("访问类成员结果");
            weekIndex we = new weekIndex();
            Console.WriteLine(we["星期三"]);
            Console.WriteLine(we["星期五"]);
            Console.WriteLine(we["星期日"]);
            Console.WriteLine(we["星期八"]);

            Console.ReadKey();

        }
    }
}
