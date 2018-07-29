using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3_引发异常
{
    class Program
    {
        private static int ConvertStringToInt(string mystr)
        {
            int outnum = 0;
            try
            {
                outnum = Convert.ToInt32(mystr);
                return outnum;
            }
            catch
            {
                throw new FormatException("格式转换不正确(由我要自学网制作)");
            }
        }
        static void Main(string[] args)
        {
            string mystr = "51";
            try
            {
                int myint;
                myint = Program.ConvertStringToInt(mystr);
                Console.WriteLine(myint);
            }
            catch(FormatException exf)
            {
                Console.WriteLine(exf.Message.ToString());
            }
            Console.ReadKey();

        }
    }
}
