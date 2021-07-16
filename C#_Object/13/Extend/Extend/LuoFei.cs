using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    class LuoFei : Hero
    {
        public LuoFei() { 
        }

        public LuoFei(string m_heroName, string m_heroInfo, int m_attack, int m_defense, int m_speed, string m_nickName) 
            : base(m_heroName, m_heroInfo, m_attack, m_defense, m_speed, m_nickName) { 
        }

        public void NengLiangJingLing() {
            Console.WriteLine("能量精灵");
        }
        public void AnYingChuanShong() {
            Console.WriteLine("暗影传送");
        }
        public void ShiKongBengLie() {
            Console.WriteLine("时空迸裂");
        }
    }
}
