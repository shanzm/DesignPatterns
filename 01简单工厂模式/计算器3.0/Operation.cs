#region Version Info 
// ===============================================================================
// Project Name        :    计算器3._0  
// ===============================================================================
// Class Name          :    Operation
// Namespace           :    计算器3._0 
// Class Version       :    v1.0.0.0
// Class Description   : 
// CLR                 :    4.0.30319.42000  
// Author              :    shanzm
// Create Time         :    2019/1/22 1:24:07
// Update Time         :    2019/1/22 1:24:07
// ===============================================================================
// Copyright © SHANZM-PC  2019 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器3._0
{
    public class Operation
    {
        public static double GetResult(double numA, double numB, string oper)
        {
            double result = 0;
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
                    result = numB != 0 ? numA / numB : 0;
                    break;
            }
            return result;
        }
    }
}
