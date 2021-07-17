using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    /// <summary>
    /// 实体类
    /// </summary>
    class Web
    {
        private string name;
        private string url;
        private string boss;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string Boss
        {
            get { return boss; }
            set { boss = value; }
        }

        public Web(string name, string url, string boss)
        {
            this.name = name;
            this.url = url;
            this.boss = boss;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.name, this.url, this.boss);
        }
    }
}
