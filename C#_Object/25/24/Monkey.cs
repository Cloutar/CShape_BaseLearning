using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    static class Monkey
    {
        private static string name;

        public static string Name
        {
            get { return Monkey.name; }
            set { Monkey.name = value; }
        }

        public static void Hello()
        {
            Console.WriteLine("Hello C#");
        }

        static Monkey()
        {
            name = "静态~";
        }
    }
}
