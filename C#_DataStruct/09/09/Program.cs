using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Dictionary 常用方法
             * 1.ContainsKey(K)
             * 判断当前字典集合中是否包含某个键
             * 2.ContainsValue(V)
             * 判断当前字典集合中是否包含某个值
             * 
             */

            //实例化控制器对象
            WebInfoController wc = new WebInfoController();

            wc.AddItem("百度", new Web("百度", "www.baidu.com", "李彦宏"));
            wc.AddItem("淘宝", new Web("淘宝", "www.taobao.com", "马云"));
            wc.AddItem("Cloutar", new Web("Cloutar", "www.cloutar.com", "星"));
            
            wc.ShowAll();

            Console.WriteLine("----------------------------");
            wc.DelItem("百度");
            wc.ShowAll();

            Console.WriteLine("----------------------------");
            wc.UpdateItem("淘宝", new Web("Cloutar", "www.cloutar.com", "星"));
            wc.ShowAll();

            Console.WriteLine("----------------------------");
            wc.AddItem("淘宝", new Web("淘宝", "www.taobao.com", "马云"));

            Console.ReadKey();
        }
    }
}
