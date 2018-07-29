using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10_类的继承
{
   internal class Clerk
    {
        protected string myTest;
        //允许在当前类及其派生类中进行访问与调用

        //类成员默认为private,一般我们为便于识别,人为在前面加上private,加与不加意义一样
        private string _name;
        //private由于私有,不能被子类访问
        internal string Name
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
        //构造函数
        //子类中不能继承父类中的构造函数,但是会默认地调用父类中的无参的构造函数
        //两种方法
        //1)在父类中再写一个无参的构造函数,在每个子类当中都需要再进行一次构造函数的重写与各个字段的初始化
        //2)使用关键字:base()

        public Clerk(string name,string department)
        {
            this.Name = name;
            this.Department = department;
        }
        //public Clerk()
        //{

        //}
        public void CSayHello()
        {
            Console.WriteLine("大家好,我是{0}的{1}",this.Department,this.Name);
        }
    }
}
