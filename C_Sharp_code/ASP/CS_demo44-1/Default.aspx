<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_demo44_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1.加入按鈕及文字控制項，用MD5將密碼編碼<br />
            2.將專案加入IIS中，啟用表單驗證<br />
            3.透過按鈕產生的編碼字串在Web.config中設定<br />
            4.Login控制項&gt;Authenticate事件<br />
            5.Default.aspx網頁&gt;加入LoginName控制項、LoginStatus控制項<br />
            <asp:TextBox ID="TextBox1" runat="server" Text="1234"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="MD5" OnClick="Button1_Click" />
            <br />
            <asp:LoginName ID="LoginName1" runat="server" />
            <asp:LoginStatus ID="LoginStatus1" runat="server" />
        </div>
    </form>
</body>
</html>
