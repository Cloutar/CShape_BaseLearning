using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Computer
    {
        private string brand;

        /// <summary>
        /// USB 插槽   --- 面向接口开发的思想
        /// </summary>
        public IUSB USB_1;
        public IUSB USB_2;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Computer(string brand)
        {
            this.brand = brand;
        }

        public void Start()
        {
            Console.WriteLine("{0}品牌电脑开机中...", this.brand);
        }

        public void End() 
        {
            Console.WriteLine("{0}品牌电脑关机中...", this.brand);
        }
    }
}
