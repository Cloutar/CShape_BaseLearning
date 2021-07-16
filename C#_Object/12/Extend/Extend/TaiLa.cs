using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    class TaiLa : Hero
    {
        public TaiLa() { 
        }

        public TaiLa(string m_heroName, string m_heroInfo, int m_attack, int m_defense, int m_speed, string m_nickName) 
            : base(m_heroName, m_heroInfo, m_attack, m_defense, m_speed, m_nickName) { 
        }

        public void JuLangChongJi() {
            Console.WriteLine("巨浪冲击");
        }

        public void YuanShuTuJi() {
            Console.WriteLine("元素突击");
        }

        public void FuChouShaLu() {
            Console.WriteLine("复仇杀戮");
        }
    }
}
