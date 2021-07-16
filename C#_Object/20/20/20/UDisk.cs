using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class UDisk : IUSB
    {
        /// <summary>
        /// U盘本省的存储空间
        /// </summary>
        private string content;


        public void Read()
        {
            Console.WriteLine(content);
        }

        public void Write()
        {
            content = "Monkey";
        }
    }
}
