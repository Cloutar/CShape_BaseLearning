using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 继承
             * 将一堆类中的一些共有的"成员"单独抽取出来, 作为一个父类, 然后这一堆类
             * 继承这个父类, 共享父类的资源, 这就叫做继承
             * 
             * 好处
             * 提高代码结构
             * 提高代码复用性
             * 为多态提供前提
             * 
             * 子类继承父类, 使用":"冒号关键字符
             * 
             * 类视图
             * 当前项目上右键-->视图-->查看类图
             * 
             */

            /**
             * 在实际开发中, 一般情况下只会是实例化子类的对象, 因为子类才是具体的
             * 事物, 父类是子类公共数据的向上抽象
             */

            AiLuoKe m1 = new AiLuoKe("艾洛克", "我是大英雄艾洛克", 80, 90, 100, "Monkey");
            m1.LieYanMaoGou();
            m1.Hello();

            TaiLa m2 = new TaiLa("泰拉", "我是中英雄泰拉", 20, 30, 40, "abc");
            m2.JuLangChongJi();
            m2.Hello();

            LuKaShi m3 = new LuKaShi("卢卡斯", "我是小英雄卢卡斯", 40, 50, 60, "XXX");
            m3.NengLiangLangChao();
            m3.Hello();

            Console.ReadKey();
        }
    }
}
