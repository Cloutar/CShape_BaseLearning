using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. for循环遍历数组
            /*
            int[] intArray;
            intArray = new int[5];
            intArray[0] = 10;
            intArray[1] = 12;
            intArray[2] = 14;

            Console.WriteLine(intArray[1]);
             */

            //int[] intArray = new int[] { 11, 22, 33, 44, 55, 66, 77 };


            //遍历数组

            /*
            //intArray.Length : 可以取得当前数组的长度.
            Console.WriteLine(intArray.Length);
            Console.WriteLine();
             */

            //遍历取值
            /*
            for (int i = 0; i < intArray.Length; i++) {
                Console.WriteLine(intArray[i]);
            }
             */

            /*
            //遍历赋值
            string[] str = new string[5];
            for (int i = 0; i < str.Length; i++) {
                str[i] = "元素" + i;
            }

            for (int j = 0; j < str.Length; j++) {
                Console.WriteLine(str[j]);
            }
             */

            /*
            //例子
            string[] animals = new string[] { "子鼠", "丑牛", "寅虎", "卯兔", "辰龙", "巳蛇", "午马", "未羊", "申猴", "酉鸡", "戌狗", "亥猪" };
            string animalStr = "";

            for (int i = 0; i < animals.Length; i++) {
                animalStr += animals[i];
                if (i < animals.Length - 1) {               //这个想法是我以前没有的, 以前一直想先加后减
                    animalStr += "|";
                }
            }

            Console.WriteLine(animalStr);
             */


            /*
            //2. foreach 遍历数组
            //foreach(数组数据类型 临时变量 in 数组名) { Console.WriteLine(临时变量); }
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in intArray) {
                Console.WriteLine(i);
            }
             */


            //3 数组元素的初始值
            //数据类型[] 数组名 = new 数据类型[数组长度];
            //数组的声明, 初始化. 5个元素的存储控件, 已经在内存中开辟了
            //默认值
            int[] intArray = new int[5];      //元素默认值: 0
            float[] fArray = new float[5];      //元素默认值: 0
            double[] dArray = new double[5];      //元素默认值: 0
            string[] sArray = new string[5];      //元素默认值: NULL
            bool[] bArray = new bool[5];      //元素默认值: Flase

            //遍历int
            foreach (int i in intArray) {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------");

            //遍历float
            foreach (float f in fArray)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine("--------------------------------");

            //遍历double
            foreach (double d in dArray)
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("--------------------------------");

            //遍历string
            foreach (string s in sArray)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("--------------------------------");

            //遍历bool
            foreach (bool b in bArray)
            {
                Console.WriteLine(b);
            }




                Console.ReadKey();
        }
    }
}
