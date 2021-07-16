using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            UDisk u1 = new UDisk("金士顿32GB");
            HardDisk h1 = new HardDisk("三星500GB");

            Computer c1 = new Computer("联想");
            c1.Start();
            c1.USB_1 = u1;    //接口定义好后可以当作数据类型使用   ---   里氏转换的思想
            c1.USB_1.Write("这个");
            c1.USB_1.Write("太牛逼了");
            c1.USB_1.Read();
            c1.End();

            c1.USB_2 = h1;
            c1.USB_2.Write("真的");
            c1.USB_2.Write("厉害");
            c1.USB_2.Read();

            Console.WriteLine();

            Computer c2 = new Computer("戴尔");
            c2.Start();
            c2.End();

            Console.ReadKey();
        }
    }
}
