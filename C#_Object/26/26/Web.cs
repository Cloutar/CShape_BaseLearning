using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Web
    {
        private string webName;
        private string webUrl;

        public Web(string webName, string webUrl)
        {
            this.webName = webName;
            this.webUrl = webUrl;
        }

        public void Show()
        {
            Console.WriteLine("名字:{0} 地址:{1}", this.webName, this.webUrl);
        }
    }
}
