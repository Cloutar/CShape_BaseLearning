using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    class Person
    {
        public string name;                       //普通字段
        public static string address = "山东";    //静态字段

        public string Name                  //普通属性
        {
            get { return name; }
            set { name = value; }
        }

        public static string Address                  //静态属性
        {
            get { return address; }
            set { address = value; }
        }
    }
}
