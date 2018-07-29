using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10_类的继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Clerk zsClerk = new Clerk("张三","人事部");
          
            Sales zsSales = new Sales("张三","人事部",2500);
            TechnicalSupport zsTC = new TechnicalSupport("张三","人事部",0.98);

        }
    }
}
