using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._6_自定义异常类
{
    class MyException:Exception
    {
        public MyException(string message):base(message)
        {

        }
    }
}
