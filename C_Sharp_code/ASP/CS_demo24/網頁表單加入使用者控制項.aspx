<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="網頁表單加入使用者控制項.aspx.cs" Inherits="CS_demo24.網頁表單加入使用者控制項" %>
<%@ Register src="~/轉換網頁表單成為使用者控制項.ascx" TagName="MyWeb" TagPrefix="ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        --------------------------<br/>
        1.加入指示詞@Register匯入使用者控制項<br/>
        2.其中TagName,TagPrefix(前導字元)自訂<br/>
        3.加入標籤<br/>
        4.在Page_Load 事件讀取使用者控制項屬性<br/>
        5.使用Response.Write傳回帳號及密碼<br/>
        --------------------------<br/>
        <div>
            <ascx:MyWeb ID="MyLogin" runat="server" />
        </div>
    </form>
</body>
</html>
