<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SaveAttribute.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    送出資料給自己，value沒有被保存下來
    <form id="form1" runat="server">
        <div>
            <form action="WebForm1.aspx" method="post">
                <input type="text" value="" />
                <input type="submit" value="send" />
            </form>
        </div>
    </form>
</body>
</html>
