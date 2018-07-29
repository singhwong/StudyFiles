using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._8_文件操作之获取基本信息
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\Walker\Desktop\51zxw.txt";
            FileInfo myfileinfo = new FileInfo(path);
            if (myfileinfo.Exists)
            {
                Console.WriteLine("文件的属性：");
                Console.WriteLine(myfileinfo.Attributes.ToString());
                Console.WriteLine("文件的扩展名：");
                Console.WriteLine(myfileinfo.Extension.ToString());
                Console.WriteLine("全路径为：");
                Console.WriteLine(myfileinfo.FullName.ToString());
                Console.WriteLine("要查看的名称：");
                Console.WriteLine(myfileinfo.Name.ToString());
                Console.WriteLine("文件的创建时间：");
                Console.WriteLine(myfileinfo.CreationTime.ToString());
                Console.WriteLine("文件的上次访问时间：");
                Console.WriteLine(myfileinfo.LastAccessTime.ToString());
                Console.WriteLine("文件上次的修改时间 ：");
                Console.WriteLine(myfileinfo.LastWriteTime.ToString());
                Console.WriteLine("文件所在的文件夹为：");
                Console.WriteLine(myfileinfo.Directory.ToString());
                Console.WriteLine(myfileinfo.DirectoryName.ToString());
                Console.WriteLine("文件是否可读：");
                Console.WriteLine(myfileinfo.IsReadOnly);
                Console.WriteLine("文件的大小为：");
                Console.WriteLine(myfileinfo.Length.ToString()+"字节");
            }
            else
            {
                Console.WriteLine("文件"+path+"不存在!!");
            }
            Console.ReadKey();

        }
    }
}
