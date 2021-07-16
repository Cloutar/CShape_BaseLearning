using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AiLuoKe mk = new AiLuoKe("Monkey");
            mk.Hello();
            mk.LieYanMaoGou();
            mk.ShuiShiDaJi();
            mk.ZhanHuoPaoXiao();

            TaiLa mk_2 = new TaiLa("lkk");
            mk_2.Hello();

            Console.ReadKey();
        }
    }
}
