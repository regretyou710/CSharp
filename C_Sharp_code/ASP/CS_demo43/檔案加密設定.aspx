<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="檔案加密設定.aspx.cs" Inherits="CS_demo43.檔案加密設定" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1.加入SqlDataSource控制項<br />
            2.設定資料來源&gt;在Web.Config設定檔案加入資料庫連線字串<br />
            3.將連線字串加密(以系統管理員執行命令提示字元，詳細圖片)<br />
              加密: C:\Program Files (x86)\Microsoft Visual Studio\2019\Community&gt;aspnet_regiis -pef &quot;connectionStrings&quot; D:\C_Sharp_code\ASP\CS_demo43<br />
              解密: C:\Program Files (x86)\Microsoft Visual Studio\2019\Community&gt;aspnet_regiis -pdf &quot;connectionStrings&quot; D:\C_Sharp_code\ASP\CS_demo43<br />
            4.寫一段程式讀取此加密字串資料<br />
            5.執行程式查看結果<br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [CustomerID], [CompanyName], [Phone], [ContactName] FROM [Customers]"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            -------------------------------</div>
    </form>
</body>
</html>
