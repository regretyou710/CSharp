<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CheckBoxAndRadioController.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            在checkboxlist和radiobuttionlist屬性的集合加入項目,可在repeatdiretion設定水平垂直<br />
            <br />
            沒有做送出按鈕所以用修改AutoPostBack屬性方式呈現結果<br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                <asp:ListItem Selected="True" Value="1">JAVA</asp:ListItem>
                <asp:ListItem Value="2">C/C++</asp:ListItem>
                <asp:ListItem Value="3">C#</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="1">android</asp:ListItem>
            <asp:ListItem Selected="True" Value="2">ios</asp:ListItem>
            <asp:ListItem Value="3">nokia</asp:ListItem>
        </asp:RadioButtonList>
    </form>
</body>
</html>
