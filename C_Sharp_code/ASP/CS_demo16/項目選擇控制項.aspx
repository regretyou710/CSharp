<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="項目選擇控制項.aspx.cs" Inherits="CS_demo16.項目選擇控制項" %>

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
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="109px">
                <asp:ListItem Selected="True" Value="1">First</asp:ListItem>
                <asp:ListItem Value="2">Second</asp:ListItem>
                <asp:ListItem Value="3">Third</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="113px" Width="109px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
