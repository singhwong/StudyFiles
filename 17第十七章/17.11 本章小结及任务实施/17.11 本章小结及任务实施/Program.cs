using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace _17._11_本章小结及任务实施
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "我爱你，我的中国。我喜欢我要自学网";
            string pattern = @"[^\u4e00-\u9fa5]";
            Regex regex = new Regex(pattern);
            string chnstr = regex.Replace(str,"");
            Hashtable ht = new Hashtable();
            for (int i = 0; i < chnstr.Length; i++)
            {
                int val = 1;
                if (ht.ContainsKey(chnstr[i]))
                {
                    val = Convert.ToInt32(ht[chnstr[i]]);
                    ++val;
                }
                ht[chnstr[i]] = val;
            }
            Console.WriteLine("原有的字符串是"+str);
            foreach (DictionaryEntry de in ht)
            {

                Console.WriteLine("{0}-------{1}",de.Key,de.Value);
            }
            Console.Read();
        }
    }
}
