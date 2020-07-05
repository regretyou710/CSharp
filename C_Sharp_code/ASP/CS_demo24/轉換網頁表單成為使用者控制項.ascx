<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="轉換網頁表單成為使用者控制項.ascx.cs" Inherits="CS_demo24.轉換網頁表單成為使用者控制項" ClassName="轉換網頁表單成為使用者控制項"%>

    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
    </style>

            <table class="auto-style1" border="1">
                <tr>
                    <td>使用者帳號</td>
                    <td>
                        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>使用者密碼</td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="確定" />
                        <asp:Button ID="Button2" runat="server" Text="取消" />
                    </td>
                </tr>
            </table>

