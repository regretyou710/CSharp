<%@ Page Language="C#" AutoEventWireup="true"%>

<!DOCTYPE html>
<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToLongTimeString();
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Time:<asp:Label ID="Label1" runat="server" Text="Show The Time"></asp:Label>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
