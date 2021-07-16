using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 1.嵌套类
             * 在C#中可以将一个类定义在另一个类的内部;
             * 外面的类叫"外部类", 内部的类叫"嵌套类"
             * 嵌套类和普通类相似, 只是声明的位置比较特殊.
             * 注意
             * 如果想实例化内部类的话, 需要使用 外部类名.内部类名 的方法访问到内部类
             * 
             * 
             * 2. 匿名类
             * 如果某个类的实例对象只会使用到一次, 可以使用匿名类的方式创建这个对象
             * 不需要定义类, 我们就可以创建一个对象.
             * 这样的类一般一般用于存储一组只读属性.
             * 
             * 
             * 3. 密封类
             * 被sealed关键字修饰过的类不可以被继承, 也就是说不能有子类;
             * 这样的类, 通常称之为"密封类"
             * 
             * 
             */

            Person p = new Person();
            p.Hello();

            //声明一个嵌套类的对象
            Person.Web w = new Person.Web();
            w.webName = "百度";
            w.webUrl = "www.baidu.com";
            w.Show();


            //匿名类
            var mk = new { Name = "lkk", Age = 100, Address = "山东" };
            //mk.Name = "测试";    报错--只读
            Console.WriteLine("姓名:{0}, 年龄:{1}, 地址:{2}", mk.Name, mk.Age, mk.Address);


            Console.ReadKey();


        }
    }
}
