using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串的大小写转化
            string name = "Monkey";
            Console.WriteLine("ToUpper: " + name.ToUpper());
            Console.WriteLine("ToLower: " + name.ToLower());

            //判断两个字符串是否相等
            string name_2 = "lkk";
            Console.WriteLine("Equals: " + name.Equals(name_2));

            //把有规律的字符串分割后放到数组
            string address = "中国|北京|海淀|上地";
            char[] c = new char[] { '|' };
            string[] ad = address.Split(c);
            for (int i = 0; i < ad.Length; i++) {
                Console.WriteLine(ad[i]);
            }

            //截取指定位置的字符串
            Console.WriteLine("Substring: " + name.Substring(2));
            Console.WriteLine("Substring: " + name.Substring(2, 2));

            //判断指定字符第一次和最后一次出现的位置
            Console.WriteLine("IndexOf: " + name.IndexOf("k"));
            Console.WriteLine("LastIndexOf: " + name_2.LastIndexOf("k"));

            //判断是不是什么开头和结尾
            Console.WriteLine("StartsWith: " + name.StartsWith("Mon"));
            Console.WriteLine("EndsWith: " + name.EndsWith("key"));

            //替换
            Console.WriteLine("Replace: " + name.Replace("Mon", "lkk"));

            //判断是否包含
            Console.WriteLine("Contains: " + name.Contains("Mon"));

            //去掉前后空格
            string webName = "         Fcri Test          ";
            Console.WriteLine("Trim: " + webName.Trim() + "结束标志");
            Console.WriteLine("TrimEnd: " + webName.TrimEnd() + "结束标志");
            Console.WriteLine("TrimStart: " + webName.TrimStart() + "结束标志");

            //判断字符串是否为null或者空
            //注: null是不占内存空间的, 而空字符串("")是占内存空间的
            //string n = "";
            string n = null;
            Console.WriteLine(string.IsNullOrEmpty(n));

            //当你给一个字符串变量重新赋值时, 旧值并没有销毁, 而是重新开辟一块空间来存储新值

            //字符串可看成是自读的字符数组
            string code = "fcritest";
            for (int i = 0; i < code.Length; i++) {
                Console.WriteLine(code[i]);
            }

                Console.ReadKey();
        }
    }
}
