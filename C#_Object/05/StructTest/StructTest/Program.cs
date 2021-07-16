using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTest
{
    class Program
    {
        public enum Gender { 
            男,
            女
        }

        public struct Person {
            public string name;
            public int age;
            public Gender gender;
            public string address;
        }

        static void Main(string[] args)
        {
            /*
             * 结构体: struct
             * 结构体是一种值类型, 通常用于封装一些小型变量数据
             */

            //使用之前讲解的知识, 来保存一个人的基本信息, 姓名, 年龄, 性别, 地址

            string name = "Monkey";
            int age = 27;
            Gender gender = Gender.男;
            string address = "北京海淀上地";

            Console.WriteLine(name + age + gender + address);
            

            //1. 创建结构体类型的变量
            Person monkey = new Person();
            //2. 给结构体赋值
            monkey.name = "傻逼";
            monkey.age = 1;
            monkey.gender = Gender.男;
            monkey.address = "上海浦东新区";

            //3. 结构体的取值
            Console.WriteLine(monkey.name + monkey.age + monkey.gender + monkey.address);




            Console.ReadKey();

        }
    }
}
