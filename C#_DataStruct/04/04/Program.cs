using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    /// <summary>
    /// V(View)视图层--和用户进行交互
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * MVC
             * view -controller - model - 持久化(数据库 XML JSON TXT)
             */

            Console.WriteLine("-------------------------------");
            Console.WriteLine("---------用户管理系统----------");
            Console.WriteLine("-------------------------------");

            UserController uc = new UserController();

            //接收用户输入的信息

            //对用户输入的命令进行判断



            Console.ReadKey();
        }
    }
}
