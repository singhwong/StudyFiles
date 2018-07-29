using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_接口的声明
{
    public interface IEatable
    {
        //接口默认声明为public  类的默认声明是private
        //属性
       string Name
        {
            get;
            set;
        }
        // 接口中不能有访问修饰符
        //由于接口不能有字段,所以属性经常被写作自动属性.

        //方法
        void Write();
        string Read();
       
        //方法不能包含方法体

        //字段
        //string _name;
    }
}
