using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._11_ArrayList类中元素的遍历与查找
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList(2);
            myArrayList.Add("数字:");
            int[] myintArray = { 1,2,3,4,5,6,7,8,9};
            myArrayList.AddRange(myintArray);
            myArrayList.Add("字符串:");
            string[] mystringArray = { "张三","李四","王五","张三"};
            myArrayList.AddRange(mystringArray);
            //以下实现ArrayList遍历
            foreach (object outElement in myArrayList) Console.Write(outElement+"\t");
            Console.WriteLine();
            //元素的查找
            //有三个方法
            //1)IndexOf(要查找的元素),返回一个首次出现的索引整型值,如果查找不到,返回-1
            Console.WriteLine(myArrayList.IndexOf("张三"));
            //LastIndexOf(要查找的元素) 返回一个最后一次出现的索引整型值,否则 返回-1
            Console.WriteLine(myArrayList.LastIndexOf("张三"));
            //BinarySearch();查找不到返回-1
            //Console.WriteLine(myArrayList.BinarySearch("张三"));
            ArrayList newArrayList = new ArrayList();
            newArrayList.AddRange(myintArray);
            newArrayList.Add(10);
            newArrayList.Add(20);
            foreach (object outElement in newArrayList) Console.Write(outElement + "\t");
            Console.WriteLine();
            Console.WriteLine(newArrayList.BinarySearch(20));
        
         

            Console.ReadKey();
        }
    }
}
