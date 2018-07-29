using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_接口的实现与继承
{
    class Eagle : Bird,IFlyable
    {

        //接口的实现过程需要在实现接口的类中进行实现
        public void Fly()
        {
            Console.WriteLine("我是老鹰,我会飞");
        }

        public override void Eat()
        {
            Console.WriteLine("我是老鹰,我专吃小鸡");
        }
    }
}
