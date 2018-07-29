using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5_遍历数组

{
    class Program
    {
        static void Main(string[] args)
        {
            //5行2列
            string[,] FriendName = { { "张三", "男" }, { "李四", "女" }, { "王五", "男" }, { "赵六", "女" }, { "孙七", "未知" } };

            //正序输出
            Console.WriteLine("以下是正序输出");
            for (int i = 0; i < 5; i++)

            {
                for (int j = 0; j < 2; j++)

                {
                    Console.Write(FriendName[i,j]+"\t");
                }
                Console.WriteLine();
            }
            //倒序输出
            Console.WriteLine("以下是倒序输出");
            for (int i = 4; i >=0; i--)

            {
                for (int j = 1; j >= 0; j--)
                {
                    Console.Write(FriendName[i,j]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("以下为Length这个属性:数组包含元素的总个数");
            Console.WriteLine(FriendName.Length);
            //[5,2]
            Console.WriteLine(FriendName.GetLowerBound(0));
            Console.WriteLine(FriendName.GetUpperBound(0));
            Console.WriteLine(FriendName.GetUpperBound(1));
            //查看4行1列的元素
            Console.WriteLine(FriendName[3,0]);
            Console.WriteLine(FriendName.GetValue(3,0));

            Console.ReadKey();
          

        }
    }
}
