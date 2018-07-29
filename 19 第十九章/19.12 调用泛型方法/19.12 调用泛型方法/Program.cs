using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._12_调用泛型方法
{
    public class myclass
    {
        //泛型方法实现的
        public bool Contains<T>(T[] TArray, T TValue)
        {
            foreach (T t in TArray)
            {
                if (t.Equals(TValue)) return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] myint = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myclass mc = new myclass();
            bool mybool;
            int testInt = 5;
            //完整调用
            //mybool = mc.Contains<int>(myint, testInt);
            //简写调用
            mybool = mc.Contains(myint, testInt);
            if (mybool) Console.WriteLine("数组中包含有元素" + testInt);
            else Console.WriteLine("数组中不存在元素"+testInt);
            Console.ReadKey();
        }
    }
}
