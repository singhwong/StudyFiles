using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._14_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird myEagle = new Eagle();
            Bird mySparrow = new Sparrow();
            Bird myOstrich = new Ostrich();
            Bird[] myBird = { myEagle,mySparrow,myOstrich};
            foreach (Bird outBird in myBird) outBird.Write();
            Console.ReadKey();
        }
    }
}
