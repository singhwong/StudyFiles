using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _15._6_StreamWriter类
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\Walker\Desktop\51zxw\51zxw.txt";
            //操作文件路径的定义
            try
            {
                ////第一种方式
                //FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                //StreamWriter sw = new StreamWriter(fs);
                //第二种方式
                StreamWriter sw = new StreamWriter(path,false);

                string mystr = "学习C#既轻松又快乐！";
                sw.WriteLine(mystr);
                sw.Close();
                Console.Write("写入完成");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("操作失败，原因为" + ex.ToString());

            }
            Console.Read();
        }
    }
}
