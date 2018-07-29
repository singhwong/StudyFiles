using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6_密封类与密封方法的声明
{
  public  class Class3:Class2
    {
        //public override sealed void Write()
        //{
        //    Console.WriteLine("这个方法能否被继承");
        //}
        //不能重写密封方法
        public void NewWirte()
        {
            Console.WriteLine("这是继承增加方法");
        }
    }
}
