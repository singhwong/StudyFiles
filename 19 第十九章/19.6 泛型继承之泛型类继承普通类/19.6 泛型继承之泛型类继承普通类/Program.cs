using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._6_泛型继承之泛型类继承普通类
{

    public abstract class baseClass//普通基类的创建
    {
        protected int user_name;//定义字段
        public virtual int user_Name//定义属性
        {
            set { user_name = value; }
            get { return user_name; }
        }
        public baseClass(int index)//构造函数
        {
            user_name = index;
        }
        public abstract void method(int t);
    }

    public class GenClass<T> : baseClass
    {
        protected new T user_name;
        public new T user_Name
        {
            get { return user_name; }
        }
        public GenClass(int index) : base(index)
        { }
        public GenClass(T t) : base(1000)
        {
            user_name = t;
        }
        public override void method(int t)
        {
            Console.WriteLine("调用方法成功");
        }
        public void method(T t)
        { }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int val = 1000;
            GenClass<int> g = new GenClass<int>(val);
            g.method(g.user_Name);
            Console.WriteLine("泛型继承演示成功：泛型类继承普通类");
            Console.Read();

        }
    }
}
