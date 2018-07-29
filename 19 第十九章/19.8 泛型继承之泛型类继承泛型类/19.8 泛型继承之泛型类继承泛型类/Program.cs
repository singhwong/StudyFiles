using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._8_泛型继承之泛型类继承泛型类
{
    //定义泛型基类
    //<T>T可以是任意的标识符，只要遵循我们的通常C#中命名规则即可。T1，T2，T3
    abstract class genBaseClass<T1, T2>
    {
        //定义两个字段
        public T1[] str;
        public T2[] ind;
        //定义一个索引属性
        public T1 this[int index]
        {
            set { str[index] = value; }
            get { return str[index]; }
        }
        //定义一个获取数组长度的属性
        public int length
        {
            get { return str.Length; }
        }
        //构造函数
        public genBaseClass(int index)
        {
            str = new T1[index];
            ind = new T2[index];
        }

    }
    //定义派生泛型类
    class genClass<T> : genBaseClass<T, int>
    {
        public genClass(int index) : base(index)
        {
            for (int i = 0; i < length; i++)
            {
                ind[i] = i;
            }
        }
        //派生类中定义一个output方法
        public void output()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(str[i].ToString());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //实例化类对象
            genClass<string> gc = new genClass<string>(6);
            //添加元素的过程
            gc[0] = "first";
            gc[1] = "second";
            gc[2] = "third";
            gc[3] = "fourth";
            gc[4] = "fifth";
            gc[5] = "sixth";
            //调用方法，遍历元素
            gc.output();
            Console.WriteLine("泛型继承之泛型类继承泛型类演示成功！！！");
            Console.Read();

        }
    }
}
