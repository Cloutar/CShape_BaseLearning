using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //if语句 语法.

            if(5 < 3)//false
            {
                Console.WriteLine("5 > 3");
            }

            Console.WriteLine("我是后续的代码");
            Console.ReadKey();
        
            */

            /*
            //例：游戏开始运行，检查联网状态，更新资源

            bool wifi = false;
            if(wifi == false)
            {
                Console.WriteLine("无网络");
                Console.ReadKey();
            }

            Console.WriteLine("游戏继续运行");
            Console.ReadKey();
            */

            //if-else 语句 语法
            /*
            if(5 < 3)//false.
            {
                Console.WriteLine("5真的大于3");
            }else{
                Console.WriteLine("hehe");
            }

            Console.WriteLine("我是后面的代码");
            Console.ReadKey();*/

            //模拟账户登录.

            string userName = "Monkey";
            string passWord = "12345678";

            if(userName == "Monkey" && passWord == "123456")
            {
                Console.WriteLine("登录成功");
            }
            else
            {
                Console.WriteLine("账户密码错误,留在本页面");
            }

            Console.ReadKey();
        }
    }
}
