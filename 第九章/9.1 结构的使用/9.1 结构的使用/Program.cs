using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_结构的使用
{
    //最好将结构声明于此位置,因为所有的类都可以访问
    public struct Clerk
    {
        //声明变量
        //将此处的变量声名为pulic
       public  string name;
        public int age;
        public string department;
        public char gender;
    }


    class Program
    {

        static void Main(string[] args)
        {
            //来了一个张三,李四
            //姓名,年龄,部门
            //string zsName = "张三";
            //int zsAge = 25;
            //string zsDepartment = "人力部";
            ////李四
            //string lsName = "李四";
            //int lsAge = 35;
            //string lsDepartment = "财务部";
            //如果有1000名员职员,这时候就需要声明3000个变量.需要声明1000个就可以解决
            //int myint = 100;
            //变量类型 变量名;
            Clerk zs = new Clerk();
            zs.name = "张三";
            zs.age = 25;
            zs.department = "人力部";
            zs.gender = '男';
            Console.WriteLine("我叫{0},我的年龄是{1}岁,我在{2}工作,我是{3}生",zs.name,zs.age,zs.department,zs.gender);
            Console.ReadKey();

        }
    }
}
