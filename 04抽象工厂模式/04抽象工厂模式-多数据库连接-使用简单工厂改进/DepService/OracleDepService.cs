using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04抽象工厂模式_多数据库连接_使用简单工厂改进
{
    class OracleDepService : IDepartmentService
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine($"Oracle数据库Department表中-查询到部门,Id:{id}");
            return null;
        }

        public void Insert(Department dep)
        {
            Console.WriteLine($"Oracle数据库Department表中-添加新的部门,Id:{dep.Id },Name:{dep.Name}");
        }
    }
}