using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00父类调用子类中覆盖的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ///子类覆盖父类中的方法，当声明为父类对象（尽管指向的是一个子类对象），但是执行被子类覆盖的方法依旧是父类中定义的方法体
            ///声明为子类对象，调用被重写的方法则执行的就是覆盖后的方法

            A b = new B();

            b.Do();//print:A.Do
            ((B)b).Do();//print:B.Do


            b.Do2();//print:A.Do
            ((B)b).Do2();//print:A.Do
            //这里就是我之前迷惑的地方：之前我认为B中覆盖了Do,而Do2调用Do方法，所以一个子类对象执行Do2应该是执行了覆盖的Do
            //但是事实上并没有，Do2执行依旧是父类定义而Do而不是子类中覆盖的Do
            //因为编译的时候，程序并不知道你在子类中对Do覆盖了

            Console.ReadKey();
        }
    }

    public class A
    {
        public void Do()
        {
            Console.WriteLine("A.Do");
        }

        public void Do2()
        {
            this.Do();
        }
    }

    public class B : A
    {
        public new void Do()
        {
            Console.WriteLine("B.Do");
        }
    }
}
