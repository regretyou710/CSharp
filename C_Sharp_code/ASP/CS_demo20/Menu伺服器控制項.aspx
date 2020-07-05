<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu伺服器控制項.aspx.cs" Inherits="CS_demo20.Menu伺服器控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" StaticDisplayLevels="2" OnMenuItemClick="Menu1_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="販賣項目" Value="販賣項目">
                        <asp:MenuItem Text="蔬菜" Value="蔬菜">
                            <asp:MenuItem Text="高麗菜" Value="高麗菜"></asp:MenuItem>
                            <asp:MenuItem Text="白菜" Value="白菜"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="水果" Value="水果">
                            <asp:MenuItem Text="芒果" Value="芒果"></asp:MenuItem>
                            <asp:MenuItem Text="香蕉" Value="香蕉"></asp:MenuItem>
                            <asp:MenuItem Text="檸檬" Value="檸檬"></asp:MenuItem>
                        </asp:MenuItem>
                    </asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
    <p>
        -----------------------<br/>
        1.新增Menu伺服器控制項<br/>
        2.修改屬性中Items,增加根項目、子項目<br/>
        3.屬性中 StaticDisplayLeaves可顯示Menu階層<br/>
        4.增加MenuItemClick事件
    </p>
</body>
</html>
