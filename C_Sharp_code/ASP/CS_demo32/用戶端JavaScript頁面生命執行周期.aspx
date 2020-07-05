<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="用戶端JavaScript頁面生命執行周期.aspx.cs" Inherits="CS_demo32.用戶端JavaScript頁面生命執行周期" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            1.加入ScriptManager擴充功能<br />
            2.script標籤需寫在form標籤內,因script裡面會宣告Sys.Application.add_init(Init)<br />
            3.pageUnload在離開當前網站時執行
            --------------------------------------------<br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        <script type="text/javascript">
            Sys.Application.add_init(Init);
            function Init() {
                alert('Page Init');
            }
            function pageLoad() {
                alert('Page Load');
            }
            function pageUnload() {
                alert('Page Unload');
            }
        </script>
    </form>
</body>
</html>
