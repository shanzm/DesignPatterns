namespace 计算器5._0
{

    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = this.NumA - this.NumB;
            return result;
        }
    }

}
