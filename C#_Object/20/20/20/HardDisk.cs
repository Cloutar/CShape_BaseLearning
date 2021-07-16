using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class HardDisk : IUSB
    {
        private string content;

        public void Read()
        {
            Console.WriteLine(content);
        }

        public void Write()
        {
            content = "硬盘";
        }
    }
}
