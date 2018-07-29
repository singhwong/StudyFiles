using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _17._6_正则表达式的拆分
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "一、张三 二、李四 三、王五 四、赵六 五、何七";
            string pattern = @"\b[一二三四五]、";
            foreach (string outstr in Regex.Split(input, pattern))
            {
               if(!String.IsNullOrEmpty(outstr)) Console.WriteLine(outstr);

            }
            Console.Read();
        }
    }
}
