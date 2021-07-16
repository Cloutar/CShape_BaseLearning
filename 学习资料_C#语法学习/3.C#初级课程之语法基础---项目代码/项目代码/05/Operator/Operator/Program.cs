using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1.关系运算符.
            //> < 
            Console.WriteLine(5 > 3);   //true.
            Console.WriteLine(5 < 3);   //false.

            //>= <= 
            Console.WriteLine(10 >= 5); //true.
            Console.WriteLine(10 >= 10);//true.
            Console.WriteLine(10 >= 100);//false.

            Console.WriteLine(10 <= 12);//true.
            Console.WriteLine(10 <= 10);//true.

            //== !=  不等于.
            Console.WriteLine(10 == 5); //false.
            Console.WriteLine(10 != 5); //true.
            */


            /*
            //逻辑与 &&
            Console.WriteLine(10 > 5 && 10 < 20);   //true.
            Console.WriteLine(3 > 5 && 10 > 7);     //false.

            //逻辑或 ||
            Console.WriteLine(5 > 3 || 3 > 10);     //true.
            Console.WriteLine(7 > 4 || 10 > 5);     //true.
            Console.WriteLine(5 < 2 || 9 < 1);      //false.

            //逻辑非 !
            Console.WriteLine(!(5 > 3));        //false.
            Console.WriteLine(!(5 < 6));        //false.

            */
 
            /*
            //例：计算闰年
            //闰年的条件：年份能被400 整除,或者年份能被4 整除但不能被100 整除。
            int nian = 2012;

            bool runnian = (nian % 400 == 0) || (nian % 4 == 0 && nian % 100 != 0);
            Console.WriteLine(runnian);

             */
 
            //3.占位符.
            string name = "Monkey";
            int age = 100;
            string gender = "男";
            string address = "山东";

            Console.WriteLine("我的名字是:" + name + ",我今年" + age + "岁了," + "我的性别是" + gender);
            
            Console.WriteLine("我的名字是{0},我今年{1}岁,我的性别是{2}",name,age,gender);


            Console.ReadKey();
        }
    }
}
