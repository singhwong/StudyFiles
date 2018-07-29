using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._6_Hashtable元素的删除
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(true, "李四");
            ht.Add(false, "王五");
            ht.Add(3, "赵六");
            ht.Add("abcd","何七");

            //ht.Add(false,"MrWang");
            //键是唯一的,不能重复
            foreach (DictionaryEntry myde in ht)
            {
                Console.WriteLine("键为{0}值为{1}",myde.Key,myde.Value);

            }
            ht.Remove(false);//key键
            Console.WriteLine("移除的结果");
            foreach (DictionaryEntry myde in ht)
            {
                Console.WriteLine("键为{0}值为{1}", myde.Key, myde.Value);

            }

            ht.Clear();
            Console.WriteLine("清除的结果");
            foreach (DictionaryEntry myde in ht)
            {
                Console.WriteLine("键为{0}值为{1}", myde.Key, myde.Value);

            }
            Console.Read();
        }
    }
}
