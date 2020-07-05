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
            <br />
            RequiredFieldValidator(欄位不可空白)設定ControlToValidate<br />
            CompareValidator設定ValueToCompare,Type,ControlToValidate,Display<br />
            RangeValidator設定最大值,最小值,Type,ControlToValidate<br />
            RegularExpressionValidator設定輸入規則,ControlToValidate<br />
            <br />
            -----------------------------------<br />
            個人基本資料輸入<br />
            <br />
            姓名:<asp:TextBox ID="txtName" runat="server">Tom</asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="請輸入姓名資料" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            年齡:<asp:TextBox ID="txtAge" runat="server">20</asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="年齡必須=20" ForeColor="Red" Type="Integer" ValueToCompare="20"></asp:CompareValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="請輸入年齡資料" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            分數:<asp:TextBox ID="txtScore" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtScore" ErrorMessage="請輸入分數範圍0~100" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            身分證:<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtID" ErrorMessage="錯誤的身分證字號" ForeColor="Red" ValidationExpression="[a-zA-Z]\d{9}"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 27px" Text="Button" />
            <br />
            <br />
            -----------------------------------<br />
            <asp:Image ID="Image1" runat="server" Height="500px" ImageUrl="~/Valid4.jpg" Width="650px" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
