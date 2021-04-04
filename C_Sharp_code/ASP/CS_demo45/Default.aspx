<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_demo45.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LoginName ID="LoginName1" runat="server" />
        </div>
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <br />
        或是在當前路徑切換到/SecuredFile/Protected.aspx<br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="訪問目錄資源" />
    </form>
</body>
</html>
