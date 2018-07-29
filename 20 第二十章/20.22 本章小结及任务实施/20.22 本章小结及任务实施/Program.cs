using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._22_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            //思路：先将要复制的多媒体文件读取出来，然后再写入到你指定的位置
            string source = @"D:\Users\Walker\Desktop\Source\new.mp4";
            string target = @"D:\Users\Walker\Desktop\Target\51zxw.mp4";
            CopyFile(source, target);
            Console.WriteLine("多媒体文件被复制成功");
            Console.ReadKey();

        }

        public static void CopyFile(string source, string target)
        {
            //1.创建一个负责读取的流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                //2.创建一个负责写入的流
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {

                    //多媒体文件可能会比较大，所以我们在读取的时候应该通过一个循环去读取
                    byte[] buffer = new byte[1024*1024*5];
                    while (true)
                    {
                        //返回本次读取取实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //如果返回一个0，就意味着什么也没有读取到，也就是读取完成
                        if (r == 0) break;
                        fsWrite.Write(buffer,0,r);

                    }


                }
            }

        }

    }
}
