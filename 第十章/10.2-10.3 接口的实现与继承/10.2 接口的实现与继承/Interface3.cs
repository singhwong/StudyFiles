using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2_接口的实现与继承
{
    interface Interface3:Interface1,Interface2
    {
         new void Write();
        //如果派生接口中对显式基接口中的成员进行重定义时,需要使用new来解除警告
    }
}
