using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendDemo
{
    class Program
    { 
        static void Main(string[] args)
        {
            /**
             * 抽象的前提: 这一堆类, 他们必须是"同一类事物", 有共性才可以向上抽取
             */

            Tiger t = new Tiger();
            t.Leg = 4;
            t.Sleep();
            t.Walk();
            t.YSNL();

            Console.WriteLine("------------------------------------");

            Cat c = new Cat();
            c.Leg = 4;
            c.Sleep();
            c.Walk();
            c.Cry();
            c.ZhuaLaoShu();

            Console.WriteLine("------------------------------------");

            Eagle e = new Eagle();
            e.Leg = 2;
            e.Sleep();
            e.Cry();
            e.Fly();

            Console.WriteLine("------------------------------------");

            Swallow s = new Swallow();
            s.Leg = 2;
            s.Sleep();
            s.Cry();
            s.Fly();
            s.WangNanFei();



            Console.ReadKey();
        }
    }
}
