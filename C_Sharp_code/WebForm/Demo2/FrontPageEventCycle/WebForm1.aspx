<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FrontPageEventCycle.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    -----------------------------------
    </br>
    當ASP.NET頁面被請求服務時，有一連串的頁面事件會被執行
    </br>
    1.頁面初始畫</br>
    2.載入</br>
    3.驗證</br>
    4.PostBack事件攔截處理</br>
    5.畫面呈現</br>
    6.頁面卸載</br>
    -----------------------------------
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="檢視生命週期" />
        </div>
    </form>
</body>
</html>
