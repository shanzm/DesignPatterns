using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace _03单例模式_读取配置文件
{
    public sealed class AppConfig2//类定义为密封类，防止派生类创建对象
    {
        //定义字段，用于存储唯一实例
        private static readonly AppConfig2 appConfig = new AppConfig2();
        //用于存储实例的字段定义为只读的，则只能在类静态初始化给其赋值
        //给 readonly 字段的赋值只能作为字段声明的组成部分出现，或在同一个类中的构造函数中出现。

        //对应配置文件设置相应的属性，注意是只读的
        public string Server { private set; get; }
        public string DataBase { private set; get; }
        public string UserId { private set; get; }
        public string PassWord { private set; get; }

        //构造函数私有化
        private AppConfig2()
        {
            Server = ConfigurationManager.AppSettings["server"];
            DataBase = ConfigurationManager.AppSettings["database"];
            UserId = ConfigurationManager.AppSettings["uid"];
            PassWord = ConfigurationManager.AppSettings["pwd"];
        }

        //获取唯一实例
        public static AppConfig2 GetInstance()
        {
            return appConfig;
        }

    }
}