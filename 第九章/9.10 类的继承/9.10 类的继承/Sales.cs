using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10_类的继承
{
    //继承于Clerk
    class Sales:Clerk
    {
        private int _salesTarget;

        public int SalesTarget
        {
            get
            {
                return _salesTarget;
            }

            set
            {
                _salesTarget = value;
            }
        }
        public void SSayHello()
        {
            Console.WriteLine("大家好,我是{0}的{1},我的销售目标是{2}",this.Department,this.Name,this.SalesTarget);
        }
    }
}
