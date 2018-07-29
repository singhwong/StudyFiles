using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_接口的实现与继承
{
    class Swan:Bird,IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("我是天鹅,我吃鱼");
        }
        public void Fly()
        {
            Console.WriteLine("我是天鹅,我会飞");
        }
    }
}
