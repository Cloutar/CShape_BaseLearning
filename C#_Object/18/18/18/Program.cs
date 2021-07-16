using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskNPC npc1 = new TaskNPC("去野外挖2根萝卜", "小白兔", NPCType.Task);
            npc1.Speak();

            ShopNPC npc2 = new ShopNPC("喜羊羊", "灰太狼", NPCType.Shop);
            npc2.Speak();

            Console.ReadKey();
        }
    }
}
