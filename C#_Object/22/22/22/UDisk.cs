using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class UDisk : Disk, IUSB
    {
        /// <summary>
        /// 模拟U盘的存储空间
        /// </summary>
        private string content;

        public UDisk(string brand)
            : base(brand)
        {
            //
        }

        public void Read()
        {
            Console.WriteLine("{0}读取数据: {1}: ", this.Brand, this.content);
        }

        public void Write(string content)
        {
            this.content += content;
            Console.WriteLine("{0}存入数据: {1}", this.Brand, content);
        }
    }
}
