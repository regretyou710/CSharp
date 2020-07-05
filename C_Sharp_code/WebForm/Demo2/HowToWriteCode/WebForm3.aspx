<%@ Page Language="C#" AutoEventWireup="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>混合程式碼</title>
</head>
<body>
    混合程式碼
    <form id="form1" runat="server">
        <div>
            Time:<%=DateTime.Now.ToLongTimeString() %>
        </div>
    </form>
</body>
</html>
