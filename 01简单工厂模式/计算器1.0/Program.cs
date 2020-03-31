using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Console;


namespace 计算器1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            double numA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter another number");
            double numB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter operation");
            string oper = Console.ReadLine();

            double result=0;

            switch (oper)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                 result= numB != 0 ? numA/numB : 0;
                    break;
                //default:result = 0;
                //    break;
            }


            Console.WriteLine(result.ToString ());
            Console.ReadKey();
        }
    }
}
