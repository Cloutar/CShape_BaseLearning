using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TimeTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            /*
            string names = "";
            for (int i = 0; i <= 90000; i++) { 
                names += i;
            }
            
            sw.Stop();
            Console.WriteLine(sw.Elapsed);    //7.5885108s 9w
             */

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= 90000; i++) {
                sb.Append(i);
            }

            sw.Stop();
            Console.WriteLine(sw.Elapsed);    //0.0090456s 9w

            Console.ReadKey();
        }
    }
}
