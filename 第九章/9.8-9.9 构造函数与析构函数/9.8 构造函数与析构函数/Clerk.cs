using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8_构造函数与析构函数
{
    public enum Gender
    {
        男,
        女
    }


    class Clerk
    {


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private Gender _gender;

        public Gender Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }
        private string _department;

        public string Department
        {
            get
            {
                return _department;
            }

            set
            {
                _department = value;
            }
        }

        public void Write()
        {
            Console.WriteLine("我叫{0},我是{1}生,我{2}岁了,在{3}任职",this.Name,this.Gender,this.Age,this.Department);
        }
        public void Write2()
        {
            Console.WriteLine("我叫{0},我是{1}生,我{2}岁了", this.Name, this.Gender, this.Age);
        }

        public Clerk(string name,Gender gender,int age,string department)//构造函数

        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Department = department;
        }

        public Clerk(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        public Clerk()
        {

        }
        //如果系统中没有指定析构函数,那么编译器由GC来决定什么时候进行释放资源
        //Garbage Collection
        ~Clerk()
        {
            Console.WriteLine("我是析构函数,看我什么时候调用.");
            //在使用完当前类的时候会调用它
        }

    }
}
