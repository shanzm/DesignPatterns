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
            IFactory addFactory = new AddFactory();
            Operation addOper = addFactory.CreateOperation();

            addOper.NumA = 2;
            addOper.NumB = 3;
            Console.WriteLine(addOper.GetResult());//print:5
            Console.ReadKey();
        }
    }
}
