using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._11_文件夹操作之删除
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\Walker\Desktop\51zxw";
            if (Directory.Exists(path))
            {
                Console.WriteLine("该文件夹存在，请选择删除方式：\n1.仅当空文件夹时删除；\n2.删除整个目录\n输入选项数字按回车键确认删除！");
                string mystr = Console.ReadLine();
                if (mystr == "1")
                {
                    Directory.Delete(path, false);
                    Console.WriteLine("当前文件夹为空文件夹，已删除");
                }
                else if (mystr == "2")
                {
                    Directory.Delete(path, true);
                    Console.WriteLine("当文件文件夹含有子文件或子文件夹， 已删除");
                }
                else
                {
                    Console.WriteLine("您没有选择正确的操作");
                }
            }
            else
            {
                Console.WriteLine("文件夹"+path+"不存在，无需删除");
            }
            Console.ReadKey();
        }
    }
}
