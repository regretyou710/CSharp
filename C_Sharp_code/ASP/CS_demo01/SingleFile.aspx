<%@ Page Language="C#" AutoEventWireup="true"%>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("SingleFile");
    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            ------------------------<br />
            1. 刪除原始檔表頭宣告中:CodeBehind="CodeBehind.aspx.cs" Inherits="CS_demo01.CodeBehind"
            <br />
            2. 刪除aspx建立所產生的2個cs檔<br />
            3. button點兩下進入事件撰寫</div>        
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
