using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._17_StreamReader类
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\System32\drivers\etc\hosts";
            string myline = "";
            if (File.Exists(path))
            {
                //using(){}自动帮助我们释放流所占用的空间
                //（）创建过程
                //{}读取或写入的过程
                //均不能加分号
                using (StreamReader sr = new StreamReader(path))
                {
                    myline = sr.ReadLine();
                    while (myline != null)
                    {
                        Console.WriteLine(myline);
                        myline = sr.ReadLine();
                    }
                }

            }
            else
            {
                Console.WriteLine("文件不存在");
            }
            Console.ReadLine();
        }
    }
}
