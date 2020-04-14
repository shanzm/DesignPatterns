using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04抽象工厂模式_多数据库连接
{
    public class MSSQLUserService : IUserService
    {
        public void Insert(User user)
        {
            Console.WriteLine($"MSSQL数据库User表中中-添加新的用户,Id:{user.Id },Name:{user.Name}");
        }

        public User GetUser(int id)
        {
            Console.WriteLine($"MSSQL数据库User表中-查询到用户,Id:{id}");
            return null;
        }
    }
}