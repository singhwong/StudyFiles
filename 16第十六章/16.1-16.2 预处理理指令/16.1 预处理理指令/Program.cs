#define Debug
#define Release
#undef Debug
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._1_预处理指令
{
    class Program
    {


        static void Main(string[] args)
        {
            #region  此处主要讲解#if #elif #else #endif
#if Debug && Release == false
      
            Console.WriteLine("只存在调试版本");
#elif Debug && Release
#error "调试版本与发布版本不能同时定义"
            //Console.WriteLine("同时存在两个版本,这是不被允许");
#elif (!Debug) && Release
            Console.WriteLine("只存在发布版本");
#else
Console.WriteLine("两个版本都不存在,什么也没有");

#endif
            #endregion
            #region A
            //#line 200
            //#warning "最后不要忘了把这段语句去掉"
            //#warning "test"
            //#line default
            //#warning "test"

            //#warning "test"

            Console.WriteLine("I hate my boss");
            //#if Release


            //            Console.WriteLine("发布版本");


            //#endif
            #endregion
#pragma warning disable 0219

#pragma warning restore
            int a = 0;
            int b = 10;
            int[] myint;
            Console.WriteLine(b);
            Console.ReadKey();

        }
    }
}
