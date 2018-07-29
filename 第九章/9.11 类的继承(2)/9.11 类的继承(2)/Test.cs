using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._10_类的继承
{
    //假如我们不希望test作为一个父类
    //那我们使用关键字sealed
   sealed class  Test
    {
        private string _ttest;

        public string TTest
        {
            get
            {
                return _ttest;
            }

            set
            {
                _ttest = value;
            }
        }
    }
}
