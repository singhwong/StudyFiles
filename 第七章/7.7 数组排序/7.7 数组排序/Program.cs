using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7_数组排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组排序主要通过Array类下的Sort与Reverse进行操作
            int[] myintArray = { 1,2,3,45,5,245,245,212,5,2,5,8,21,2,454,21,456};
            //我们给定一个扰乱顺序的数组
            Console.WriteLine("原数组是:");
            foreach (int outint in myintArray) Console.Write(outint+"\t");

            //利用Sort实现升序的排列
            Console.WriteLine("\n数组实现升序后是:");
            Array.Sort(myintArray);
            foreach (int outint in myintArray)
            Console.Write(outint+"\t");

            //利用Reverse可以实现数组元素的降序排列,并且更改原数组的存储位置
            Console.WriteLine("\n数组实现降序排序后是:");
            Array.Reverse(myintArray);
            foreach (int outint in myintArray) Console.Write(outint+"\t");
            Console.ReadKey();

        }
    }
}
