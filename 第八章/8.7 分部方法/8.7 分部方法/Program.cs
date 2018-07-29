using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._7_分部方法
{
    
    public partial class Program
    {
        //分部方法必须在分部类或分部结构中进行声明和定义
        //声明分部方法
        //方法默认为私有,也可以人为加上private
        partial void Write();//声明
        partial void Write()//分部方法定义
        {
            Console.WriteLine("这是一个分部方法");
        }
    }
   public partial class Program
    {
        static void Main(string[] args)
        {

            //调用分部方法
            Program p = new Program();
            p.Write();
            Console.ReadKey();
        }
    }
}
