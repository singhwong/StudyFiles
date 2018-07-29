using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._13_类的多态
{
    abstract class Drink
    {
        public abstract void drink();
        //利用抽象来实现,类抽象化,方法抽象化,并且方法中不能有方法体{}
        //{
        //    Console.WriteLine("我是饮料,我可以解渴");
        //}
    }
}
