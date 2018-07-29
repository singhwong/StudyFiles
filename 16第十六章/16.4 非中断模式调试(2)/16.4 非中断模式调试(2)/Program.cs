using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _16._4_非中断模式调试_2_
{
    class Program
    {
        public static void MultiplicationTable()
        {
            Console.WriteLine("乘法表");
            Trace.WriteLine("将要打印出乘法表");
            for (int i = 1; i < 10; i++)
            {
               Trace.WriteLine("确定乘法表中第"+i+"行","行数");
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("{0}×{1}={2,2}\t",j,i,i*j);
                }
                Console.WriteLine();
            }
            Debug.WriteLine("乘法表输出完毕");
        }
        static void Main(string[] args)
        {

            //Console.WriteLine("非中断模式下的调试");
            Debug.WriteLine("下面开始调用乘法表方法");
            MultiplicationTable();
           Debug.WriteLine("乘法表方法调用成功");
            Console.ReadKey();

        }
    }
}
