using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _17._7_Hashtable概述及元素的添加
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, "李四");
            ht[3] = "王五";//用此种方式对Hashtable去增加元素时应该注意
            //如果对应的键key,存值，只达到一种重新赋值的结果
            //如果不存在，才会增加对应的键值对
            ht[1] = "赵六";

            //数组通过length可以确定长度
            //集合是通过count来确定个数

            Console.WriteLine(ht.Count);
            Console.Read();

        }
    }
}
