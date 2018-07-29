using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4_二维数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //5行2列
            string[,] FriendName = { { "张三", "男" }, { "李四", "女" }, { "王五", "男" }, { "赵六", "女" }, { "孙七", "未知" } };
            //我们可将[3,2,2]理解为3个二维数组,这个二维数组由2行2列构成
            //有几层{}嵌套,那就是一个几维数组
            //string[,,] FriendName1 = new string[3,2,2] { { { "张三", "男" }, { "李四", "女" } }, { { "王五", "男" }, { "赵六", "女" } }, { { "孙七", "未知" }, { "刘八","女"} } };

            Console.WriteLine(FriendName[2,0]);

            FriendName[2, 0] = "王大";
            Console.WriteLine(FriendName[2,0]);

            for (int i = 0; i <5 ; i++)//此处为行数
            {

                for (int j = 0; j < 2; j++)//此处为列数
                {
                    Console.Write(FriendName[i,j]+"\t");
                }
                Console.WriteLine();
            }


            foreach (string outstr in FriendName)//能够避免越界
            { Console.Write(outstr+"\t"); }


            Console.ReadKey();
          

        }
    }
}
