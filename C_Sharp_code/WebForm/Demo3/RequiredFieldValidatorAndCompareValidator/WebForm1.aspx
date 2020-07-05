<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RequiredFieldValidatorAndCompareValidator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            個人基本資料輸入<br />
            RequiredFieldValidator(欄位不可空白)設定ControlToValidate,Display<br />
            CompareValidator設定ValueToCompare,Type,ControlToValidate,Display<br />
            -----------------------------------<br />
            <br />
            姓名:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="請輸入姓名資料" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            年齡:<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="年齡必須=20" ForeColor="Red" Type="Integer" ValueToCompare="20"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="請輸入年齡資料" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 27px" Text="Button" />
            <br />
            <br />
            -----------------------------------<br />
            <asp:Image ID="Image1" runat="server" Height="500px" ImageUrl="~/Valid1.jpg" Width="650px" />
            <br />
            <asp:Image ID="Image2" runat="server" Height="500px" ImageUrl="~/Valid2.jpg" Width="650px" />
            <br />
            <asp:Image ID="Image3" runat="server" Height="500px" ImageUrl="~/Valid3.jpg" Width="650px" />
        </div>
    </form>
</body>
</html>
