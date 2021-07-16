using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Person
    {
    #region 字段
        private string name;
        private int age;
        private string address;
    #endregion

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        #region 构造方法

        //public Person(string name, int age, string address)
        //{
        //    this.name = name;
        //    this.age = age;
        //    this.address = address;
        //}



        #endregion

        public void Hello()
        {
            Console.WriteLine("大家好好");
        }

        public override string ToString()
        {
            //没有console.writeLine时候的格式化输出
            return string.Format("{0}--{1}--{2}", name, age, address);
        }
    }
}
