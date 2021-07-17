using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化控制器对象
            PhoneController pc = new PhoneController();

            //添加
            pc.AddItem("lkk", "18024161234");
            pc.AddItem("mk", "18024165555");

            //查看
            pc.ShowAll();

            Console.WriteLine("--------------------------------------------");

            //修改
            pc.UpdateItem("mk", "110");
            pc.ShowAll();

            Console.WriteLine("--------------------------------------------");

            //删除
            pc.DelItem("mk");
            pc.ShowAll();

            Console.ReadKey();
        }
    }
}
