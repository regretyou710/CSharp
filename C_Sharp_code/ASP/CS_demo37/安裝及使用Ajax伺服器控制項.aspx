<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="安裝及使用Ajax伺服器控制項.aspx.cs" Inherits="CS_demo37.安裝及使用Ajax伺服器控制項" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.工具箱中加入索引標籤<br/>
        2.標籤>選擇項目>AjaxControlToolkit.dll加入.NET Framework元件<br/>
        3.加入ToolkitScriptManager、Button控制項<br/>
        4.Button控制項快顯視窗>加入擴充項>ConfirmButtonExtender<br/>
        ----------------------------------<br/>
       <asp:ToolkitScriptManager runat="server"></asp:ToolkitScriptManager>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        <asp:ConfirmButtonExtender ID="Button1_ConfirmButtonExtender" runat="server" ConfirmText="傳送到伺服器" Enabled="True" TargetControlID="Button1" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
