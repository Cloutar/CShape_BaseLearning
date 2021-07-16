using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class ShopNPC : NPC
    {
        private string item;

        public ShopNPC(string item, string name, NPCType type)
            : base(name, type)
        {
            this.item = item;
        }

        public override void Speak()
        {
            Console.WriteLine("NPC{0},贩卖{1}商品", base.Name, this.item);
        }
    }
}
