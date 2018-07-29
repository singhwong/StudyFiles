using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5_抽象类与抽象方法的声明
{
   public abstract class Pow
    {
        public abstract void PowMethod(int x,int y);

        //abstract方法  :没有自己的实现
        //virtual方法:有自己的实现
        //共同点:都可以通过override来实现对原有方法的重写
    }
}
