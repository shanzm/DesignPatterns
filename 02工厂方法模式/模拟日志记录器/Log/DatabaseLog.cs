using System;

namespace 模拟日志记录器
{
    public class DatabaseLog : ILog
    {
        public void WriteLog()
        {
            Console.WriteLine("记录日志于日志数据库中");
        }
    }
}