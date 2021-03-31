<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用AutoCompleteAjax伺服器控制項.aspx.cs" Inherits="CS_demo37.使用AutoCompleteAjax伺服器控制項" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        輸入字首自動完成(不要離開TextBox，在下方會顯示完成字串陣列)<br/>
        MinimumPrefixLength需為1<br/>
        ----------------------<br/>
        1.加入ToolkitScriptManager、TextBox控制項<br/>
        2.TextBox控制項快顯視窗>加入擴充項>AutoCompleteExtender<br />
        3.設定AutoCompleteExtender的SerivcePath、ServiceMethod、MinimumPrefixLength屬性<br/>
        4.WebService方法參數名稱須為prefixText<br/>
        ----------------------<br/>
        <div>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" DelimiterCharacters="" 
                Enabled="True" ServicePath="~/使用AutoCompleteAjax伺服器控制項服務.asmx" TargetControlID="TextBox1" ServiceMethod="GetCompany" MinimumPrefixLength="1">
            </asp:AutoCompleteExtender>
        </div>
    </form>
</body>
</html>
