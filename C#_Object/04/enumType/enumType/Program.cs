using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumType
{
    //1. 定义枚举
    public enum Week { 
        星期一,
        星期二,
        星期三,
        星期四,
        星期五,
        星期六,
        星期天
    }

    public enum Gender { 
        boy,
        girl
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 特点: 枚举类型是需要我们使用者根据实际的开发需要来自行定义
             * 
             * 目的: 定义枚举的目的, 就是规范一些数据的值
             * 
             * 前提: 枚举类型往往是一些事先定义好的, 在项目中公共使用的一些数据
             * 
             */ 

            //2. 使用枚举类型
            //枚举类型 变量名 = 枚举类型.值
            Week day = Week.星期四;
            Gender p1 = Gender.boy;
            Gender p2 = Gender.girl;

            Console.WriteLine(day);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadKey();

        }
    }
}
