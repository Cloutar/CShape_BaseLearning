using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * List<T>
             * List<T>是一个C#内置的一个类, 是类我们就可以实例化出对象.
             * List<T>本质和数组是一样的.
             * 因为List<T>这个类的内部其实是维护了一个数组.
             * 但是List<T>比数组灵活, 这个类封装了很多方便我们操作这个内部数组的各
             * 种方法, 我们可以方便的对数据进行增加, 删除, 修改等操作, 且List<T>的
             * 长度是可以动态改变的, 在实例化List<T>类型对象时, 不需要指定长度.
             * 
             * 使用
             * 1. 创建泛型集合
             * (1)首先引入命名空间: using System.Collections.Generic;
             * (2)List<类型> 集合名 = new List<类型>();
             * 2. 集合数据操作
             * (1)添加数据
             * (2)查询数据
             * 从0开始
             * (3)删除数据
             * 该索引位置的数据被删除后, 该索引后面的数据的索引会自动被调整
             * (4)修改数据
             * 
             */


            //实例化一个集合
            List<int> num = new List<int>();

            //添加数据
            num.Add(5);
            num.Add(15);
            num.Add(25);
            num.Add(35);

            //读取数据
            Console.WriteLine(num[2]);
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }

            //删除数据
            num.RemoveAt(2);
            Console.WriteLine("---------------------");
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }

            //修改数据
            num[2] = 100;
            Console.WriteLine("---------------------");
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.ReadKey();
        }
    }
}
