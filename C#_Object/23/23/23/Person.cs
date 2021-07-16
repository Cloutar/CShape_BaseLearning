using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Person
    {
        //private string name;
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Hello()
        {
            Console.WriteLine(Name);
            Console.WriteLine("我是父类中的Hello方法");
        }
    }
}
