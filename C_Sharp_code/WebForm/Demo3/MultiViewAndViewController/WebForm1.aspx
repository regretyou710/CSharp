<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MultiViewAndViewController.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/MultiViewAndView.jpg" />
            <br />
            <br />
            MultiView是View的容器<br />
            ActiveViewIndex=&quot;0&quot;表示目前以第一個畫面呈現<br />
            View1索引-&gt;0,View2索引-&gt;1,View3索引-&gt;2<br />
            DropDownList的AutoPostBack改為true,增加SelectedIndexChanged事件<br />
            ----------------------------------------<br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="0">1st</asp:ListItem>
                <asp:ListItem Value="1">2nd</asp:ListItem>
                <asp:ListItem Value="2">3rd</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:MultiView ID="MultiView1" ActiveViewIndex="0" runat="server">
                <asp:View ID="View1" runat="server">
                    First View:
                </asp:View>
                <asp:View ID="View2" runat="server">
                    Second View:
                </asp:View>
                <asp:View ID="View3" runat="server">
                    Thired View:
                </asp:View>
            </asp:MultiView>
            <br />
        </div>
    </form>
</body>
</html>
