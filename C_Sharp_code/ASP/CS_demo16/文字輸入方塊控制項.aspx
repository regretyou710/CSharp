<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="文字輸入方塊控制項.aspx.cs" Inherits="CS_demo16.文字輸入方塊控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            帳戶名稱:<asp:TextBox ID="txtName" runat="server" ForeColor="Red">張三豐</asp:TextBox>
            <br />
            帳戶密碼:<asp:TextBox ID="txtPass" runat="server" BackColor="Aqua" TextMode="Password" value="1234"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
        </div>
    </form>
</body>
</html>
