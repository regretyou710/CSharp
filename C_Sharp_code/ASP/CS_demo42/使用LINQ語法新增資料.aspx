<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用LINQ語法新增資料.aspx.cs" Inherits="CS_demo42.使用LINQ語法新增資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入GridView控制項<br/>
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
    </form>
</body>
</html>
