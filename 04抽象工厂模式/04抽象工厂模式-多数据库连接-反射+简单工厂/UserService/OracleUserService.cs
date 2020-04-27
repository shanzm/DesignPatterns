using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04抽象工厂模式_多数据库连接_反射_简单工厂
{
    public class OracleUserService : IUserService
    {
        public void Insert(User user)
        {
            Console.WriteLine($"Oracle数据库User表中-添加新的用户,Id:{user.Id },Name:{user.Name}");
        }

        public User GetUser(int id)
        {
            Console.WriteLine($"Oracle数据库User表中-查询到用户,Id:{id}");
            return null;
        }
    }
}