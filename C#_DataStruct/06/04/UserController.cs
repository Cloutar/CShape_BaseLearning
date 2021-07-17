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

        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="user"></param>
        public void AddItem(User user)
        {
            userList.Add(user);
        }


        /// <summary>
        /// 通过姓名删除数据
        /// </summary>
        /// <param name="name"></param>
        public void RemoveByName(string name)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Name == name)
                {
                    userList.Remove(userList[i]);
                }
            }
        }

        /// <summary>
        /// 通过地址删除数据
        /// </summary>
        /// <param name="Address"></param>
        public void RemoveByAddress(string address)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Address == address)
                {
                    userList.Remove(userList[i]);
                }
            }
        }

        //修改数据

        
        /// <summary>
        /// 查询数据
        /// </summary>
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
