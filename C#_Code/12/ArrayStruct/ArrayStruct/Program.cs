using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStruct
{
    class Program
    {
        static void Main(string[] args)
        {

            //数组
            //概念: 数组是一个存储相同类型元素的固定大小的顺序集合
            //作用: 一次性存储多个相同类型的变量


            //1. 声明数组: 数据类型[] 数组名
            int[] intArray;


            //2. 初始化数组 
            //数组名 = new 数据类型[数组长度];
            intArray = new int[5];

            //声明+初始化
            //数据类型[] 数组名 = new 数据类型[数组长度]
            double[] doubleArray = new double[3];


            //3. 赋值
            //数组名[下标] = 值
            doubleArray[0] = 111;
            doubleArray[1] = 222;
            doubleArray[2] = 333;

            //声明+初始化+赋值
            //数据类型[] 数组名 = new 数据类型[数组长度]{值1, 值2, ..., 值N}
            int[] ages = new int[5] { 000, 111, 222, 333, 444 };
            //数据类型[] 数组名 = new 数据类型[]{值1, 值2, 值3}
            double[] doubleArrays = new double[] { 0, 1, 2, 3, 4, 5, 6 };


            //4. 使用
            //数组名[下标]
            Console.WriteLine(doubleArrays[1]);


            //注意
            //数组的下标是从0开始.
            //数组的长度是固定, 赋值与取值的时候, 下标不能越界


            Console.ReadKey();  



        }
    }
}
