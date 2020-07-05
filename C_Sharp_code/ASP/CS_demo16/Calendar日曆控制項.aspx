<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar日曆控制項.aspx.cs" Inherits="CS_demo16.Calendar日曆控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        -----------------------------------<br />
        改變Calendar屬性中的TodayDayStyle,NextMonthText,PrveMonthText<br />
        設定事件DayDender,SelectionChanged<br />
        <div>
            <asp:Calendar ID="Calendar1" runat="server" Height="392px" NextMonthText="下個月" OnSelectionChanged="Calendar1_SelectionChanged" PrevMonthText="上個月" Width="690px" OnDayRender="Calendar1_DayRender">
                <TodayDayStyle BackColor="#00FFCC" Font-Bold="True" ForeColor="Red" />
            </asp:Calendar>
        </div>
    </form>
</body>
</html>
