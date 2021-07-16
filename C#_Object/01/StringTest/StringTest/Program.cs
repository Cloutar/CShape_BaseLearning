using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Monkey";
            Console.WriteLine("ToUpper: " + name.ToUpper());
            Console.WriteLine("ToLower: " + name.ToLower());

            string name_2 = "lkk";
            Console.WriteLine("Equals: " + name.Equals(name_2));

            string address = "中国|北京|海淀|上地";
            char[] c = new char[] { '|' };
            string[] ad = address.Split(c);
            for (int i = 0; i < ad.Length; i++) {
                Console.WriteLine(ad[i]);
            }

            Console.WriteLine("Substring: " + name.Substring(2));
            Console.WriteLine("Substring: " + name.Substring(2, 2));

            Console.WriteLine("IndexOf: " + name.IndexOf("k"));
            Console.WriteLine("LastIndexOf: " + name_2.LastIndexOf("k"));

            Console.WriteLine("StartsWith: " + name.StartsWith("Mon"));
            Console.WriteLine("EndsWith: " + name.EndsWith("key"));

            Console.WriteLine("Replace: " + name.Replace("Mon", "lkk"));

            Console.ReadKey();
        }
    }
}
