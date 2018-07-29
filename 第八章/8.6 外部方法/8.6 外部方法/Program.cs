using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _8._6_外部方法
{

    //方法位置:通常类当中,并且与其他方法保持平级关系 
    class Program
    {
        //使用之前应该引入命名空间:System.Runtime.InteropServices
        [DllImport("User32.dll")]
        //声明外部方法 使用关键字extern由于配合DLLImport属性使用,所以必须包含static关键字
        public static extern int MessageBox(int h,string m,string c,int type);
        static int Main(string[] args)
        {
            Console.Write("请输入您的姓名:");
            string name = Console.ReadLine();
            //利用return进行弹出对话框,所以需要将Main方法改为有返回值
            return MessageBox(0,"您好:"+name+"\n\n"+"欢迎来到我要自学网","欢迎提示",0);
        }
    }
}
