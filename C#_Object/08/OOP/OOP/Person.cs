using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 命名空间, 也叫名称空间, 英文名是namespace    ---  中文名往往有几个名称, 英文只有一个, 记忆英文名称会比较国际通用~
 * 作用: 对代码文件进行分类管理
 * using 引用进来就可以使用
 */

namespace OOP
{
    public enum Gender { 
        男,
        女
    }

    /// <summary>
    /// Person类, 描述人
    /// </summary>
    class Person   //类
    {
        //字段
        private string name;
        private int age;
        private Gender gender;
        private string address;

        /*
             * 属性
             * 字段是我们对象的核心数据, 如果直接public公开的话, 容易被恶意赋值.
             * 所以, 字段通常使用private修饰, 这样通过对象名.xxx的形式访问不到.
             * 但是我们又需要通过对象名.xxx的形式对字段存储的数据进行操作.
             * 这个时候就出现了一种新的东西"属性"
             * 属性的作用是对字段进行保护, 我们将属性设为public, 可以直接访问, 然后
             * 属性保护的字段设置成private, 我们通过属性间接的操作字段.
        */

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public Gender Gender {
            get { return gender; }
            set { gender = value; }
        }

        public int Age {
            get { return age;  }   //get: 取值
            set {
                if (value > 100 || value < 0)
                {
                    age = 18;
                }
                else {
                    age = value;
                } 
            }   //set: 赋值
        }

        public string Address {
            get { return address; }
            set { address = value; }
        }



        /*
         * 普通方法
         */
        
        public void Eat() {
            Console.WriteLine(Name + "我会吃饭");
        }

        public void Sleep() {
            Console.WriteLine(Name + "我会睡觉");
        }

        public void Work() {
            Console.WriteLine(Name + "我会工作");
        }


        /*
         * 构造方法
         * 首先它是一个方法, 然后它具有"构造"的作用, 所以称之为构造方法
         * 简单点说, 构造方法可以对实例化出来的对象进行初始化
         * 
         * 当我们使用new关键字实例化一个对象的时候, 会首先执行构造方法.
         * 
         * 当我们的类中不写构造方法的时候, 在代码编译后, 系统会自动给它添加一个空
         * 构造方法, 如果我们写了一个构造方法, 默认的"空构造方法"就不会存在
         */

        /// <summary>
        /// 无参构造方法
        /// </summary>
        public Person() { 
        }

        /// <summary>
        /// 有参构造方法   ----   重载
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="address"></param>
        public Person(string name, int age, Gender gender, string address) {
            //this关键字 代表当前类的对象
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address; 
        }



        /*
         * 析构方法
         * 和构造方法正好相反, 构造方法用于初始化一个对象, 析构方法常用清理一个对
         * 象, 往往干的是"善后"的事情
         * 
         * 析构方法不能有任何参数
         * 析构方法无返回值也无访问修饰符
         * 析构方法由系统自动调用
         * 析构方法可以不写
         */

        ~Person() {
        }


    }
}
