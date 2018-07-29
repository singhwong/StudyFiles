using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._7_文件操作之删除
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\Walker\Desktop\File\";
            Console.WriteLine("请输入您要删除的文件，回车键确认：");
            string inputstr = Console.ReadLine();
            string pathTemp = path + inputstr;
            if (File.Exists(pathTemp))
            {
                File.Delete(pathTemp);
                Console.WriteLine("文件" + pathTemp + "删除成功");
            }
            else
            {
                Console.WriteLine("文件"+pathTemp+"不存在");
            }
            Console.Read();
        }
    }
}
