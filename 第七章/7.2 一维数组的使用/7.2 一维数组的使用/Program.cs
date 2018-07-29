using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_一维数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = { "张三", "李四", "王五", "赵六" };
            //使用数组中的元素是通过索引值来实现的
            //数组元素的转出Console.WriteLine(Name[1]);
            //数组元素的重新赋值
            //Console.WriteLine(Name[3]);
            //Name[3] = "刘七";
            //Console.WriteLine(Name[3]);
            //数组中遍历元素,即对数组中的所有元素都按次序访问仅一次
            Console.WriteLine("利用FOR进行遍历");
            for (int i=0;i<4;i++)
                Console.WriteLine(Name[i]);
            //遍历数组元素最好用的是foreach
            Console.WriteLine("利用foreach进行遍历");
            foreach (string mystr in Name) Console.WriteLine(mystr);

            Console.ReadKey();
        }
    }
}
