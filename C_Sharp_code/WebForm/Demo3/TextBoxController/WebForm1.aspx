<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TextBoxController.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    在控制向中的"屬性"修改屬性
    <form id="form1" runat="server">
        <div>
            帳戶名稱:<asp:TextBox ID="TxtName" runat="server" ForeColor="Red">張小明</asp:TextBox>
            <br />
            帳戶密碼:<asp:TextBox ID="TxtPwd" runat="server" BackColor="Aqua" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="確定" />
        </div>
    </form>
</body>
</html>
