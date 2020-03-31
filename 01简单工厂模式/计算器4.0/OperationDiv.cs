#region Version Info 
// ===============================================================================
// Project Name        :    计算器4._0  
// ===============================================================================
// Class Name          :    OperationDiv
// Namespace           :    计算器4._0 
// Class Version       :    v1.0.0.0
// Class Description   : 
// CLR                 :    4.0.30319.42000  
// Author              :    shanzm
// Create Time         :    2019/1/22 3:09:36
// Update Time         :    2019/1/22 3:09:36
// ===============================================================================
// Copyright © SHANZM-PC  2019 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器4._0
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
