using System;

namespace 计算器5._0
{
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (this.NumB == 0)
            {
                throw new Exception("除数不为0！");
            }
            result = this.NumA / this.NumB;
            return result;
        }
    }
}
