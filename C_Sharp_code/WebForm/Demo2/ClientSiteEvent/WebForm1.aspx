<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClientSiteEvent.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        function checkDate() {
            var d = document.getElementById('TextBox1').value;
            var str = d.split('/');
            if (str[1] >= 1 && str[1] <= 12 && str[2] >= 1 && str[2] <= 31) {
                alert('Correct');
            } else {
                alert('Error');
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
       <p>
            請輸入出生日期:</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="傳送" OnClientClick="checkDate()" />
    </form>
</body>
</html>
