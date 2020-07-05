using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CS_demo48
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "I網站加入服務參考使用WCF服務"。
    [ServiceContract]
    public interface I網站加入服務參考使用WCF服務
    {
        [OperationContract]
        double Add(double a, double b);
        [OperationContract]
        double Subtract(double a, double b);
        [OperationContract]
        double Multiply(double a, double b);
        [OperationContract]
        double Divide(double a, double b);
    }
}
