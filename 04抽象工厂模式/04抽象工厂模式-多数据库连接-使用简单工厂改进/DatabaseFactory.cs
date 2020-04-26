using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04抽象工厂模式_多数据库连接_使用简单工厂改进
{
    //其实就是简单工厂中的有针对不同的表，分别实现该表的工厂方法
    //若是一个表，则就是一个工厂方法，就和之前的普通的简单工厂模式一模一样了。

    public class DatabaseFactory
    {
        private static readonly string db = "MSSQL";//若是需要更换数据库则将字符串改为"Oracle"
        public static IUserService CreateUserService()
        {
            IUserService userService = null;
            switch (db)
            {
                case "MSSQL":
                    userService = new MSSQLUserService();
                    break;
                case "Oracle":
                    userService = new OracleUserService();
                    break;
            }
            return userService;
        }
        public static IDepartmentService CreateDeprService()
        {
            IDepartmentService depService = null;
            switch (db)
            {
                case "MSSQL":
                    depService = new MSSQLDepService();
                    break;
                case "Oracle":
                    depService = new OracleDepService();
                    break;
            }
            return depService;
        }
    }
}