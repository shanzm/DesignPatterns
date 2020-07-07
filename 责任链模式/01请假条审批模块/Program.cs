using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01请假条审批模块
{
    class Program
    {
        ///使用责任链模式模拟请假审批模块(案例来源：C语言中文网-设计模式)
        ///假如规定学生请假小于或等于 2 天，班主任可以批准；小于或等于 7 天，系主任可以批准；小于或等于 10 天，院长可以批准；其他情况不予批准。
        ///抽象处理者：领导（Leader）
        ///具体处理者：班主任-->系主任-->院长

        static void Main(string[] args)
        {
            //组装责任链（创建责任链）
            Leader teacher1 = new ClassAdviser();
            Leader teacher2 = new DepartmentHead();
            Leader teacher3 = new Dean();

            teacher1.SetNext(teacher2);
            teacher2.SetNext(teacher3);

            teacher1.HandleRequest(1);//print: 班主任批准您请假1天
            teacher1.HandleRequest(5);//print：系主任批准您请假5天
            teacher2.HandleRequest(8);//print: 院长批准您请假8天

            Console.ReadKey();
        }
    }

    //抽象处理者：领导
    public abstract class Leader
    {
        private Leader next;
        //设置本处理者的下一个处理者
        public void SetNext(Leader next)
        {
            this.next = next;
        }
        //获取本处理者的下一个处理者，即继任者
        public Leader GetNext()
        {
            return next;
        }
        //处理请求的抽象方法
        public abstract void HandleRequest(int LeaveDays);
    }

    //具体处理者：班主任
    public class ClassAdviser : Leader
    {
        public override void HandleRequest(int LeaveDays)
        {
            if (LeaveDays <= 2)
            {
                Console.WriteLine($"班主任批准您请假{LeaveDays}天");
            }
            else
            {
                if (GetNext() != null)
                {
                    GetNext().HandleRequest(LeaveDays);
                }
                else
                {
                    Console.WriteLine("请假天数太多，无人批准该请假条！");
                }
            }
        }
    }

    //具体处理者：系主任
    public class DepartmentHead : Leader
    {
        public override void HandleRequest(int LeaveDays)
        {
            if (LeaveDays <= 7)
            {
                Console.WriteLine($"系主任批准您请假{LeaveDays}天");
            }
            else
            {
                if (GetNext() != null)
                {
                    GetNext().HandleRequest(LeaveDays);
                }
                else
                {
                    Console.WriteLine("请假天数太多，无人批准该请假条！");
                }
            }
        }
    }

    //具体处理者：院长
    public class Dean : Leader
    {
        public override void HandleRequest(int LeaveDays)
        {
            if (LeaveDays <= 20)
            {
                Console.WriteLine($"院长批准您请假{LeaveDays}天");
            }
            else
            {
                if (GetNext() != null)
                {
                    GetNext().HandleRequest(LeaveDays);
                }
                else
                {
                    Console.WriteLine("请假天数太多，无人批准该请假条！");
                }
            }
        }
    }
}
