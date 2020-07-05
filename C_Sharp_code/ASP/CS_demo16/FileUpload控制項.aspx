<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload控制項.aspx.cs" Inherits="CS_demo16.FileUpload控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" EnableTheming="True" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="上傳" />
        </div>
    </form>
</body>
</html>
