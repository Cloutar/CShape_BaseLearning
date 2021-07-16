using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * C#属性
             * 
             * 1 常规属性
             * 
             * 2 自动属性
             * 在某些情况下, 属性get和set只是完成字段的取值和赋值操作, 而不包含
             * 任何附加的逻辑代码, 这个时候可以使用自动属性.
             * 例子: public int Age { get; set; }
             * 
             * 在接口中使用属性, 就要写自动属性的格式, 因为接口中不支持字段
             * 
             */

            //Person p = new Person();
            //p.Name = "小张";
            //p.Age = 100;
            //Console.WriteLine(p.Name);
            //Console.WriteLine(p.Age);

            UDisk u = new UDisk();
            u.Write();
            u.Read();

            HardDisk h = new HardDisk();
            h.Write();
            h.Read();

            Console.ReadKey();
        }
    }
}
