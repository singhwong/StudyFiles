using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._10_文件夹操作之创建文件夹
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\Walker\Desktop\51zxw\1";
            if (Directory.Exists(path))
            {
                Console.WriteLine("文件夹存" + path + "在，无需创建！");
            }
            else
            {

                try
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("文件夹" + path + "创建成功！！");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("创建失败，原因是："+ex.ToString());
                }
              
            }
            Console.Read();
        }
    }
}
