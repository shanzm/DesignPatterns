using System;

namespace 模拟日志记录器
{
    public class FileLog : ILog
    {
        public void WriteLog()
        {
            Console.WriteLine("记录日志于日志文件中");
        }
    }
}