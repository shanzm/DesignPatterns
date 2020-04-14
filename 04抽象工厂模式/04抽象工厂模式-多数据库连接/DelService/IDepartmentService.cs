using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04抽象工厂模式_多数据库连接
{
    public interface IDepartmentService
    {
        void Insert(Department dep);
        Department GetDepartment(int id);
    }
}
