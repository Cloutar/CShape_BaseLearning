using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class WebInfoController
    {
        //实例化字典集合, 管理网站信息
        Dictionary<string, Web> webInfos = new Dictionary<string, Web>();

        public void AddItem(string name, Web web)
        {
            if (!webInfos.ContainsKey(name))
            {
                webInfos.Add(name, web);
            }
            else
            {
                Console.WriteLine("已存在" + name);
            }
        }

        public void DelItem(string name)
        {
            webInfos.Remove(name);
        }

        public void UpdateItem(string name, Web web)
        {
            webInfos[name] = web;
        }

        public void ShowAll()
        {
            foreach (var item in webInfos.Keys)
            {
                Console.WriteLine("{0}:{1}", item, webInfos[item]);
            }
        }

    }
}
