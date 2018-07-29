using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5_类的声明
{
    public enum Gender
    {
        男,
        女
    }
    class Clerk
    {

        //方法中可以存放字段,可以存放属性,还可以存放方法
        public string _name;//字段,命名规范,_camelCase
        //字段,可以存放在多个值,变量只能存放一个值.字段用来存放数据
        public Gender _gender;
        public int _age;
        public string _department;
        public int _workYears;
        //静态方法只能调用静态成员
        //非静态方法可以调用任何成员
        public void Write()
        {
            Console.WriteLine("我叫{0},我是{1}生,我{2}岁了,我在{3}任职,我工作了{4}年",this._name,this._gender, this._age, this._department, this._workYears);

        }



    }
}
