using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            //武器集合的定义
            List<Weapon> weapons = new List<Weapon>();

            Weapon item = new Weapon(1, "霸王枪", 100);
            weapons.Add(item);
            weapons.Add(new Weapon(2, "翡翠刀", 200));
            weapons.Add(new Weapon(3, "太极卷轴", 300));
            weapons.Add(new Weapon(4, "绿玉棍", 400));

            //weapons.RemoveAt(1);
            //通过名字删除一个对象
            for (int i = 0; i < weapons.Count; i++)
            {
                if (weapons[i].Name == "太极卷轴")
                {
                    weapons.Remove(weapons[i]);
                    //修改
                    weapons[i].Attack = 9999;
                }
            }

            for (int i = 0; i < weapons.Count; i++)
            {
                Console.WriteLine(weapons[i]);
            }

            Console.ReadKey();
        }
    }
}
