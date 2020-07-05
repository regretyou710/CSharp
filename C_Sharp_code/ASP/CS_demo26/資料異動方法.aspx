<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="資料異動方法.aspx.cs" Inherits="CS_demo26.資料異動方法" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.使用DataAdapter讀取資料<br />
        2.新增一筆資料到DataSet<br />
        3.將資料傳回資料庫<br />
        4.將最新資料顯示在瀏覽器上<br />
        ------------------------<br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="Reader" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Style="height: 27px" Text="Count(*)" />
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Insert" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
