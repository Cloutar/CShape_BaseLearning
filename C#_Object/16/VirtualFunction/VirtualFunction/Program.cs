using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 面向对象六大原则
             * 
             * 1. 单一责任原则
             * 2. 开闭原则
             * 3. 里氏转换原则
             * 4. 依赖倒置原则
             * 5. 接口隔离原则
             * 6. 迪米特原则
             * 
             * 
             * 里氏转换
             * 1. 子类对象可以直接赋值给父类对象
             * 2. 子类对象可以调用父类中的成员, 但是父类对象永远只能调用自己的成员
             * 3. 如果父类对象中装的是子类对象, 可以将这个父类对象强转为子类对象
             * 
             * 
             * is和as
             * is和as两个关键字都可以进行类型转换
             * is: 如果转换成功, 返回true, 失败返回false
             * as: 如果转换成功, 返回对应的对象, 失败返回null
             */


            //1. 子类对象可以直接赋值给父类对象
            //(好处: 有个方法, 有时需要传猫, 有时需要传老虎)
            //旧方式
            Cat c = new Cat();
            c.Cry();
            //新方式
            CatType ct = new Cat();
            ct.Cry();

            Console.WriteLine("-------------------------------------------------");





            //2. 子类对象可以调用父类中的成员, 但是父类对象永远只能调用自己的成员
            c.MKCODE();
            c.Monkey();

            ct.MKCODE();
            //ct.Monkey();     ---找不到方法

            Console.WriteLine("-------------------------------------------------");




            //3. 如果父类对象中装的是子类对象, 可以将这个父类对象强转为子类对象
            Cat c2 = (Cat)ct;
            c2.Monkey();

            Console.WriteLine("-------------------------------------------------");




            //is和as
            //is: 如果转换成功, 返回true, 失败返回false
            //bool mk = ct is Cat;
            //bool mk = ct is Tiger;
            //Console.WriteLine(mk);

            //as: 如果转换成功, 返回对应的对象, 失败返回null
            if (ct as Cat == null)
            {
                Console.WriteLine("转换失败");
            }
            else
            {
                Console.WriteLine("转换成功");
            }


            Console.ReadKey();

        }
    }
}
