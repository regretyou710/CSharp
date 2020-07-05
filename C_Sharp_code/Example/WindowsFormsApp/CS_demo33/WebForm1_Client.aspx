<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1_Client.aspx.cs" Inherits="CS_demo33.WebForm1_Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div>
            在同一個專案下客戶端呼叫服務端方法;<br />
            在專案右鍵加入服務參考-&gt;進階-&gt;加入WEB服務參考-&gt;解決方案中的WEB服務-&gt;加入參考<br />
            -----------------</div>
        <asp:GridView ID="GridView1" runat="server" Height="206px" Width="432px">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
