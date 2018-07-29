using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4_显式实现接口
{
    class Eagle:Bird,IFlyable1
    {
        public override void Eat()
        {
            Console.WriteLine("我是老鹰,我吃小鸡");
        }
        public void Fly()
        {
            Console.WriteLine("我是老鹰,我会飞");
        }
    }
}
