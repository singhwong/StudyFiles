using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._6_索引器在接口中的使用
{
    public interface ItextIndex
    {
        int this[int index]
        {
            get;
            set;
        }
    }
    class indexText : ItextIndex
    {
        private int[] array = new int[10];
        public int this[int index]
        {
            get { if (index < 0 || index >= 10) return 0;
                else return array[index];
            }
            set { if (index > 0 && index < 10) array[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            indexText Arr = new indexText();
            Arr[-1] = 5;
            Arr[4] = 10;
            Arr[9] = 20;
            Arr[14] = 30;
            for (int i = -1; i < 15; i = i + 5)
            {
                Console.WriteLine("Arr[{0}]={1}",i,Arr[i]);
            }
            Console.Read();
        }
    }
}
