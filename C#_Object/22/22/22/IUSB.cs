using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    interface IUSB
    {
        /// <summary>
        /// 读取 移动设备中的数据
        /// </summary>
        void Read();

        /// <summary>
        /// 往移动设备中写入数据
        /// </summary>
        void Write(string content);
    }
}
