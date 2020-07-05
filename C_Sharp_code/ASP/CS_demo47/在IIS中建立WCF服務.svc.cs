using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CS_demo47
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "在IIS中建立WCF服務"。
    // 注意: 若要啟動 WCF 測試用戶端以便測試此服務，請在 [方案總管] 中選取 在IIS中建立WCF服務.svc 或 在IIS中建立WCF服務.svc.cs，然後開始偵錯。
    public class 在IIS中建立WCF服務 : I在IIS中建立WCF服務
    {
        double I在IIS中建立WCF服務.Add(double a, double b)
        {
            return a + b;
        }

        double I在IIS中建立WCF服務.Divide(double a, double b)
        {
            return a - b;
        }

        double I在IIS中建立WCF服務.Multiply(double a, double b)
        {
            return a * b;
        }

        double I在IIS中建立WCF服務.Subtract(double a, double b)
        {
            return a / b;
        }
    }
}
