﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04抽象工厂模式_多数据库连接_使用简单工厂改进
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Id = 0001, Name = "shanzm" };
            Department dep = new Department() { Id = 1000, Name = "Development" };

            IUserService userService = DatabaseFactory.CreateUserService();
            userService.Insert(user);

            IDepartmentService depService = DatabaseFactory.CreateDeprService();
            depService.Insert(dep);

            Console.ReadKey();
        }
    }
}
