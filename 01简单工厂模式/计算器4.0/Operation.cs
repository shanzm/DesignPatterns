using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器4._0
{
    public abstract class Operation
    {
        private double _numA;
        private double _numB;

        public double NumA { get; set; }
        public double NumB { get; set; }


        public abstract double GetResult();
 
    }
}
