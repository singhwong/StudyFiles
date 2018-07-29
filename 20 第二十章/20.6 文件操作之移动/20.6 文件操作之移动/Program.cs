using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _20._6_文件操作之移动
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathSource = @"D:\Users\Walker\Desktop\Source\51zxw.txt";
            string pathDestination = @"D:\Users\Walker\Desktop\Destination\51zxw.txt";
            if (File.Exists(pathSource))
            {
                try
                {
                    if (!File.Exists(pathDestination))
                    {
                        File.Move(pathSource, pathDestination);
                        Console.WriteLine("文件移动成功，被移至\"" + pathSource + "\"");
                    }
                    else
                    {
                        Console.WriteLine("已存在同名的文件，是否覆盖？\n1.覆盖\n2.取消移动\n输入数字进行选择");
                        string mystr = Console.ReadLine();
                        if (mystr == "1") Console.WriteLine("文件重名，需要进行修改名称");
                        else if (mystr == "2") Console.WriteLine("用户消了操作");
                        else Console.WriteLine("用户没有进行正确的选择");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("移动失败：原因是："+ex.ToString());
                }

            }
            else
            {
                Console.WriteLine("移动的文件不存在，请确认后再运行程序！");
            }
            Console.Read();
        }
    }
}
