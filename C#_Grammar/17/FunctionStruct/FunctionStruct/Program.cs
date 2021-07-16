using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionStruct
{
    class Program
    {
        static void Main(string[] args)
        {

            //回顾练习
            int[] intA = new int[] { 44, 56, 23, 78, 12 };

            //调用
            ShowTitle();
            ForArray(intA);
            int length = GetArrayLength(intA);
            

            Console.WriteLine("当前数组的个数: " + length);

            Console.ReadKey();

        }

        /// <summary>
        /// 无参无返回(这里的中文将会在调用函数时候显示)
        /// </summary>
        static void ShowTitle() {
            Console.WriteLine("封装int 类型一维数组相关的操作函数");
        }


        /// <summary>
        /// 有参无返回
        /// </summary>
        /// <param name="intArray">int类型数组(这里的中文将会在调用函数时候显示)</param>
        static void ForArray(int[] intArray) {
            for (int i = 0; i < intArray.Length; i++) {
                Console.WriteLine(intArray[i]);
            }
        }


        /// <summary>
        /// 有参数有返回
        /// </summary>
        /// <param name="intArray">int类型数组</param>
        /// <returns>数组的长度(这里的中文将会在调用函数时候显示)</returns>
        static int GetArrayLength(int[] intArray) {
            return intArray.Length;
        }



    }
}
