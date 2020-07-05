<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2_DropDownList.aspx.cs" Inherits="CS_demo32.WebForm2_DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            啟用AutoPostBack先不勾<br />
            選擇資料來源<br />
            後續步驟詳見圖片<br />
            修改SelectIndexChange事件<br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="No" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SchoolConnectionString %>" SelectCommand="SELECT [No], [Name], [Age], [Major] FROM [Student]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
