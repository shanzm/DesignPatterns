using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器4._0
{
    public class Operation
    {
        private double _numA;
        private double _numB;

        public double NumA { get; set; }
        public double NumB { get; set; }


        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
