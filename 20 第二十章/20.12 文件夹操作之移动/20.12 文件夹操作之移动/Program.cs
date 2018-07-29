using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._12_文件夹操作之移动
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathSource = @"D:\Users\Walker\Desktop\Source\File";
            string pathDestination = @"D:\Users\Walker\Desktop\Destination\File";
            if (Directory.Exists(pathSource))
            {
                try
                {
                    Directory.Move(pathSource, pathDestination);
                    Console.WriteLine("文件夹移动成功！");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("文件夹移动失败，原因是：" + ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("源文件不存在，无法完成移动！");
            }
            Console.Read();
        }
    }
}
