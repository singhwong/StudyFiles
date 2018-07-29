using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3_二维数组声明
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] FriendName = { "张三", "李四", "王五", "赵六", "刘七" };

            //二维数组的声明
            string[,] Friend;
            //初始化第一种方法:指定字面值 ,适用于已知元素内容
            string[,] Friend2 = { { "张三","男"}, { "李四","女"}, { "王五","男"}, { "赵六","女"}, { "刘七","未知"} };

            //初始化第二种方法:new关键字,适用于元素内容未知
            //string[,] Friend3;
            //Friend3 = new string[5,2];
            string[,] Friend3 = new string[5,2];

            string[,] Friend4 = new string[5, 2] { { "张三", "男" }, { "李四", "女" }, { "王五", "男" }, { "赵六", "女" }, { "刘七", "未知" } };


        }
    }
}
