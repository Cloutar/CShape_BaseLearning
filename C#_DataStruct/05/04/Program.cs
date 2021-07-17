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
             * view -controller - model - 持久化
             */

            Console.WriteLine("-------------------------------");
            Console.WriteLine("---------用户管理系统----------");
            Console.WriteLine("-------------------------------");

            UserController uc = new UserController();

            while (true)
            {
                //提示用户可以进行的操作类型
            Console.WriteLine("请输入相应指令数字: 增加(1) 修改(2) 删除(3) 查看(4)");

            //接收用户输入的信息
            string command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    Console.WriteLine("请输入名字:");
                    string name = Console.ReadLine();
                    Console.WriteLine("请输入年龄:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入地址:");
                    string address = Console.ReadLine();
                    //调用控制器对象中的方法, 将数据添加到集合中
                    uc.AddItem(new User(name, age, address));
                    break;
                case "2":
                    Console.WriteLine("");
                    break;
                case "3":
                    Console.WriteLine("");
                    break;
                case "4":
                    uc.ShowAll();
                    break;
                default:
                    Console.WriteLine("请输入指定的指令数字");
                    break;
            }


            //对用户输入的命令进行判断
            }

        }
    }
}
