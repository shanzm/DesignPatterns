using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03单例模式_读取配置文件
{
    class Program
    {
        static void Main(string[] args)
        {
            AppConfig appConfig1 = AppConfig.GetInstance();
            string connectionString = $"server={appConfig1.Server},database={appConfig1.DataBase},uid ={appConfig1.UserId},pwd ={appConfig1.PassWord}";
            Console.WriteLine(connectionString);
      
            AppConfig appConfig2 = AppConfig.GetInstance();

            Console.WriteLine(object.ReferenceEquals(appConfig1, appConfig2));//print:true。即系统中的appConfig对象是同一个

            Console.ReadKey();
        }
    }
}
