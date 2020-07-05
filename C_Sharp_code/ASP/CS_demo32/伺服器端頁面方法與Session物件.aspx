<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="伺服器端頁面方法與Session物件.aspx.cs" Inherits="CS_demo32.伺服器端頁面方法與Session物件" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.ScriptManager標籤加上EnablePageMethods=&quot;True&quot;(可呼叫Page方法)<br />
        <>寫一個類別方法儲存Session狀態資料值<br />
        <>在前端aspx頁面上寫JavaScript;完成或是失敗儲存狀態資料值時顯示訊息<br />
        <>最後測試在另一個頁面上讀取此Session狀態資料值<br />
        --------------------------------------------<br />
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
            </asp:ScriptManager>
            <input id="Button1" type="button" value="WriteSession" onclick="Save()" />
            <input id="Button2" type="button" value="ReadSession" onclick="Read()" /><br />
        </div>

        <script type="text/javascript">
            //script端的呼叫函式方法為，PageMethods.函式名稱(參數1, 參數2, 成功時的Callback, 失敗的Callback, UserContext)
            function Save() {
                PageMethods.WriteSession("Hello Page Methods data",onSuccess,onError);
            }
            function onSuccess(result, context, methodName) {
                alert('Done');
            }
            function onError(result, context, methodName) {
                alert(result.get_message());
            }
            function Read() {
                PageMethods.ReadSession(onSuccess1, onError);
            }
            function onSuccess1(result, context, methodName) {
                alert(result.toString());
            }
            
        </script>
    </form>
</body>
</html>
