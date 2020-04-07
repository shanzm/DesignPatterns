using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03单例模式_读取配置文件
{
    public sealed class AppConfigInnerClass
    {
        //静态内部类
        private static class AppConfigHolder
        {
            //注意将内部静态类的默认构造函数改为静态的
            static AppConfigHolder()
            {

            }
            internal static AppConfigInnerClass appConfig = new AppConfigInnerClass();
        }


        //对应配置文件设置相应的属性，注意是只读的
        public string Server { private set; get; }
        public string DataBase { private set; get; }
        public string UserId { private set; get; }
        public string PassWord { private set; get; }

        //构造函数私有化
        private AppConfigInnerClass()
        {
            Server = ConfigurationManager.AppSettings["server"];
            DataBase = ConfigurationManager.AppSettings["database"];
            UserId = ConfigurationManager.AppSettings["uid"];
            PassWord = ConfigurationManager.AppSettings["pwd"];
        }

        //获取唯一实例
        public static AppConfigInnerClass GetInstance()
        {
            return AppConfigHolder.appConfig;
        }

    }
}