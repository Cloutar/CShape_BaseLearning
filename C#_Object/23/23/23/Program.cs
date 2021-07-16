using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             * 五种访问修饰符
             * 
             * 1. public 公开的访问权限
             * 当前类, 子类, 实例对象, 都可以访问到.
             * 
             * 2. private 私有的访问权限
             * 只能在当前类内部进行访问使用; 子类, 实例对象,都访问不到.
             * 
             * 3. protected 受保护的访问权限
             * 只能在当前类的内部, 以及该类的子类中访问; 实例对象访问不到.
             * 
             * 4. internal 只能在当前程序集(项目)中访问
             * 在同一个项目中internal和public的访问权限是一样的   ---(解决方案下面就是一个项目)
             * 
             * 5. protected internal 内部保护访问
             * protected + internal 的访问权限
             * 
             * 
             * 
             * 
             * 使用场合
             * 1. 修饰类
             * 能够修饰类的访问修饰符只有两个, public 和 internal
             * 类的默认访问修饰符是internal
             * 
             * 2. 修饰类成员
             * 五种访问修饰符都可以修饰类中的成员
             * 类中的成员默认访问修饰符是private
             * 
             * 
             * 
             * 
             * 
             */

            Monkey m = new Monkey();
            m.Name = "名字";
            //m.name = "123";   -- priavte 无法访问
            //m.name = "123";   --  protected 无法访问
            Console.WriteLine(m.Name);

            Console.ReadKey();

        }
    }
}
