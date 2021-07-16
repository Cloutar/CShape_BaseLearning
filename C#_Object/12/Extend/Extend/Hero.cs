using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    /// <summary>
    /// Hero类, 所有英雄的父类
    /// </summary>
    class Hero
    {
        private string heroName;
        private string heroInfo;
        private int attack;
        private int defense;
        private int speed;
        private string nickName;

        public string HeroName {
            get { return heroName; }
            set { heroName = value; }
        }
        public string HeroInfo {
            get { return heroInfo; }
            set { heroInfo = value; }
        }
        public int Attack { 
            get { return attack; }
            set { attack = value; }
        }
        public int Defense { 
            get { return defense; }
            set { defense = value; }
        }
        public int Speed { 
            get { return speed; }
            set { speed = value; }
        }
        public string NickName { 
            get { return nickName; }
            set { nickName = value; }
        }

        public Hero() { }
        public Hero(string m_heroName, string m_heroInfo, int m_attack, int m_defense, int m_speed, string m_nickName) {
            this.heroName = m_heroName;
            this.heroInfo = m_heroInfo;
            this.attack = m_attack;
            this.defense = m_defense;
            this.speed = m_speed;
            this.nickName = m_nickName;
        }

        public void Hello() {
            Console.WriteLine("我是:{0}, 我的信息:{1}, 攻击力: {2}, 防御力: {3}, 速度: {4}, 昵称: {5}", 
                this.heroName, this.heroInfo, this.attack, this.defense, this.speed, this.nickName);
        }
    }
}
