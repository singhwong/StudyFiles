using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
  public  class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get
            {
                if (_age < 0 || _age > 100) return _age = 0;

                    return _age;}
            set {
               
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            set {
                if (_gender != '男' && _gender != '女') value = '男';
                _gender = value; }
            get { return _gender; }
        }
        public void CHLSS()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了,我是{2}生,我可以吃喝拉撒睡哟!!",this.Name,this.Age,this.Gender);
        }

    }
}
