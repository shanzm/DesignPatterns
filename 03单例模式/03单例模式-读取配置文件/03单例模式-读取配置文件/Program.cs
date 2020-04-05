using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace _03单例模式_读取配置文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //单线程创建单例对象
            CreateAppConfig();
            //多线程创建单例对象
            //CreateAppConfig2();
            //AsyncCreateAppConfigWithLock();
        }

        //单线程
        private static void CreateAppConfig()
        {
            AppConfigStatic appConfig1 = AppConfigStatic.GetInstance();
            string connectionString = $"server={appConfig1.Server},database={appConfig1.DataBase},uid ={appConfig1.UserId},pwd ={appConfig1.PassWord}";
            Console.WriteLine(connectionString);

            AppConfigStatic appConfig2 = AppConfigStatic.GetInstance();

            Console.WriteLine(object.ReferenceEquals(appConfig1, appConfig2));//print:true。即系统中的appConfig对象是同一个

            Console.ReadKey();
        }

        //多个线程同时创建AppConfig对象
        private static void CreateAppConfig2()
        {

            AppConfigStatic appConfig1 = null;
            AppConfigStatic appConfig2 = null;
            Action createA = () => appConfig1 = AppConfigStatic.GetInstance();
            Action createB = () => appConfig2 = AppConfigStatic.GetInstance();
            Parallel.Invoke(createA, createB);

            Console.WriteLine(object.ReferenceEquals(appConfig1, appConfig2));
            //print:false。即系统中的appConfig对象不是同一个
            //注意这里有时可能是true,即  Parallel.Invoke(createA, createB）中的两委托执行可能存在时间差
            //注意你使用异步是无法模拟出false的，因为异步不是同时去执行GetInstance（）
            Console.ReadKey();
        }

        //对AppConfig对象的GetInstance加锁
        private static void AsyncCreateAppConfigWithLock()
        {
            AppConfigWithLock appConfig1 = null;
            AppConfigWithLock appConfig2 = null;
            Action createA = () => appConfig1 = AppConfigWithLock.GetInstance();
            Action createB = () => appConfig2 = AppConfigWithLock.GetInstance();
            Parallel.Invoke(createA, createB);

            Console.WriteLine(object.ReferenceEquals(appConfig1, appConfig2));

            Console.ReadKey();
        }
    }
}
