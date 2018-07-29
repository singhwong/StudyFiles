using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2_方法的声明与调用_2_
{
    class Program
    {
        //编写一个方法用于计算给定整型数组元素的和
        static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int outnum in nums) sum += outnum;
            return sum;

        }
        //编写一方法用于求平方(没有返回值)
        //此时的参数传递就叫做值传递
        static void Square(ref int num)
        {
            num *= num;
            Console.WriteLine("num的平方是"+num);
        }
        //编写一个方法,求出数组中最大的值进行返回,并返回最大值的一个索引
        static int MaxNum(int [] nums,out int MaxNumIndex)
        {
            int maxNum = nums[0];
            MaxNumIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (maxNum < nums[i])
                {
                    maxNum = nums[i];
                    MaxNumIndex = i;
                }
            }
            return maxNum;

        }
        static void Main(string[] args)
        {
            //int[] myintArray = { 2,6,5};
            //Console.WriteLine(Add(myintArray));
            //int num ;
            // Console.WriteLine(num);
            // Square(ref num);
            // Console.WriteLine(num);
            int[] myintArray = { 12,3,5,2,5,548,21,8,54,21};
            int MaxNumIndex;
            Console.WriteLine("此数组的最大值是{0},最大值的索引是{1}",MaxNum(myintArray,out MaxNumIndex),MaxNumIndex);
            
            Console.ReadKey();


        }
    }
}
