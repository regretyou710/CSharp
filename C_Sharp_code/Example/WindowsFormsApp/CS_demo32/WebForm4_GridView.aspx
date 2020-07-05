<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4_GridView.aspx.cs" Inherits="CS_demo32.WebForm4_GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" Height="238px" Width="458px">
            </asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="學生資料" Width="86px" />
    </form>
</body>
</html>
