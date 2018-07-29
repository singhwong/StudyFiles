using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._13_文件夹操作之获取指定目录下文件及文件夹
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\Walker\Desktop\51zxw";
            if (Directory.Exists(path))
            {
                string[] Files = Directory.GetFiles(path);
                string[] Folders = Directory.GetDirectories(path);
                Console.WriteLine("该指定目录下方有以下内容：");
                foreach (string str in Folders)
                    Console.WriteLine(str);
                foreach (string str in Files)
                    Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("指定的目录不存在");
            }
            Console.Read();
        }
    }
}
