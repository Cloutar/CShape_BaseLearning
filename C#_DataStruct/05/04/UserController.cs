using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    /// <summary>
    /// C(controller)控制器层--用于处理逻辑
    /// </summary>
    class UserController
    {
        List<User> userList = new List<User>();

        //增加数据
        public void AddItem(User user)
        {
            userList.Add(user);
        }


        //删除数据

        //修改数据

        //查询数据
        public void ShowAll()
        {
            if (userList.Count == 0)
            {
                Console.WriteLine("尚未添加数据");
            }
            else
            {
                for (int i = 0; i < userList.Count; i++)
                {
                    Console.WriteLine(userList[i]);
                }
            }
        }
    }
}
