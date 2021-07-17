using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 数组的缺点: 很多情况无法提前知道一共有多少
             * 
             * 数据结构
             * 数据结构是指相互之间存在一种或多种特定关系的数据元素的集合.
             * 数据结构这个知识点也是面试的时候出场率最高的一个.
             * 
             * 集合结构
             * C#中提供了一系列特殊功能的类, 这些类可以存储任意类型的对象, 并且长度
             * 是可变的, 他们统称为集合.
             * 在C#编程语言中, 集合结构有两种: 泛型集合, 非泛型集合.
             * 泛型集合: 只能存储固定类型的对象的一种集合.
             * 要使用泛型集合, 我们必须引入对应的命名空间
             * System.Collections.Generic
             * 
             */


            //变量.单个数据
            int numA = 10;
            float numB = 3.14f;
            bool isStart = false;

            Console.WriteLine("{0} - {1} - {2}", numA, numB, isStart);

            Console.WriteLine("----------------------int类型数组------------------------");

            //数组.int类型数组
            int[] numC = new int[3];
            numC[0] = 10;
            numC[1] = 20;
            numC[2] = 30;

            for (int i = 0; i < numC.Length; i++)
            {
                Console.WriteLine(numC[i]);
            }


            Console.WriteLine("----------------------float类型数组------------------------");

            //数组.float类型数组
            float[] numD = new float[] { 1.2f, 2.4f, 3.5f, 5.5f };
            for (int i = 0; i < numD.Length; i++)
            {
                Console.WriteLine(numD[i]);
            }



            Console.WriteLine("----------------------bool类型数组------------------------");

            //数组.bool类型数组
            bool[] isStarts = new bool[3] { false, true, false };
            for (int i = 0; i < isStarts.Length; i++)
            {
                Console.WriteLine(isStarts[i]);
            }



            Console.ReadKey();
        }
    }
}
