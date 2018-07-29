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
            zsClerk.CSayHello();
            Sales zsSales = new Sales("和珅","和府",2500);
            zsSales.SSayHello();
            TechnicalSupport zsTC = new TechnicalSupport("纪晓岚","纪府",0.98);
            zsTC.TSSayHello();
            Console.ReadLine();

        }
    }
}
