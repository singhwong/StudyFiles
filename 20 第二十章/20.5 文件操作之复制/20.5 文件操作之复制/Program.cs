using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._5_文件操作之复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathSource = @"D:\Users\Walker\Desktop\Source\51zxwNew.txt";
            string pathDestination = @"D:\Users\Walker\Desktop\Destination\51zxwCopy.txt";
            if (File.Exists(pathSource))
            {
                try
                {
                    if (!File.Exists(pathDestination))
                    {
                        File.Copy(pathSource, pathDestination, false);
                        Console.WriteLine("文件复制成功");
                    }
                    else
                    {
                        Console.WriteLine("是否进行覆盖操作：\n1.覆盖\n2.取消复制\n输入选项对应的数字");
                        string mystr = Console.ReadLine();
                        if (mystr == "1")
                        {
                            File.Copy(pathSource, pathDestination, true);
                            Console.WriteLine("复制文件已覆盖同名文件");
                        }
                        else if (mystr == "2")
                        {
                            Console.WriteLine("用户取消了该复制，原因是存在同名的文件");
                        }
                        else
                        {
                            Console.WriteLine("用户未选择任何复制选项，复制不成功！");
                        }

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("复制失败，原因是："+ex.ToString());
                }
            }
            else
            {
                Console.WriteLine("源文件没有找到，请确认后再进行复制！");
            }
            Console.Read();
        }
    }
}
