using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5_抽象类与抽象方法的声明
{
    class PowB:Pow
    {
        public override void PowMethod(int x,int y)
        {
            int pow=1;
            for (int i = 1; i <= y; i++)

            {
                pow *= x;
            }
            Console.WriteLine("求幂的结果是"+pow);
        }
    }
}
