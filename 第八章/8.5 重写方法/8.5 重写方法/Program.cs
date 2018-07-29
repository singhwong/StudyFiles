using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._5_重写方法
{
    //新建一个类存放虚方法

    class class1
    {
        public virtual void Write()
        {
            Console.WriteLine("这是一个虚方法,这可以被重写");
        }
    }
    //再新建一个继承类用于重写方法
    class class2 : class1
    {
        //重写方法
        public override sealed void Write()
        {
            Console.WriteLine("这是一个重写方法,被称为已经重写了的基方法");
        }
    }

    //如果我不想让继承class2的类去重写Write()方法,应该怎么做呢?
    //那就采用关键字sealed
    class class3 : class2
    {
        public override void Write()
        {
            Console.WriteLine("这是我再次重写的方法");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();
            c1.Write();
            class2 c2 = new class2();
            c2.Write();
            Console.ReadKey();
        }
    }
}
