using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_静态方法与实例方法
{
    class Program
    {
        int exampleVar=0;//实例成员
        static int staticVar=0;//静态成员
        static void staticMethod()//静态方法
        {
            //exampleVar = 1;无法在静态方法中调用实例类成员
            staticVar = 1;
        }

        void exampleMethod()//实例方法
        {
            //实例中可以调用任何成员,包括静态与实例类的
            staticVar = 1;
           //等价于 this.staticVar = 1;
            exampleVar = 1;
        }

        static void Main(string[] args)
        {

            Program.staticMethod();//调用静态方法时直接调用
            //将类进实例化
            Program p = new Program();
            p.exampleMethod();

            Program.exampleMethod();//不能通过访问静态方法的途径去访问实例方法;

           
            p.exampleMethod();


        }
    }
}
