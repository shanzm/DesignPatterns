using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03单例模式_读取配置文件
{
    public class AppConfig
    {
        //定义字段，用于存储唯一实例
        private static AppConfig appConfig = null;

        //对应配置文件设置相应的属性，注意是只读的
        public string Server { private set; get; }
        public string DataBase { private set; get; }
        public string UserId { private set; get; }
        public string PassWord { private set; get; }

        //构造函数私有化
        private AppConfig()
        {

        }

        //获取唯一实例
        public static AppConfig GetInstance()
        {
            if (appConfig == null)
            {
                appConfig = new AppConfig()
                {
                    Server = ConfigurationManager.AppSettings["server"],
                    DataBase = ConfigurationManager.AppSettings["databaser"],
                    UserId = ConfigurationManager.AppSettings["uid"],
                    PassWord = ConfigurationManager.AppSettings["pwd"]
                };
            }
            return appConfig;
        }

    }
}