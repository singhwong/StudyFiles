using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8_数组的拆分与合并
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 0,1,2,3,4,5,6,7,8,9};
            int[] num2 = { 10,11,12,13,14,15,16,17,18,19};
            Console.WriteLine("原数组num1是:");
            foreach (int outnum in num1) Console.Write(outnum+"\t");
            Console.WriteLine("原数组num2是:");
            foreach (int outnum in num2) Console.Write(outnum+"\t");
            int[] resultNum=new int[20];
            //Array.Copy(num1,resultNum,5);//将num1中的元素从索引值0开始,取5个长度放入到resultNum中,从索引值为0开始存放
            //Console.WriteLine("存放后的结果");
            //foreach (int outint in resultNum) Console.Write(outint+"\t");
            Array.Copy(num1,resultNum,10);
            Array.Copy(num2,0, resultNum,10, 10);
            //从num2索引值从0开始取10个长度,放入到resultNum中,并从索引值10开始进行存放

            Console.WriteLine("合并的结果");
           foreach (int outint in resultNum) Console.Write(outint+"\t");
            int[] resultNum2 = new int[7];
            Array.Copy(resultNum,11,resultNum2,0,7);
            Console.WriteLine("拆分后的结果");
            foreach (int outint in resultNum2) Console.Write(outint+"\t");


            Console.ReadKey();
        }
    }
}
