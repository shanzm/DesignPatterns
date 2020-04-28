using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04抽象工厂模式_多数据库连接_反射_简单工厂
{
    #region 使用反射
    //通过使用反射我们可以免去在工厂方法中使用switch语句
    //看上去好像并没有变得更加方便，但其实是如有产品族比较多，则switch语句的case语句也相应的变多
    //所以使用反射，可以省略使用switch还是不错的

    //public class DatabaseFactory
    //{
    //    private static readonly string AssemblyName = "04抽象工厂模式-多数据库连接-反射+简单工厂";
    //    private static readonly string db = "MSSQL";//若是需要更换数据库则将字符串改为"Oracle"
    //    public static IUserService CreateUserService()
    //    {
    //        //具体产品的完全限定名，注意因为我们的这个项目中有特殊字符，所以程序集的名字和项目名不一致，
    //        //查看程序集名和命名空间名可以右键项目属性
    //        string className = "_04抽象工厂模式_多数据库连接_反射_简单工厂" + "." + db + "UserService";
    //        IUserService result = (IUserService)Assembly.Load(AssemblyName).CreateInstance(className);
    //        return result;
    //    }
    //    public static IDepartmentService CreateDeprService()
    //    {
    //        string className = "_04抽象工厂模式_多数据库连接_反射_简单工厂" + "." + db + "DepService";
    //        return (IDepartmentService)Assembly.Load(AssemblyName).CreateInstance(className);
    //    }
    //}
    #endregion


    #region 使用配置文件
    //对该项目添加引用：System.Configuration
    public class DatabaseFactory
    {
        private static readonly string AssemblyName = "04抽象工厂模式-多数据库连接-反射+简单工厂";
        //读取配置中的对数据库的设置
        private static readonly string db = ConfigurationManager.AppSettings["db"];//若是需要更换数据库则将字符串改为"Oracle"
        public static IUserService CreateUserService()
        {
            //具体产品的完全限定名，注意因为我们的这个项目中有特殊字符，所以程序集的名字和项目名不一致，
            //查看程序集名和命名空间名可以右键项目属性
            string className = "_04抽象工厂模式_多数据库连接_反射_简单工厂" + "." + db + "UserService";
            IUserService result = (IUserService)Assembly.Load(AssemblyName).CreateInstance(className);
            return result;
        }
        public static IDepartmentService CreateDeprService()
        {
            string className = "_04抽象工厂模式_多数据库连接_反射_简单工厂" + "." + db + "DepService";
            return (IDepartmentService)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
    #endregion

}