using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._7_泛型继承之普通类继承泛型类
{
    abstract class genClass<T>
    {
        protected T field;
        public virtual T property
        {
            get { return field; }
        }
        public genClass(int index) { }
        public genClass(T t) { field = t; }
        public abstract void method(T t);
    }

    class ordinaryClass : genClass<int>
    {
        public override int property
        {
            get
            {
                return base.property;
            }
        }
        public ordinaryClass(int t) : base(t) { }
        public override void method(int t)
        {
            Console.WriteLine("property属性值为：{0}",t);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int val = 1000;
            ordinaryClass oc = new ordinaryClass(val);
            oc.method(val);
            Console.WriteLine("泛型类继承普通类演示成功！");
            Console.Read();
        }
    }
}
