using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._13_类的多态
{
    class ProjectManager:Clerk
    {
        public override void WorkPlan()
        {
            Console.WriteLine("我是项目经理,我也需要有工作计划");
        }
    }
}
