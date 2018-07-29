using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._13_类的多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clerk myClerk = new Clerk();
            //ProjectManager myPM = new ProjectManager();

            //Clerk[] clerk = { myClerk, myPM };
            //foreach (Clerk outclerk in clerk)
            //    outclerk.WorkPlan();

            //Drink myMilk = new Milk();
            Drink myMilk = new Milk();
            Drink myTea = new Tea();
            Drink[] drink = { myMilk,myTea};
            foreach (Drink outdrink in drink) outdrink.drink();
        
            //抽象类是不允许创建实例的.

            Console.ReadKey();


        }
    }
}
