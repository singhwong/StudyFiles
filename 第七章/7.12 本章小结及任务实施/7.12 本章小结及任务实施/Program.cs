using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._12_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入6个整数,我们将对它进行排序:");
            int[] myintArray=new int[6] ;
            for (int i = 0; i < myintArray.Length; i++) myintArray[i]=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("您输入的数字为:");
            foreach (int outint in myintArray) Console.WriteLine(outint+"\t");

            Console.WriteLine("降序排序 为:");
            for (int i = 0; i < myintArray.Length - 1; i++)
            {
                int temp;
                for (int j = 0; j < myintArray.Length - 1 - i; j++)
                {

                    //降序排列
                    if (myintArray[j] < myintArray[j + 1])
                    {
                        temp = myintArray[j];
                        myintArray[j] = myintArray[j + 1];
                        myintArray[j + 1] = temp;

                    }
                }

            }

            //遍历
            foreach (int outint in myintArray) Console.Write(outint+"\t");
            Console.WriteLine();


            Console.WriteLine("升序排列为:");

            for (int i = 0; i < myintArray.Length - 1; i++)
            {
                int temp;
                for (int j = 0; j < myintArray.Length - 1 - i; j++)
                {

                    //升序排列
                    if (myintArray[j]>myintArray[j + 1])
                    {
                        temp = myintArray[j];
                        myintArray[j] = myintArray[j + 1];
                        myintArray[j + 1] = temp;

                    }
                }

            }

            //遍历
            foreach (int outint in myintArray) Console.Write(outint + "\t");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
