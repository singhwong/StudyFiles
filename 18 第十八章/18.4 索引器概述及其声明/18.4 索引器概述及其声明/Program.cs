using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._4_索引器概述及其声明
{
    public class Clerk
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private char gender;
        public char Gender
        {

            get
            {
                if (gender != '男' && gender != '女') gender = '男';
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        private int[] myint = new int[10];
        //public int this[int index]
        //{
        //    get { return myint[index]; }
        //    set { myint[index] = value; }
        //}
        //public virtual int this[int index]
        //{
        //    get { return myint[index]; }
        //}

        public extern int this[int index]
        { get; set; }

    }

    abstract class indexEaxmple
    {

        public abstract int this[int index]
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
