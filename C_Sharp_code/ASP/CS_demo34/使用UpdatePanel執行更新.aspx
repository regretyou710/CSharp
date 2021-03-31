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
        <br/>
        狀況一:<br/>
        UpdatePanel1 UpdateMode:Conditional<br/>
        UpdatePanel2 UpdateMode:Conditional<br/>
        Button1_Click 沒有撰寫<br/>
        Button2_Click 沒有撰寫<br/>
        >>各自更新時間<br/>
        <br/>
        狀況二:<br/>
        UpdatePanel1 UpdateMode:Conditional<br/>
        UpdatePanel2 UpdateMode:Always<br/>
        Button1_Click 沒有撰寫<br/>
        Button2_Click 沒有撰寫<br/>
        >>UpdatePanel1不會隨UpdatePane2更新時間<br/>
        >>UpdatePanel2隨UpdatePanel1更新時間<br/>
        <br/>
        狀況三:
        UpdatePanel1 UpdateMode:Conditional<br/>
        UpdatePanel2 UpdateMode:Conditional<br/>
        Button1_Click 呼叫UpdatePanel2.Update()<br/>
        Button2_Click 沒有撰寫<br/>
        >>Button2_Click執行時，UpdatePanel1不會隨UpdatePane2更新時間，只更新UpdatePane2<br/>
        >>Button1_Click執行時，UpdatePanel2隨UpdatePanel1更新時間<br/>
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
