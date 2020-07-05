<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="伺服器端事件處理程序流程.aspx.cs" Inherits="CS_demo12.伺服器端事件處理程序流程" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ※ 網頁包含文字輸入及傳送按鈕<br />
            ※ 程式包含了伺服器端驗證文字輸入資料是否有效<br />
            ※ 用戶輸入無效的生日日期然後送至後端伺服器驗證是否有效，如果無效的話則顯示錯誤訊息<br />
            -----------------------------------<br />
            請輸入出生日期<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="傳送" />
        </div>
    </form>
</body>
</html>
