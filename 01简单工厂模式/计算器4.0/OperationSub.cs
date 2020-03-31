#region Version Info 
// ===============================================================================
// Project Name        :    计算器4._0  
// ===============================================================================
// Class Name          :    OperationSub
// Namespace           :    计算器4._0 
// Class Version       :    v1.0.0.0
// Class Description   : 
// CLR                 :    4.0.30319.42000  
// Author              :    shanzm
// Create Time         :    2019/1/22 3:07:58
// Update Time         :    2019/1/22 3:07:58
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
