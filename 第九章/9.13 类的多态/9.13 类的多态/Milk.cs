using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._13_类的多态
{
    class Milk:Drink
    {
        public override void drink()
        {
            Console.WriteLine("我是牛奶,我可以解渴");
        }
    }
}
