<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("修改為<%@ Page Language='C#' AutoEventWireup='true' %>");
        Response.Write("</br>");
        Response.Write("刪除WebForm1.aspx底下的WebForm1.aspx.cs,WebForm1.aspx.designer.cs");
        Response.Write("</br>");
        Response.Write("單檔案（畫面及程式在同一個畫面）");
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>單檔案（畫面及程式在同一個畫面）</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
