using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class PhoneController
    {
        //定义一个字典集合<姓名, 电话号码>       ---   拓展, 不参与运算的数据没必要使用数值类型
        Dictionary<string, string> phones = new Dictionary<string, string>();

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="number">号码</param>
        public void AddItem(string name, string number)
        {
            phones.Add(name, number);
        }

        /// <summary>
        /// 查询所有信息
        /// </summary>
        public void ShowAll()
        {
            foreach (var item in phones.Keys)
            {
                Console.WriteLine("{0}:{1}", item, phones[item]);
            }
        }

        /// <summary>
        /// 通过名字删除号码
        /// </summary>
        /// <param name="name">姓名</param>
        public void DelItem(string name)
        {
            phones.Remove(name);
        }

        /// <summary>
        /// 通过名字修改号码
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="number">号码</param>
        public void UpdateItem(string name, string number)
        {
            phones[name] = number;
        }
    }
}
