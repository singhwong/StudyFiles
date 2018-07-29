using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._15_文件操作FileStream类
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bufferByte = new byte[100];
            char[] bufferChar = new char[100];
            string path = @"D:\Users\Walker\Desktop\51zxw\51zxw.txt";
            try
            {
                FileStream fs = new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite);
                // //File
                // FileStream fs1 = File.OpenRead(path);
                // //FileInfo
                // FileInfo fs2 = new FileInfo(path);
                //FileStream fs3 = File.OpenRead(path);
                fs.Seek(0,SeekOrigin.Begin);
                fs.Read(bufferByte,0,100);
                Decoder dc = Encoding.UTF8.GetDecoder();
                dc.GetChars(bufferByte, 0, bufferByte.Length, bufferChar, 0);
                Console.WriteLine(bufferChar);
                Console.WriteLine("完成读取");
                bufferChar = "我要自学网是一个神奇的网站".ToCharArray();
                Encoder en = Encoding.UTF8.GetEncoder();
                en.GetBytes(bufferChar,0,bufferChar.Length,bufferByte,0,true);
                fs.Seek(0,SeekOrigin.Begin);
                fs.Write(bufferByte,0,bufferByte.Length);
                fs.Close();
                Console.WriteLine("写入正常");

                Console.ReadKey();


            }
            catch(Exception ex)
            {
                Console.WriteLine("操作失败，原因是"+ex.ToString());
            }
        }
    }
}
