using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    /// <summary>
    /// 汽车的父类
    /// </summary>
    class Car
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Car(string brand)
        {
            this.brand = brand;
        }

        public void Run()
        {
            Console.WriteLine("{0}品牌的汽车在奔跑..", this.brand);
        }
    }
}
