using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟日志记录器
{
    public class FileLogFactory : ILogFactory
    {
        public ILog CreateLog()
        {
            return new FileLog();
        }
    }
}