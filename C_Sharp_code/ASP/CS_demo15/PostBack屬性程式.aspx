<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBack屬性程式.aspx.cs" Inherits="CS_demo15.PostBack屬性程式" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    </br>
    --------------------------------
    </br>
    當用戶第一次向伺服器發動頁面要求，頁面Page_Load事件方法會被執行Not Page.IsPostBack</br>
    條件成立，所以清單元件資料會被填滿
    </br></br>
    伺服器傳回資料頁面回瀏覽器
    </br></br>
    當用戶端點選清單改變選項然後按傳送按扭回伺服器
    </br></br>
    伺服器頁面Page_Load事件方法會被再執行Not Page.IsPostBack</br>
    條件不成立，因此填滿清單程式碼就不會再執行
    </br></br>
    --------------------------------
    </br>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Height="208px" Width="246px" AutoPostBack="True"></asp:ListBox>
        </div>
    </form>
</body>
</html>
