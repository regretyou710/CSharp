<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用UpdatePanel執行更新.aspx.cs" Inherits="CS_demo34.使用UpdatePanel執行更新" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入ScriptManager、Button、Label控制項<br/>
        2.複製一份UpdatePanel
        <br />
        3.設定UpdatePanel屬性UpdatePanel為Conditional(不會受到另一個UpdatePanel的PostBack影響)<br />
        4.設定按鈕事件<br />
        -----------------------------<br/>
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Button ID="Button1" runat="server" Text="First" OnClick="Button1_Click" />
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Button ID="Button2" runat="server" Text="Second" OnClick="Button2_Click" />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </div>
    </form>
</body>
</html>
