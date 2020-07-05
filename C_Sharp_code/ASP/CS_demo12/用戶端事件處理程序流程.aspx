<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="用戶端事件處理程序流程.aspx.cs" Inherits="CS_demo12.用戶端事件處理程序流程" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script type="text/javascript">
        function checkDate() {
            var dt = document.getElementById('TextBox1').value;
            var str = dt.split('/');
            //判斷日與月是否合法
            if (str[1] >= 1 && str[1] <= 12 && str[2] >= 1 && str[2] <= 31)
                alert(str[1] + '\n' + str[2] + '\ncorrect');
            else
                alert(str[1] + '\n' + str[2] + '\nerror');
        }
    </script>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            ※ 網頁包含文字輸入及傳送按鈕<br />
            ※ 程式包含了用戶端驗證文字輸入資料是否有效<br />
            ※ 用戶輸入無效的生日日期，然後顯示錯誤訊息<br />
            -----------------------------------<br />
            請輸入出生日期<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClientClick="checkDate()" Text="傳送" />
        </div>
    </form>
</body>
</html>
