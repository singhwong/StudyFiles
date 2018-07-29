using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _17._5_正则表达式的替换
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Welcome to www.51zxw.net WWW.51zxw.net WwW.51ZXw.net";
            string pattern = @"\bw{3}\.\w+\.(com|net|org)\b";
            string replacement = "\n"+@"http:\\$&".ToLower();
            Console.WriteLine("替换前的字符串:"+input);
            Console.WriteLine("替换后的字符串1:"+Regex.Replace(input,pattern,replacement,RegexOptions.IgnoreCase));
            Console.WriteLine("替换后的字符串2:"+Regex.Replace(input,"www.","\n"+@"http:\\www.",RegexOptions.IgnoreCase));

            Regex myregex = new Regex(pattern,RegexOptions.IgnoreCase);
            string result = myregex.Replace(input,replacement);
            Console.WriteLine("替换后的字符串3:"+result);


            Console.ReadKey();
        }
    }
}
