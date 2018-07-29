using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._7_本章小结及任务实施
{
    public class QQStateIndex
    {
        string[] qqState = { "在线", "离线", "忙碌", "Q我", "隐身" };
        private int getState(string stateText)
        {
            int i = 0;
            foreach (string stateString in qqState)
            {
                if (stateString == stateText) return i;
                i++;
            }
            return -1;
        }
public int this[string stateString]
        {
            get { return getState(stateString); }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            QQStateIndex qs = new QQStateIndex();
            Console.WriteLine(qs["在线"]);
            Console.WriteLine(qs["忙碌"]);
            Console.WriteLine(qs["断线"]);
            Console.ReadKey();
        }
    }
}
