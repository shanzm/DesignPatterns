using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//某系统日志记录器要求支持多种日志记录方式，如文件日志记录（FileLog）、数据库日志记录（DatabaseLog）等，
//且用户可以根据要求动态选择日志记录方式，现使用工厂方法模式设计该系统。


//分析：定义Log接口（这里你定义为抽象也是同样的道理，但是我就要使用接口），FileLog产品类，DatabaseLog产品类都实现该接口
//定义LogFactory接口，FileLogFactory工厂类和DatabaseLogFactory工厂类都实现该接口

namespace 模拟日志记录器
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个具体的工厂对象：FileLogFactory
            ILogFactory logFac = new FileLogFactory();
            //由工厂对象，创建产品对象：FileLog
            //FileLog log = logFac.CreateLog() as FileLog;
            ILog log = logFac.CreateLog();

            log.WriteLog();//print:记日志于日志文件中

            Console.ReadKey();
        }
    }
}
