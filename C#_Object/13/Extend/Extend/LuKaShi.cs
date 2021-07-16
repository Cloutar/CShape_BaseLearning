using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    class LuKaShi : Hero 
    {
        public LuKaShi() { 
        }

        public LuKaShi(string m_heroName, string m_heroInfo, int m_attack, int m_defense, int m_speed, string m_nickName) 
            : base(m_heroName, m_heroInfo, m_attack, m_defense, m_speed, m_nickName) { 
        }

        public void JianShuXianJing() {
            Console.WriteLine("减速陷阱");
        }

        public void NengLiangLangChao() {
            Console.WriteLine("能量浪潮");
        }

        public void XuanFengJianWu() {
            Console.WriteLine("旋风剑舞");
        }
    }
}
