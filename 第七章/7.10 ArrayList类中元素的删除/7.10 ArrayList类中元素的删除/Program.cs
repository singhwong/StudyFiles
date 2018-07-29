using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._10_ArrayList类中元素的删除
{
    class Program
    {
        static void Main(string[] args)
        {
            //元素删除有四种方法

            System.Collections.ArrayList myArrayList = new System.Collections.ArrayList(3);
            myArrayList.Add(1);
            myArrayList.Add("成功");
            myArrayList.Add(25.63);
            string[] mystringArray = { "张三","李四","王五","赵六"};
            myArrayList.AddRange(mystringArray);
            Console.WriteLine("删除之前的内容");
            foreach (object outelemnet in myArrayList) Console.Write(outelemnet+"\t");
            //Remove(值)
            Console.WriteLine("\n删除之后的内容为:");
            myArrayList.Remove("张三");
            foreach (object outelemnet in myArrayList) Console.Write(outelemnet + "\t");

            //RemoveAt(索引值)
            Console.WriteLine("\n删除 李四 之后的内容为");
            myArrayList.RemoveAt(3);
            foreach (object outelemnet in myArrayList) Console.Write(outelemnet + "\t");
            //RemoveRange(起始索引,删除个数)
            Console.WriteLine("\n 删除 王五  赵六 之后的内容为");
            myArrayList.RemoveRange(3,2);
            foreach (object outelement in myArrayList) Console.Write(outelement+"\t");

            //Clear()
            Console.WriteLine("\n清除所有元素");
            myArrayList.Clear();
            foreach (object outelement in myArrayList) Console.Write(outelement + "\t");


            Console.ReadKey();
        }
    }
}
