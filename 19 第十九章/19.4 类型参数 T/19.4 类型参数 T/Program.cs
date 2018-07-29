using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._4_类型参数_T
{
    //定义泛型类
    public class TGenericDemo<T>
    {
        void Exp(T input)
        {

        }
    }
    class Program
    {
        private class customClass
        {

        }
        static void Main(string[] args)
        {
         
            //实例化泛型类,gd1,char
            TGenericDemo<char> gd1 = new TGenericDemo<char>();
            Console.WriteLine("实例化类型为char的TGenericDemo的gd1成功!");

            TGenericDemo<int> gd2 = new TGenericDemo<int>();
            Console.WriteLine("实例化类型为int的TGenericDemo的gd2成功!");

            TGenericDemo<string> gd3 = new TGenericDemo<string>();
            Console.WriteLine("实例化类型为string 的TGenericDemo的gd3成功");

            TGenericDemo<customClass> gd4 = new TGenericDemo<customClass>();
            Console.WriteLine("实例化类型为自定义类型的TGenericDemo的gd4成功!");

            Console.Read();
        }
    }
}
