﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Server.aspx.cs" Inherits="CS_demo06.Server" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="MapPath" />
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="HTML Encode" />
        </div>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Transfer" />
    </form>
</body>
</html>
