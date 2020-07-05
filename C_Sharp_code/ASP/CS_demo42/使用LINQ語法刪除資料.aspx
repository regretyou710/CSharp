<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用LINQ語法刪除資料.aspx.cs" Inherits="CS_demo42.使用LINQ語法刪除資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">1.加入GridView控制項<br/>
        2.專案新增項目&gt;LINQ TO SQL類別&gt;拖曳資料表到畫面中<br />
        3.撰寫後置程式碼<br />
        4.加入按鈕<br />
        5.撰寫後置程式碼<br/>
        --------------------------<br/>
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="新增" />
        <asp:Button ID="Button2" runat="server" Text="修改" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="ProductID:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="131px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="ProductName:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="131px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="UnitPrice:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Height="16px" Width="131px"></asp:TextBox>
        <br />        
        <asp:Label ID="Label4" runat="server" Text="Discontinued:"></asp:Label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Height="35px" Width="188px">
            <asp:ListItem Selected="True" Value="true">TRUE</asp:ListItem>
            <asp:ListItem Value="false">FALSE</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="Button3" runat="server" Text="修改" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="ProductID:"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" Height="16px" Width="131px"></asp:TextBox>
        <br />
        <asp:Button ID="Button4" runat="server" Text="刪除" OnClick="Button4_Click" />
    </form>
</body>
</html>
