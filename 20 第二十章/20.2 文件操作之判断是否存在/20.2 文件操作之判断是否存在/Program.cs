using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._2_文件操作之判断是否存在
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\users\Walker\Desktop\51zxw.png";
            if(File.Exists(path))
                Console.WriteLine("文件\""+path+"\"存在");
            else Console.WriteLine("文件\""+path+"\"不存在");

            Console.ReadKey();
        }
    }
}
