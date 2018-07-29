using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4_显式实现接口
{
    class Sparrow:Bird,IFlyable1
    {
        public void Fly()
        {
            Console.WriteLine("(隐式实现)我是麻雀,我会飞");
        }
        //void IFlyable1.Fly()
        //{
        //    Console.WriteLine("(显式实现)我是麻雀,我会飞");
        //}
        public override void Eat()
        {
            Console.WriteLine("我是麻雀,我吃粮食");
        }
    }
}
