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
        //public static string address = "山东";    //静态字段
        public static string address;

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

        public void P1()
        {
            Console.WriteLine("我是普通方法");
        }

        public static void P2()
        {
            //P1();
            Console.WriteLine("我是静态方法");
        }

        static Person()    //静态构造方法
        {
            address = "美国";
        }
    }
}
