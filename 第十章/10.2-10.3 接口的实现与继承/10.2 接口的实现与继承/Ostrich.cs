using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_接口的实现与继承
{
    class Ostrich:Bird
    {
        public override void Eat()
        {
            Console.WriteLine("我是驼鸟,我专吃青草");
        }
    }
}
