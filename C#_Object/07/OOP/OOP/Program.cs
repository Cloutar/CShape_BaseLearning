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
            //1. 实例化一个苹果对象
            Apple a1 = new Apple();

            //2. 字段的赋值与取值
            a1.color = Color.Red;
            a1.weight = 200;
            a1.shape = "圆形";

            Console.WriteLine("a1对象的颜色是{0}, 重量是{1}, 形状是{2}", 
                a1.color, a1.weight, a1.shape);


            Person p1 = new Person();
            p1.name = "Monkey";
            //p1.age = 1800;
            p1.Age = 178;
            p1.gender = Gender.男;

            //Console.WriteLine("p1对象的姓名叫{0}, 年龄是{1}岁, 性别为{2}", p1.name, p1.age, p1.gender);
            Console.WriteLine("p1对象的姓名叫{0}, 年龄是{1}岁, 性别为{2}", p1.name, p1.Age, p1.gender);



            Console.ReadKey();
        }
    }
}
