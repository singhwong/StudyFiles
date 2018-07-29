using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._3_自定义泛型类的创建
{
    public class TGeneric<T>
    {
        public T Field;
    }

    class commonlyClass
    {
        public T G<T>(T t)//方法
        {
            return t;
        }
    }

    class TGenericTwo<T>
    {
        public T M(T t)//泛型方法
        {
            return t;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TGeneric<string> g = new TGeneric<string>();
            g.Field = "51zxw.net";
            Console.WriteLine(g.Field);
            Console.Read();
        }
    }
}
