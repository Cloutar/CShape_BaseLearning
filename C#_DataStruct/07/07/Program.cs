using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Dictionary<K,V>
             * Dictionary集合是一种"键值对"集合
             */

            //创建字典泛型集合
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("baidu", "百度网站");
            dic.Add("qq", "腾讯网站");
            dic.Add("taobao", "淘宝网站");
            //不能添加同键名的数据
            //dic.Add("taobao", "天猫网站");

            //删除数据
            dic.Remove("taobao");

            dic["qq"] = "微信";

            //取集合的长度
            Console.WriteLine(dic.Count);

            //取值
            Console.WriteLine(dic["qq"]);

            //遍历集合
            foreach (var item in dic.Keys)
            {
                Console.WriteLine("{0}:{1}", item, dic[item]);
            }


            Console.ReadKey();
        }
    }
}
