using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_一维数组的声明
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myintArray= { 0,2,4,6,8,10};
            //用于已经变量数组内容的声明,利用字面值直接进行声明


            string[] mystringArray;
            mystringArray = new string[100];
            //用于未知数组各元素的值的一个声明,指定数组的长度

            string[] NameArray = new string[3] {"张三","李四","王五" };
            //元素个数与数组长度必须一一对应
            const int a = 3;
            string[] NameArray1 = new string[a] { "张三", "李四", "王五" };
          


        }
    }
}
