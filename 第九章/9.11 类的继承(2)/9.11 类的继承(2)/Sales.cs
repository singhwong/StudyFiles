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
        //private string _name;

        ////new关键字可以用来隐藏基类中同名的成员
        ////new实例化对象
        //public new string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }

        //    set
        //    {
        //        _name = value;
        //    }
        //}

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
        //public Sales(string name,string department,int salesTarget)
        //{
        //    this.Name = name;
        //    this.Department = department;
        //    this.SalesTarget = salesTarget;
        //}

        public  Sales(string name, string department, int salesTarget):base(name,department)
        {
         
            this.SalesTarget = salesTarget;
        }
        public void SSayHello()
        {
            Console.WriteLine("大家好,我是{0}的{1},我的销售目标是{2}",this.Department,this.Name,this.SalesTarget);
        }
    }
}
