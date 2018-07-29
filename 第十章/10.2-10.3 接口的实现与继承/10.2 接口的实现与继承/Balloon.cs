using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_接口的实现与继承
{
    class Balloon:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("我是气球,我会飞");
        }
    }
}
