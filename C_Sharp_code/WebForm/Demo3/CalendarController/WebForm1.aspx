<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalendarController.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="500px" ImageUrl="~/calendar.jpg" Width="650px" />
            <br />
            <asp:Image ID="Image2" runat="server" Height="500px" ImageUrl="~/calendar2.jpg" Width="650px" />
            <br />
            -----------------------------------<br />
            改變Calendar屬性中的TodayDayStyle,NextMonthText,PrveMonthText<br />
            設定事件DayDender,SelectionChanged<br />
            <asp:Calendar ID="Calendar1" runat="server" Height="257px" NextMonthText="下個月" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" PrevMonthText="上個月" Width="490px">
                <TodayDayStyle BackColor="Aqua" ForeColor="Red" />
            </asp:Calendar>
            <br />
        </div>
    </form>
</body>
</html>
