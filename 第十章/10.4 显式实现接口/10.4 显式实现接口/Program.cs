using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._4_显式实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //隐式地实现接口
            //接口调用
            //IFlyable1 myEagle1 = new Eagle();
            //myEagle1.Fly();
            //具体类调用
            //Eagle myEagle2 = new Eagle();
            //myEagle2.Fly();

            //IFlyable1 myBalloon1 = new Balloon();
            //myBalloon1.Fly();
            //IFlyable2 myBalloon2 = new Balloon();
            //myBalloon2.Fly();
            //作用就是指定方法到底是哪个接口的
            //Balloon myBalloon3 = new Balloon();
            // myBalloon3.Fly();

            //同时显式和隐式实现接口
            IFlyable1 mySparrow1 = new Sparrow();
            mySparrow1.Fly();

            //Sparrow mySparrow2 = new Sparrow();
            //mySparrow2.Fly();


            Console.ReadKey();
        }
    }
}
