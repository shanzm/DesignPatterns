using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 计算器3.0中你已经使用类对业务逻辑进行封装了
/// 但是你若是要是想要添加一个新的运算符则要对operation类进行修改
/// 其实这样是不安全的，万一你添加新的运算符的时候把原来的运算符的操作代码修改错了
/// 这样岂不是对项目代码很不安全！
/// 所以你可以把所有的运算符分别单独定义一个类，这样你就可以随意添加和修改某一个新的运算符
/// 但是这时候问题又来了，主程序怎么判断要建哪一个运算符的对象
/// 所以需要一个工厂类来判断建什么对象
/// 在工厂类中。我们使用里氏原则。
/// 先新建一个运算符的父类对象，根据用户输入判断新建什么具体的运算符对象
/// </summary>

namespace 计算器4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter operation");
                string operation = Console.ReadLine();

                Operation oper = OperationFactory.CreateOperation(operation);

                Console.WriteLine("enter a number");
                oper.NumA = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("enter another number");
                oper.NumB = Convert.ToDouble(Console.ReadLine());



                double result = oper.GetResult();
                Console.WriteLine($"运算结果:{result.ToString()}");
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
