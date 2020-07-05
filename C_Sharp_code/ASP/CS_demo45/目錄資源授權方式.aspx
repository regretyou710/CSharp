<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="目錄資源授權方式.aspx.cs" Inherits="CS_demo45.目錄資源授權方式" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.專案加入IIS&gt;啟用表單驗證<br />
        2.撰寫Web.config&gt;credentials、location<br />
        3.專案中加入資料夾SecuredFile&gt;protected.aspx<br />
        4.加入Default.aspx網頁&gt;加入LoginName控制項、LoginStatus控制項<br />
        5.加入Login控制項、Authenticate事件<br />
        6.只有admin可以訪問location/SecuredFile/protected.aspx<br />
        eason會被導回登入頁
        <div>
            ---------------------------------------
        </div>
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate">
        </asp:Login>
    </form>
</body>
</html>
