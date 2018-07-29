using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._13_类的多态
{
    class Clerk
    {
        public virtual void WorkPlan()
        {
            Console.WriteLine("我是职员,我需要有工作计划");
        }
    }
}
