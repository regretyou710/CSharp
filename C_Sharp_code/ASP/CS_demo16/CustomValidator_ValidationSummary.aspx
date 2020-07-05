<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomValidator_ValidationSummary.aspx.cs" Inherits="CS_demo16.CustomValidator_ValidationSummary" %>

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
            CustomValidator設定事件ServerValidate點兩下<br />
            ValidationSummary(蒐集畫面所有錯誤)不用做特別設定<br />
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
            分數:<asp:TextBox ID="txtScore" runat="server">66</asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtScore" ErrorMessage="請輸入分數範圍0~100" ForeColor="Red" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
            <br />
            <br />
            身分帳號:<asp:TextBox ID="txtAccount" runat="server">test1234</asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtAccount" ErrorMessage="身分帳號輸入錯誤" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 27px" Text="Button" />
            <br />           
        </div>
    </form>
</body>
</html>
