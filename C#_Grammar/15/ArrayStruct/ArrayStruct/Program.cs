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
            /*
             * 二维数组
             * 
             * 1.声明与初始化
             * 声明: 数据类型[,] 数组名;
             * 初始化: 数组名 = new 数据类型[行数, 列数];
             * 
             * 声明, 初始化二合一格式
             * 数据类型[,] 数组名 = new 数据类型[行数, 列数];
             * 
             * 
             * 2. 赋值与取值
             * 赋值: 数组名[下标, 下标] = 值
             * 取值: 数组名[下标, 下标]
             * 
             * 
             * 3.声明初始化赋值三合一
             * 数据类型[,] 数组名 = new 数据类型[,]{
             *  {0, 0, 0, 0},
             *  {1, 1, 1, 1}
             * }
             * 
             * 
             * 
             * 2. 二维数组的遍历
             * for循环嵌套
             * 数组名.GetLength(轴向下标);    //可以获取某个轴向的元素个数
             * 
             * 
             */

            //声明
            int[] intArray;
            int[,] intArray_2;

            //初始化
            intArray = new int[5];
            intArray_2 = new int[3, 3];   // 3*3 = 9个存储控件, 行数 列数

            //声明初始化二合一
            int[] intOne = new int[8];
            int[,] intTwo = new int[6, 9];  //6行 9列

            //赋值
            //第一行
            intArray_2[0, 0] = 1;
            intArray_2[0, 1] = 2;
            intArray_2[0, 2] = 3;

            //第二行
            intArray_2[1, 0] = 11;
            intArray_2[1, 1] = 22;
            intArray_2[1, 2] = 33;

            //第三行
            intArray_2[2, 0] = 111;
            intArray_2[2, 1] = 222;
            intArray_2[2, 2] = 333;

            //Console.WriteLine(intArray_2[1, 1]);

            //三合一
            int[,] intArrays = new int[,] { 
                {1, 2, 3},
                {11, 22, 33},
                {111, 222, 333},
                {1111, 2222, 3333},
            };


            //二维数组的遍历
            for (int i = 0; i < intArrays.GetLength(0); i++) {
                for (int j = 0; j < intArrays.GetLength(1); j++) {
                    Console.Write(intArrays[i, j] + "\t");
                }
                Console.WriteLine();
            }


            //二维数组在游戏中的应用:
            //二维数组存储迷宫地图
            int[,] gameMaps = new int[,] {
                {1, 1, 1, 1, 1, 1, 1, 1, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 0, 0, 0, 0, 0, 0, 1},
                {1, 0, 0, 0, 1, 0, 0, 0, 1},
                {1, 0, 0, 0, 0, 1, 0, 0, 1},
                {1, 0, 0, 0, 0, 1, 0, 0, 1},
                {1, 0, 0, 0, 0, 0, 0, 0, 1},
                {1, 1, 1, 1, 1, 1, 1, 1, 1}
            };

            //遍历二维数组生成地图
            for (int i = 0; i < gameMaps.GetLength(0); i++) {
                for (int j = 0; j < gameMaps.GetLength(1); j++) {
                    if (gameMaps[i, j] == 1) {
                        Console.Write("■");
                    }
                    if (gameMaps[i, j] == 0) {
                        Console.Write("□");
                    }
                }
                Console.WriteLine();
            }



                Console.ReadKey();

        }
    }
}
