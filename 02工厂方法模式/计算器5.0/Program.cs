using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个具体的工厂对象：加法工厂对象
            IFactory addFactory = new AddFactory();
            //使用加法工厂对象创建加法运算类
            Operation addOper = addFactory.CreateOperation();

            addOper.NumA = 2;
            addOper.NumB = 3;
            Console.WriteLine(addOper.GetResult());//print:5
            Console.ReadKey();
        }
    }
}
