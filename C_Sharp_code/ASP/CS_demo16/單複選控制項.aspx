<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="單複選控制項.aspx.cs" Inherits="CS_demo16.單複選控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        在checkboxlist和radiobuttionlist屬性的集合加入項目,可在repeatdiretion設定水平垂直<br />
            <br />
            沒有做送出按鈕所以用修改AutoPostBack屬性方式呈現結果<br />
        <br />
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="16px" Width="314px" AutoPostBack="True" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Value="1">鍵盤</asp:ListItem>
                <asp:ListItem Value="2">滑鼠</asp:ListItem>
                <asp:ListItem Value="3">喇叭</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
                <asp:ListItem Value="1">C#</asp:ListItem>
                <asp:ListItem Selected="True" Value="2">JAVA</asp:ListItem>
                <asp:ListItem Value="3">Python</asp:ListItem>
            </asp:RadioButtonList>
            <br />
        </div>
    </form>
</body>
</html>
