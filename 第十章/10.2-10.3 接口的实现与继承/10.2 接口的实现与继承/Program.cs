using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_接口的实现与继承
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flys = { new Sparrow(),new Eagle(),new Swan(),new Balloon()};
            foreach (IFlyable outFlys in flys) outFlys.Fly();
            Bird[] eat = {new Sparrow(),new Eagle(),new Swan()};
            foreach(Bird outeat in eat)
            {
                outeat.Eat();
            }
            Console.ReadKey();         

        }
    }
}
