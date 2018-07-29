using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._6_属性的使用
{
    class Clerk
    {
        //类中可以存放的成员:
        //字段:采用_camelCase命名方式
        //属性:采用PascalCase命名方式
        //方法
        public private _name;
        public string Name
        {
            get;
            set;//自动属性
        }
        private char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' || _gender != '女') _gender = '男';
                return _gender;
            }
            set
            { _gender = value; }

        }
        private int _age;
        //通常我们将get与set称为访问器
        //属性分为4种
        //1)既读又写 同时包含get与set
        //2)只读 只包含get
        //3)只写 只包含set
        //4)自动  get;set;
        public int Age
        {
            get//get 可以用于对取值进行限定 _age

            {
                return _age;
            }
            set//set可用于对赋值进行限定 value

            {
                if (value < 0 || value > 120) value = 0;
                _age = value;

            }
        }
        //有了属性以后,我们往往都会通过属性来访问字段
        //打一个比方说:属性是男人,负责外部事务;字段是女人,负责内部事务.
        //属性通常声明为public 字段声明private
        //在外部访问类中的字段,都是通过属性来实现的
        private string _department;
        public string Department
        {
            get;
            set;
        }

        private int _workyears;
        public string Workyears
        {
            get;
            set;
        }

        public void Write()
        {
            Console.WriteLine("我叫{0},我是{1}生,我今年{2}岁了,我任职于{3},已经工作了{4}年",this.Name,this.Gender,this.Age,this.Department,this.Workyears);

        }

    }
}
