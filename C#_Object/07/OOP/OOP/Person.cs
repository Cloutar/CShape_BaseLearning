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
        public string name;
        private int age;
        public Gender gender;

        /*
             * 属性
             * 字段是我们对象的核心数据, 如果直接public公开的话, 容易被恶意赋值.
             * 所以, 字段通常使用private修饰, 这样通过对象名.xxx的形式访问不到.
             * 但是我们又需要通过对象名.xxx的形式对字段存储的数据进行操作.
             * 这个时候就出现了一种新的东西"属性"
             * 属性的作用是对字段进行保护, 我们将属性设为public, 可以直接访问, 然后
             * 属性保护的字段设置成private, 我们通过属性间接的操作字段.
        */

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


    }
}
