using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6_查找数组元素
{
    class Program
    {
        static void Main(string[] args)
        {
            ////想查找是否存在某个元素比如说8
            ////IndexOf可以查找元素首次出现的位置
            ////LastIndexOf可以查找元素最后一次出现的位置,位置都是以从0开始的索引值
            ////IndexOf与LastIndexOf都返回数组或集合中最后一次出现该元素的一个索引值,为整型int
            //int result;
            ////IndexOf(参数1,参数2):参数1是我们要查找的数据,参数2要查找的元素 
            //result = Array.IndexOf(myintArray,5);
            ////我们常常利用返回值来判断某个数组中是否存在某个元素,存在返回的是一个>=0索引值,不存时呢,返回-1
            //if (result < 0) Console.WriteLine("该数组中不存在该元素");
            //else Console.WriteLine("找到该元素");

            //int result2= Array.BinarySearch(myintArray, 26);
            //Console.WriteLine("result2的值是:"+result2);
            ////BinarySearch用于查找元素首次出现的索引值,采用的方法叫做二分法,如果不存在该元素,返回一个负值


            //Console.WriteLine("5第一次出现的索引值是{0},最后一次出现的索引值是{1}",Array.IndexOf(myintArray,5),Array.LastIndexOf(myintArray,5));


            //Console.WriteLine(result);



            int[] myintArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 1, 2, 3, 4, 5, 6 };
            //Array的Contains方法实际是对IList接口中方法的实现,因此使用之前需要将数组转换为该对象
            //转换的格式:   ((System.Collections.IList)myintArray).Contains(8);
            //返回是一个布尔值
            bool mybool;
            mybool = ((System.Collections.IList)myintArray).Contains(48);
            if (mybool) Console.WriteLine("存在该元素");
            else Console.WriteLine("不存在");

            Console.ReadKey();
        }
    }
}
