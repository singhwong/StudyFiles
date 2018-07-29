using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._9_文件夹操作之判断是否存在
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\Walker\Desktop\51zxw";
            if (Directory.Exists(path))
                Console.WriteLine("文件夹" + path + "夹存在");
            else
                Console.WriteLine("文件夹"+path+"不存在");
            Console.Read();

        }
    }
}
