using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //1. 实例化一个苹果对象
            Apple a1 = new Apple();

            //2. 字段的赋值与取值
            a1.color = Color.Red;
            a1.weight = 200;
            a1.shape = "圆形";

            Console.WriteLine("a1对象的颜色是{0}, 重量是{1}, 形状是{2}", 
                a1.color, a1.weight, a1.shape);


            Person p1 = new Person();
            p1.Name = "Monkey";
            //p1.age = 1800;
            p1.Age = 17;
            p1.Gender = Gender.男;
            p1.Address = "山东";

            p1.Eat();
            p1.Sleep();
            p1.Work();

            //Console.WriteLine("p1对象的姓名叫{0}, 年龄是{1}岁, 性别为{2}", p1.name, p1.age, p1.gender);
            Console.WriteLine("p1对象的姓名叫{0}, 年龄是{1}岁, 性别为{2}", p1.Name, p1.Age, p1.Gender);

            Person p2 = new Person("lkk", 20, Gender.男, "北京");
            Console.WriteLine("p2对象的姓名叫{0}, 年龄是{1}岁, 性别为{2}", p2.Name, p2.Age, p2.Gender);
            */



            //演示: 使用Person 类创建一个p1 对象, 将p1 对象赋值给p2
            Person p1 = new Person("Monkey", 27, Gender.男, "山东济南");
            Person p2;
            p2 = p1;
            p1.Hello();
            p2.Hello();
            p2.Name = "lkk";
            p1.Hello();
            p2.Hello();

            Console.ReadKey();
        }
    }
}
