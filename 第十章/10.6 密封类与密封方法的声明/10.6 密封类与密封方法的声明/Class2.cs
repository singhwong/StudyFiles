using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._6_密封类与密封方法的声明
{
    //如果一个类不希望将来在使用的过程被继承,被派生,这时候可以采用关键字sealed
    //虚方法virtual 抽象方法abstract的存在就是为了继承,为了派生,因此不能被放在sealed类中
   public  class Class2:Class1
    {
        public sealed override void Write()
        {
            Console.WriteLine("这是一个密封方法");
        }
        public void NewWrite()
        {
            Console.WriteLine("这是增加的一个方法");
        }
    }
}
