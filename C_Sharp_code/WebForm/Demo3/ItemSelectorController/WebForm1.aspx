<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ItemSelectorController.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>
        產生靜態的DropDownList,動態的ListBox<br />
        在DropDownList屬性設定Items集合</p>
    <p>
        DropDownList的項目ListBox做同步,將DropDownList事件SelectedIndexChange點兩下,將DropDownList屬性autopostback=true</p>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="17px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="88px">
                <asp:ListItem Selected="True" Value="1">First</asp:ListItem>
                <asp:ListItem Value="2">Second</asp:ListItem>
                <asp:ListItem Value="3">Third</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" Height="116px" Width="95px"></asp:ListBox>
    </form>
</body>
</html>
