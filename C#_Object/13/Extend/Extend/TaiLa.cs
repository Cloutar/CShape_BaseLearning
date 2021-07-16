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
            /**
             * 父类中 public修饰的 字段/属性/方法, 在子类可以访问, 使用base.属性名
             * 
             * 构造方法可以使用private和public进行修饰. 但99%的时候使用public修
             * 饰,只有在使用单例模式的时候才使用private修饰.
             */ 
            //base.test;
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
