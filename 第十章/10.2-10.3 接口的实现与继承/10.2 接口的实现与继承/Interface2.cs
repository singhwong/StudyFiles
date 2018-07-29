using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_接口的实现与继承
{
    interface Interface2
    {
        void Write();
        //不同的接口(不包含派生)中允许有同名的成员;
       // string Read
       // { get; set; }
        //同一接口中成员名不成重名,即使类型不同
    }
}
