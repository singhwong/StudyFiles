using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1_泛型概述
{
    class Program
    {
        static void Main(string[] args)
        {
            //集合与数组:①长度可以改变②添加数据时,不用考虑数据具体类型 object
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(4);
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });
            list.AddRange(list);
            list.Insert(3, 100);
            list.Reverse();
            for (int i=0;i<list.Count;i++)
                Console.WriteLine(list[i]);
            int [] nums=list.ToArray();
            List<int> ListTwo = nums.ToList();
           
            Console.Read();
        }
    }
}
