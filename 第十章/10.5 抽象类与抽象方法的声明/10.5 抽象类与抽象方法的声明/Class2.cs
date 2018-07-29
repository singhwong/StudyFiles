using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5_抽象类与抽象方法的声明
{
    public abstract class Class2:Class1
    {
        public override void Method1()
        {
            Console.WriteLine("这是抽象方法1");
        }
    }
}
