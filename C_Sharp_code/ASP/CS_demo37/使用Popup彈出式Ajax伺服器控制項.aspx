<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用Popup彈出式Ajax伺服器控制項.aspx.cs" Inherits="CS_demo37.使用Popup彈出式Ajax伺服器控制項" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
        ----------------------<br/>
        1.加入ToolkitScriptManager、TextBox控制項<br/>
        2.TextBox控制項快顯視窗>加入擴充項>CalendarExtender<br/>
        ----------------------<br/>
        <div>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            開始日期:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox1">
            </asp:CalendarExtender>
            <br />
            結束日期:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox2">
            </asp:CalendarExtender>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
        </div>
    </form>
</body>
</html>
