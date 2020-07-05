<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="表單驗證Credentials設定.aspx.cs" Inherits="CS_demo44.表單驗證Credentials設定" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1.加入Login控制項<br />
            2.專案加入IIS&gt;啟用表單驗證<br />
            3.撰寫Web.config&gt;credentials<br />
            4.Login控制項&gt;Authenticate事件<br />
            5.加入Default.aspx網頁&gt;加入LoginName控制項、LoginStatus控制項<br />
            ---------------------------------------------------------<asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
            </asp:Login>
        </div>
    </form>
</body>
</html>
