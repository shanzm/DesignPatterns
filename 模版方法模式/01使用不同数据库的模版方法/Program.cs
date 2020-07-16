using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01使用不同数据库的模版方法
{
    class Program
    {
        static void Main(string[] args)
        {
            DBOperator sqlServerDBOperator = new SQLServerDBOperator();
            DBOperator oracleDBOperator = new OracleDBOperator();

            sqlServerDBOperator.Process();
            Console.WriteLine("---------------------------");
            oracleDBOperator.Process();

            ((OracleDBOperator)oracleDBOperator).Process();

            Console.ReadKey();
        }
    }


    //抽象类
    public abstract class DBOperator
    {
        #region 说明
        ///注意这里我们不需要（但是是可以的）将全部方法定义为抽象方法
        ///为什么呢？若是定义为抽象方法则这些方法在抽象父类中都是没有方法体的
        ///所以我们需要在实现类中需要对抽象方法都重写
        ///而可能多个实现类中的某个方法实现是一样的。
        ///
        /// 所以使用模版方法模式的一个比孙策的思考点就是：哪些功能是不变，将不变的在父类中的实现
        /// 哪些功能是变的，将变的功能在父类中定义为抽象方法
        ///
        /// 这也就是为什么在这里定义为抽象类，而不是接口
        /// 这里也体现了接口和抽象类的不同之处：
        /// 接口约束实现接口的类行为（所以接口也称之为契约）
        /// 而抽象类不仅要约束子类的行为，而要要为子类提供公共方法体
        /// 
        ///这里连接函数ConnDB定义为抽象方法，因为每个数据库的连接方法是不一样的，
        ///所以在每个具体的实现类中都需要对其重写 
        #endregion

        //原语操作1
        public abstract void ConnDB();

        //原语操作2
        public void OpenDB()
        {
            Console.WriteLine("打开数据库");
        }

        //原语操作3
        public void UseDB()
        {
            Console.WriteLine("使用数据库");
        }

        //原语操作4
        public void CloseDB()
        {
            Console.WriteLine("关闭数据库");
        }

        //模版方法：定义算法骨架
        //确定其他基本方法的执行顺序
        public void Process()
        {
            ConnDB();
            OpenDB();
            UseDB();
            CloseDB();
        }

    }

    //具体子类1
    public class SQLServerDBOperator : DBOperator
    {
        ///具体子类继承抽象父类，重写抽象父类中的抽象方法
        ///抽象父类中的非抽象方法就是每个子类都通用的方法，
        public override void ConnDB()
        {
            Console.WriteLine("连接SQL Server数据库");
        }

    }

    //具体子类2
    public class OracleDBOperator : DBOperator
    {
        public override void ConnDB()
        {
            Console.WriteLine("连接Oracle数据库");
        }

        //按照面向对象的思想，我们可以在子类中使用new 关键字覆盖父类中的方法
        //注意：
        //1. 这里覆盖了UseDB(),是不够的，还要覆盖调用这个方法的方法Process()
        //2. 在这里我们
        public new void UseDB()
        {
            Console.WriteLine("使用Oracle数据库");
        }

        public new void Process()
        {
            ConnDB();
            OpenDB();
            UseDB();
            CloseDB();
        }

    }
}
