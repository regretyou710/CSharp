<%@ Page Language="vb"%>

<!DOCTYPE html>
<script runat ="server">

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Response.Write("這是內置程式碼 VB")
    End Sub
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
