using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03单例模式_读取配置文件
{
    class AppConfigExtend
    {
        //定义字典类型字段保存所有的实例
        private static Dictionary<int, AppConfigExtend> dic = new Dictionary<int, AppConfigExtend>();

        //定义key
        private static int key = 1;

        //定义最大的实例数
        private static int MaxInstance = 3;


        //对应配置文件设置相应的属性，注意是只读的
        public string Server { private set; get; }
        public string DataBase { private set; get; }
        public string UserId { private set; get; }
        public string PassWord { private set; get; }

        //私有化构造函数
        private AppConfigExtend()
        {
            Server = ConfigurationManager.AppSettings["server"];
            DataBase = ConfigurationManager.AppSettings["database"];
            UserId = ConfigurationManager.AppSettings["uid"];
            PassWord = ConfigurationManager.AppSettings["pwd"];
        }

        //类外方法访问实例的访问点
        public static AppConfigExtend GetInstance()
        {
            if (!dic.ContainsKey(key))
            {
                dic.Add(key, new AppConfigExtend());
            }
            AppConfigExtend appConfig = dic[key];
            key++;
            if (key > MaxInstance)
            {
                key = 1;
            }
            return appConfig;
        }
    }
}