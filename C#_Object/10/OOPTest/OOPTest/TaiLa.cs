using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    class TaiLa
    {
               /*
         * 字段
         */
        private string heroName;
        private string heroInfo;
        private int attack;
        private int defense;
        private int speed;
        private string nickName;

        /*
         * 属性
         */
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


        /*
         * 构造方法
         */
        public TaiLa() { 
        }

        public TaiLa(string nickName) {
            this.heroName = "斯洛克";
            this.heroInfo = "我是斯洛克, 我是一位英雄";
            this.attack = 80;
            this.defense = 65;
            this.speed = 40;
            this.nickName = nickName;
        }


        /*
         * 普通方法
         */
        public void ShuiShiDaJi() {
            Console.WriteLine("碎石打击");
        }

        public void LieYanMaoGou() {
            Console.WriteLine("烈焰锚钩");
        }

        public void ZhanHuoPaoXiao() {
            Console.WriteLine("战火咆哮");
        }

        public void Hello() {
            Console.WriteLine("我的名字叫{0}, 我的简介是{1}, 攻击力{2}, 防御力{3}, 速度{4}, 昵称{5}", 
                this.heroName, this.heroInfo, this.attack, this.defense, this.speed, this.nickName);
        }
    }
}
