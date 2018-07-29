using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._4_虚方法
{
    //新建一个class1类
    class class1
    {
//默认的方法被指定为私有的,只能在当前类中进行访问 private
//需要在其他类中访问,就需要将其指定为public:访问权限最高,只要在项目内部都可以进行访问
//virtual关键字必须位于void前
public virtual void virtualMehtod()//因为虚方法能够在派生类中进行重写

        {
            Console.WriteLine("这是一个虚方法");
        }
        public void nonVirtualMehtod()
        {
            Console.WriteLine( "这是一个非虚方法");
        }

    }

    class class2:class1//将class2继承于class1
    {
        //重写一下虚方法
        public override void virtualMehtod()
        {
            Console.WriteLine("这是一个新写的虚方法");
        }
        public new void nonVirtualMehtod()
        {
            Console.WriteLine("这是一个新的方法");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            class1 c1 = new class1();//将类进行实例化
            c1.virtualMehtod();
            c1.nonVirtualMehtod();
            class2 c2 = new class2();
            
            c2.virtualMehtod();
            c2.nonVirtualMehtod();
            c1 = c2;
            c1.virtualMehtod();
            c1.nonVirtualMehtod();

            Console.ReadKey();





        }
    }
}
