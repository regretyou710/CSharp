<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用LINQtoXML語法動態顯示資料.aspx.cs" Inherits="CS_demo39.使用LINQtoXML語法動態顯示資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">        
        1.加入XmlDataSource、GridView控制項<br />
        2.撰寫後置程式碼<br />
        &nbsp;-----------------------<br />
        <div>
            <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
