using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_接口的实现与继承
{
    class Sparrow : Bird,IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("我是麻雀,我会飞");
        }
        public override void Eat()
        {
            Console.WriteLine("我是麻雀,我专吃粮食");
        }
    }
}
