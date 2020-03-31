#region Version Info 
// ===============================================================================
// Project Name        :    计算器4._0  
// ===============================================================================
// Class Name          :    OperationFactory
// Namespace           :    计算器4._0 
// Class Version       :    v1.0.0.0
// Class Description   : 
// CLR                 :    4.0.30319.42000  
// Author              :    shanzm
// Create Time         :    2019/1/22 3:14:02
// Update Time         :    2019/1/22 3:14:02
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
    public class OperationFactory
    {
        public static Operation CreateOperation(string operation)
        {
            Operation oper = null;
            switch (operation)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }
    }
}
