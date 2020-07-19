using System;

namespace _01使用不同数据库的模版方法
{
    class Program
    {
        static void Main(string[] args)
        {
            DBOperator sqlServerDBOperator = new SQLServerDBOperator();
            DBOperator oracleDBOperator = new OracleDBOperator();

            sqlServerDBOperator.Process();//注意这里，我们定义的钩子方法是虚方法，通过重写，实现子类控制父类，这里是不需要将强转为子类对象
            Console.WriteLine("---------------------------");

            oracleDBOperator.Process();
            Console.WriteLine("---------------------------");

            ((OracleDBOperator)oracleDBOperator).Process(); //这里是通过覆盖父类中的方法，所以需要将父类强转为相应的子类对象
            Console.WriteLine("---------------------------");

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

        //钩子方法：用于子类反向控制父类中某个方法是否执行
        //注意钩子方法这里定义为虚方法，虚方法和抽象方法不同的地方就是虚方法有方法体，这样我们就可以在虚方法中定义默认的方法
        public virtual bool IsStart()
        {
            return true;//默认为true所以在具体子类中重写
        }

        //模版方法：定义算法骨架
        //确定其他基本方法的执行顺序
        public void Process()
        {
            ConnDB();
            OpenDB();
            if (IsStart())
            {
                UseDB();
            }
            CloseDB();
        }

    }

    //具体子类1
    public class OracleDBOperator : DBOperator
    {
        public override void ConnDB()
        {
            Console.WriteLine("连接Oracle数据库");
        }

        //按照面向对象的思想，我们可以在子类中使用new 关键字覆盖父类中的方法
        //注意：
        //1. 这里覆盖了UseDB(),是不够的,还要覆盖调用这个方法的方法Process()
        //2. 若是父类引用指向子类对象，则需要将父类转化为子类对象才可以使用子类中覆盖的方法
        public new void UseDB()
        {
            Console.WriteLine("使用Oracle数据库");
        }

        public new void Process()
        {
            ConnDB();
            OpenDB();
            if (IsStart())
            {
                UseDB();
            }

            CloseDB();
        }
    }

    //具体子类2
    public class SQLServerDBOperator : DBOperator
    {
        ///具体子类继承抽象父类，重写抽象父类中的抽象方法
        ///抽象父类中的非抽象方法就是每个子类都通用的方法，
        public override void ConnDB()
        {
            Console.WriteLine("连接SQL Server数据库");
        }

        public override bool IsStart()//覆盖了钩子函数，修改了抽象父类中模版方法，实现子类反向控制父类
        {
            return false;
        }

      
    }
}


///补充一点语法：
///抽象类中可以有非抽象方法，抽象方法只能在抽象类中
///非静态类可以包含静态方法，但静态类不能包含非静态方法。
///换言之：静态类只能有静态方法，静态方法不仅可以在静态类中也可以在非静态方法中
///

///虚方法（virtual）和抽象方法（abstract）都可以被重写（override）
///虚方法（virtual)有方法实体，抽象方法(abstract)没有方法实体【类似接口】
///虚方法（virtual)在派生类中可以不重写，抽象方法(abstract)派生类中必须重写【类似接口】
///抽象方法(abstract)必须声明在抽象类中
