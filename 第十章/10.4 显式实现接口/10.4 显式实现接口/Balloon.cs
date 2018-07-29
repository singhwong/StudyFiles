using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4_显式实现接口
{
    class Balloon:IFlyable1,IFlyable2
    {
        //显式实现接口
      void IFlyable1.Fly()
        {
            Console.WriteLine("我是1中的飞");
        }
        void IFlyable2.Fly()
        {
            Console.WriteLine("我是2中的飞");
        }
    }
}
