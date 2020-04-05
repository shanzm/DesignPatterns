using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace _03单例模式_读取配置文件
{
    public sealed class AppConfig2
    {
        //定义字段，用于存储唯一实例
        private static readonly AppConfig2 appConfig = new AppConfig2();

        //对应配置文件设置相应的属性，注意是只读的
        public string Server { private set; get; }
        public string DataBase { private set; get; }
        public string UserId { private set; get; }
        public string PassWord { private set; get; }

        //构造函数私有化
        private AppConfig2()
        {
            Server = ConfigurationManager.AppSettings["server"];
            DataBase = ConfigurationManager.AppSettings["databaser"];
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