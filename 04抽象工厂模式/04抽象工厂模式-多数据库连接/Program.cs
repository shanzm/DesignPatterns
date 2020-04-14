using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//这个项目中实现了模拟数据的查询和插入
//假设有一个User用户表，我们通过SqlServerUser中通过对数据库的操作，实现查询和查询用户

//而我们有可能使用SQL Server和Oracle两种数据库
//所以我们使用工厂模式
//定义抽象产品接口IUserService,派生具体产品对象：MSSQLUserService和OracleUserService
//定义抽象工厂（IFactory),和子工厂MSSQLFactory和OracleFactory


//通过使用工厂模式，由不同的具体工厂创建对不同数据库的操作对象
//实现了业务逻辑与数据访问的解耦
//在你更换数据库的时候，就不需要修改大量代码



//当我们需要对其他的表进行操作的时候，比如对部门表Department表操作
//我们需要添加两个产品类MSSQLDepService和OracleDelService
//同时在MSSQLFactory和OracleFactory工厂中添加新的方法
namespace _04抽象工厂模式_多数据库连接
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Id = 0001, Name = "shanzm" };
            Department dep = new Department() { Id = 1000, Name = "Development" };


            IDatabaseFactory msSQlFactory = new MSSQLFactory();
            IDatabaseFactory oracleFactory = new OracleFactory();

            //若是对MSSQL数据库中的User表操作
            IUserService msUserService = msSQlFactory.CreateUserService();
            msUserService.Insert(user);
            msUserService.GetUser(00001);//print:查询到用户,Id:00001


            //若是对Oracle数据库中User表操作
            IUserService oracleUserService = oracleFactory.CreateUserService();
            oracleUserService.Insert(user);
            oracleUserService.GetUser(00001);


            //若是对MSSQL数据库中的Del表操作
            IDepartmentService msDepService = msSQlFactory.CreateDepService();
            msDepService.Insert(dep);
            msDepService.GetDepartment(1000);


            //若是对Oracle数据库中的Del表操作
            IDepartmentService oracleDepService = oracleFactory.CreateDepService();
            oracleDepService.Insert(dep);
            oracleDepService.GetDepartment(1000);
            Console.ReadKey();
        }
    }
}
