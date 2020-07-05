<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3_前後端互動.aspx.cs" Inherits="CS_demo31.WebForm3_前後端互動" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        var count = 0;
        function frmSubmit() {
            count++;
            if (count % 2 == 0) {
                alert('conut:' + count+'\nSubmit Go');
                return true;
            } else {
                alert('conut:' + count);
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
