using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    interface IFly
    {
        //接口中不能包含字段
        //private string name;

        //接口中的方法不能有方法体, 不能有访问修饰符(默认是public)
        void Fly();
    }
}
