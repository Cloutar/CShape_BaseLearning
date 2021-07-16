using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    /// <summary>
    /// 外部类
    /// </summary>
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Hello()
        {
            Console.WriteLine("Person类.");
        }


        /// <summary>
        /// 嵌套类
        /// </summary>
        public class Web
        {
            public string webName;
            public string webUrl;

            public void Show()
            {
                Console.WriteLine("{0}:{1}", this.webName, this.webUrl);
            }
        }


    }
}
