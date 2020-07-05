<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="呼叫伺服器端頁面方法.aspx.cs" Inherits="CS_demo32.呼叫伺服器端頁面方法" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入Html標籤text、submit<br />
        2.撰寫後置程式碼<br />
        3.加入ScriptManager擴充功能<br />
        4.按鈕加上onclick<br />
        5.ScriptManager標籤加上EnablePageMethods=&quot;True&quot;(可呼叫Page方法)<br />
        6.撰寫javascript<br />
        --------------------------------------------<br />
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="True">
        </asp:ScriptManager>
        <br />
        <div>
            <input id="Text1" type="text" value="" />
            <input id="Submit1" type="submit" value="submit" onclick="MyClick()" />
        </div>
        <script type="text/javascript">
            //要能夠呼叫頁面的靜態函式要滿足幾個條件:
            //1.函式必須是靜態函式
            //2.函式必須加上WebMethodAttribute
            //3.ScriptManager的EnablePageMethods屬性的值必須為True
            //script端的呼叫函式方法為，PageMethods.函式名稱(參數1, 參數2, 成功時的Callback, 失敗的Callback, UserContext)
            //成功的Callback函式簽名為，函式名稱(回傳值, UserContext, 呼叫的函式名稱)
            //失敗的Callback函式簽名為，函式名稱(錯誤描述物件)


            function MyClick() {
                //回呼(CallBack)
                //呼叫伺服器端的方法後必須回呼;把呼叫GetTim()的結果傳到
                PageMethods.GetTime(Complete);
            }
            function Complete(result, context, methodName) {
                alert(result.toString());
                var txt = $get('Text1');
                alert(txt);
                txt.value = result.toString();
                alert(txt.value);
                //為何顯示不出來??
            }
        </script>
    </form>
</body>
</html>
