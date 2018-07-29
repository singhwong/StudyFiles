using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._3_文件操作之创建
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string path = @"D:\Users\Walker\Desktop\";
            //    FileStream newtext = File.Create(path + "51zxw.txt");
            //    newtext.Close();
            //    Console.WriteLine("文件创建成功！");

            //}

            //catch(Exception ex)
            //{
            //    Console.WriteLine("文件创建失败！原因是："+ex.ToString());
            //}

            string path = @"D:\Users\Walker\Desktop\";
            if (!File.Exists(path + "51zxw.txt"))
            {
                FileStream newtext = File.Create(path + "51zxw.txt");
                newtext.Close();
                Console.WriteLine("文件创建成功！");
            }
            else Console.WriteLine("文件已经存在");

            Console.ReadLine();
        }
    }
}
