using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10_类的继承
{
    class Clerk
    {
        private string _name;
        //private由于私有,不能被子类访问
        public string Name
        {
            get { return _name; }
            set { _name = value; }
            }
        private string _department;
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public void CSayHello()
        {
            Console.WriteLine("大家好,我是{0}的{1}",this.Department,this.Name);
        }
    }
}
