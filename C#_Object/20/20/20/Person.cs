using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Person
    {
        private string name;

        public string Name
        {
            get {
                if (name == "" || name == null) 
                {
                    return "当前名字为空";
                }
                else
                {
                    return name;
                }
            }
            set { name = value; }
        }

        public int Age { get; set; }    //相当于之前的两部分的常规内容~
    }
}
