<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3_Calendar.aspx.vb" Inherits="VB_demo33.WebForm3_Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SelectionMode,SelectWeekText,PrevMonthText,NextMonthText屬性修改<br />
            SelectionChanged事件增加</div>
        <asp:Calendar ID="Calendar1" runat="server" Height="329px" NextMonthText="下個月" PrevMonthText="上個月" SelectionMode="DayWeek" SelectWeekText="選擇週" Width="611px"></asp:Calendar>
    </form>
</body>
</html>
