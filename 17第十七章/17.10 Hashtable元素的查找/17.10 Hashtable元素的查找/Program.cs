using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace _17._10_Hashtable元素的查找
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, "李四");
            ht.Add(3, "王五");
            ht.Add(4, "赵六");
            ht[5] = "何七";
            ht[6] = "张三";
            Console.WriteLine("添加的结果");
            foreach(DictionaryEntry myde in ht)
                Console.WriteLine("键为{0}----值为{1}",myde.Key,myde.Value);
            if (ht.ContainsKey(10)) Console.WriteLine("存在键=10");
            else Console.WriteLine("不存在该键");
            if (ht.ContainsValue("张三")) Console.WriteLine("存在值=张三");
            else Console.WriteLine("不存在该值");
            Console.Read();
        }
    }
}
