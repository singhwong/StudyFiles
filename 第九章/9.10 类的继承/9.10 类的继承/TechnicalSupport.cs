using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10_类的继承
{
    class TechnicalSupport:Clerk
    {
        private double _satisfactionRate;

        public double SatisfactionRate
        {
            get
            {
                return _satisfactionRate;
            }

            set
            {
                _satisfactionRate = value;
            }
        }
        public void TSSayHello()
        {
            Console.WriteLine("大家好,我是{0}的{1},我的服务满意率为{2}",this.Department,this.Name,this.SatisfactionRate);

        }


    }
}
