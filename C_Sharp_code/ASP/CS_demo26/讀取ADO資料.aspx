<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="讀取ADO資料.aspx.cs" Inherits="CS_demo26.讀取ADO資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入PlaceHolder控制項<br />
        2.<br />
        ------------------------<br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Reader" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="height: 27px" Text="Count(*)" />
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
        </div>
    </form>
</body>
</html>
