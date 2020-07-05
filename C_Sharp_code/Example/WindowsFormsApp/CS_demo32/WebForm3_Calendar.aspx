<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3_Calendar.aspx.cs" Inherits="CS_demo32.WebForm3_Calendar" %>

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
        <asp:Calendar ID="Calendar1" runat="server" Height="300px" NextMonthText="下個月" OnSelectionChanged="Calendar1_SelectionChanged" PrevMonthText="上個月" SelectionMode="DayWeek" SelectWeekText="選擇週" Width="554px"></asp:Calendar>
    </form>
</body>
</html>
