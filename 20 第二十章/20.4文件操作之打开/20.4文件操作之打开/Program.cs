using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20._4文件操作之打开
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Users\Walker\Desktop\51zxw.txt";
            try
            {
                FileStream txtFile = File.Open(path,FileMode.Truncate);
                byte[] byteWrite = { (byte)'5', (byte)'1', (byte)'z', (byte)'x', (byte)'w', (byte)'.', (byte)'n', (byte)'e', (byte)'t' };
                txtFile.Write(byteWrite,0,byteWrite.Length);
                txtFile.Close();
                Console.WriteLine("打开成功！");
            }

            catch (Exception ex)
            {
                Console.WriteLine("打开失败，原因是："+ex.ToString());
            }
            Console.Read();
        }
    }
}
