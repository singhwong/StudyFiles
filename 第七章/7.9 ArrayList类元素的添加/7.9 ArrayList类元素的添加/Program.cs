using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _7._9_ArrayList类元素的添加
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList(5);
            //ArrayList的好处是,长度不固定,类型随意
            //数组的长度是固定的,不能更改的,类型单一,只能为其中的一种
            Console.WriteLine("myArrayList初始化之后有{0}个元素",myArrayList.Count);
            //Add方法用于向ArrayList中添加单个元素,每次只能加一个
            myArrayList.Add(123);
            myArrayList.Add('a');
            myArrayList.Add("mystring");
            myArrayList.Add(25.6);
            myArrayList.Add(10L);
            Console.WriteLine("使用Add方法添加5个元素之后,有{0}个元素",myArrayList.Count);
            //AddRange方法用于一次性向ArrayList中添加多个元素,可以是一个数组
            string[] mystringArray = { "张三","李四","王五","赵六"};
            myArrayList.AddRange(mystringArray);
            Console.WriteLine("使用AddRange方法后,有{0}个元素",myArrayList.Count);
            //遍历集合元素
            //引用类型string object类是所有类型的基类
            foreach (object outelement in myArrayList) Console.Write(outelement+"\t");
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
