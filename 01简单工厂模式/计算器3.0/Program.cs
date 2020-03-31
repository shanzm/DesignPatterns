using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器3._0
{
    class Program
    {
        //让业务逻辑和界面逻辑分离
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter a number");
                double numA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter another number");
                double numB = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter operation");
                string oper = Console.ReadLine();

                Console.WriteLine(Operation.GetResult(numA, numB, oper).ToString());
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine("error:" + e.Message);
                Console.ReadKey();
            }

        }
    }
}
