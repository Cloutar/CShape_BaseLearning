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
    }
}
