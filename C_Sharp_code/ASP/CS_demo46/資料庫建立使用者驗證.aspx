<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="資料庫建立使用者驗證.aspx.cs" Inherits="CS_demo46.資料庫建立使用者驗證" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.系統管理員執行C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Visual Studio 2019\Visual Studio Tools\Developer Command Prompt for VS 2019<br />
&nbsp;&nbsp; 命令列 C:\Program Files (x86)\Microsoft Visual Studio\2019\Community&gt;aspnet_regsql(詳見圖)<br />
        2.專案加入IIS<br />
        3.加入Login控制項、Default.aspx、LoginName控制項、LoginStatus控制項<br />
        4.編輯Web.config(照著影片key的)<br />
        5.ASP組態舊版(詳見圖123_8至123_15)<br />
		5.ASP組態新版版(詳見圖123_16至123_19)<br />
        http://localhost/CS_demo46/asp.netwebadminfiles/security<br />
        --------------------------------------- <div>
            <asp:Login ID="Login1" runat="server">
            </asp:Login>
        </div>
    </form>
</body>
</html>
