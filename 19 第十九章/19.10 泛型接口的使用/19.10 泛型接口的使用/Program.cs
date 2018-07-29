using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._10_泛型接口的使用
{
    public interface IMyinterface { }
    public interface IMyinterface<T> { }
    public interface IMyinterface<T1, T2> { }

    public interface IRelation<T1, T2>
    {
        int Forward(T1 forward);
        int After(T2 after);
        T1 GetForward(int index);

        void GetAfter(int index, out T2 after);
        void change(ref T1 forward, ref T2 after);

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
