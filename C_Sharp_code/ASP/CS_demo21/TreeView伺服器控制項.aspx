<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TreeView伺服器控制項.aspx.cs" Inherits="CS_demo21.TreeView伺服器控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" Height="179px" ShowLines="True" Width="175px">
                <Nodes>
                    <asp:TreeNode Text="販賣產品" Value="販賣產品">
                        <asp:TreeNode Text="3C電子產品" Value="3C電子產品">
                            <asp:TreeNode NavigateUrl="~/mobile.aspx" Text="手機" Value="手機"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/computer.aspx" Text="電腦" Value="電腦"></asp:TreeNode>
                            <asp:TreeNode NavigateUrl="~/tablet.aspx" Text="平板電腦" Value="平板電腦"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="日常生活用品" Value="日常生活用品">
                            <asp:TreeNode Text="紙巾" Value="紙巾"></asp:TreeNode>
                            <asp:TreeNode Text="飲料" Value="飲料"></asp:TreeNode>
                        </asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
            </asp:TreeView>
            <br />
            ---------------------------<br />
            1.TreeView顯示線條打勾<br />
            2.設定屬性中的Nodes集合<br />
            3.建立Web表單用於超連結<br />
            4.再回到Nodes集合中的節點屬性中設定NavigateUrl</div>
    </form>
</body>
</html>
