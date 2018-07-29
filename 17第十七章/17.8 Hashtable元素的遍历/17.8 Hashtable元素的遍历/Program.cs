using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _17._8_Hashtable元素的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(4, "张三");
            ht.Add(2, "李四");
            ht.Add(3, "王五");
            ht[4] = "赵六";

          foreach(DictionaryEntry myobj in ht)
                Console.WriteLine("键为:{0};值为:{1}",myobj.Key,myobj.Value);
            Console.WriteLine("=========================================");
          foreach(object myobj in ht.Keys)
                Console.WriteLine("键为:{0};值为:{1}",myobj,ht[myobj]);
            Console.Read();
        }
    }
}
