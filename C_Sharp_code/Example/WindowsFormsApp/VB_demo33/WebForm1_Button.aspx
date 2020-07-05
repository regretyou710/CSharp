<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1_Button.aspx.vb" Inherits="VB_demo33.WebForm1_Button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript">
        function frmSubmit() {
            return confirm("Sumbit(Y/N)?");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Button CommandName Example<br />
            1.設定button上屬性 commandArgument,commamdName<br />
            2.設定button上事件command<br />
            <br />
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" CommandArgument="ascending" CommandName="sort" OnCommand="CommandBtn_Command" Text="升冪排序" />
            <asp:Button ID="Button2" runat="server" CommandArgument="descending" CommandName="sort" OnCommand="CommandBtn_Command" Text="降冪排序" />
        <asp:Button ID="Button3" runat="server" Text="Submit" CommandName="submit" OnCommand="CommandBtn_Command" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label" BorderStyle="None" Width="265px"></asp:Label>
    </form>
</body>
</html>
