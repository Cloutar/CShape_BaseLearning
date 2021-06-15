using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionStruct
{
    class Program
    {
        //函数. 方法.
        static void Main(string[] args)
        {
            //演示：封装int 类型一维数组相关操作函数.
            int[] intA = new int[] { 44, 56, 23, 78, 12 };

            //调用1.
            ShowTitle();
            
            //调用2.
            ForArray(intA);
            //调用3.
            int length = GetArrayLength(intA);
            Console.WriteLine("当前数组的个数:" + length);


            Console.ReadKey();
        }

        /// <summary>
        /// 输出当前题目的标题.
        /// </summary>
        static void ShowTitle()
        {
            Console.WriteLine("封装int 类型一维数组相关操作函数");
        }

        /// <summary>
        /// 遍历输出int类型数组的元素.
        /// </summary>
        /// <param name="intArray">int类型数组</param>
        static void ForArray(int[] intArray)
        {
            for(int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }

        /// <summary>
        /// 获取int类型数组的元素长度.
        /// </summary>
        /// <param name="intArray">int类型的数组</param>
        /// <returns>数组的长度</returns>
        static int GetArrayLength(int[] intArray)
        {
            return intArray.Length;
        }
    }
}
