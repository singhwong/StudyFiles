using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._7_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            ISaywords myCat1 = new TomCat();
            myCat1.Say();
            ISaywords myCat2 = new KittyCat();
            myCat2.Say();
            RealCat mycat3 = new RealCat();
            mycat3.Say();
            Console.ReadKey();
        }
    }
}
