using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    class AiLuoKe : Hero
    {

        public AiLuoKe() { 
        }

        public AiLuoKe(string m_heroName, string m_heroInfo, int m_attack, int m_defense, int m_speed, string m_nickName) 
            : base(m_heroName, m_heroInfo, m_attack, m_defense, m_speed, m_nickName) { 
        }

        public void ShuishiDaJi()
        {
            Console.WriteLine("碎石打击");
        }

        public void LieYanMaoGou()
        {
            Console.WriteLine("烈焰锚钩");
        }

        public void ZhanHuoPaoXiao()
        {
            Console.WriteLine("战火咆哮");
        }
    }
}
