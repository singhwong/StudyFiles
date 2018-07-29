using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._11_定义泛型方法
{
    //定义普通类
    public class myclass
    {
        //定义泛型方法
        public bool Contains<T>(T[] TArray, T TValue)
        {
            //遍历元素
            foreach (T t in TArray)
            {
                //判断是否存在TValue
                if (t.Equals(TValue))
                    return true;//存在返回true               
            }
            return false;//不存在返回false
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
