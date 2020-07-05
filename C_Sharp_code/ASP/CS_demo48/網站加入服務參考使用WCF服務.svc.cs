using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CS_demo48
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "網站加入服務參考使用WCF服務"。
    // 注意: 若要啟動 WCF 測試用戶端以便測試此服務，請在 [方案總管] 中選取 網站加入服務參考使用WCF服務.svc 或 網站加入服務參考使用WCF服務.svc.cs，然後開始偵錯。
    public class 網站加入服務參考使用WCF服務 : I網站加入服務參考使用WCF服務
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Divide(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Subtract(double a, double b)
        {
            return a / b;
        }
    }
}
