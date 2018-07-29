using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5_抽象类与抽象方法的声明
{
  public abstract class Class1
    {
        public abstract void Method1();
        //抽象类与抽象方法声明中必须包含abstract,并且抽象方法不能有方法体
        //抽象类的声明就是为了实现派生或者继承,所以我们不能将它同时标记为sealed
        public abstract void Method2();

        //抽象类中可以包含非抽象方法
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
}
