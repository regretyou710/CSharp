<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScriptManager如何使用Web服務.aspx.cs" Inherits="CS_demo33.ScriptManager如何使用Web服務" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入ScriptManager控制項<br/>
        2.設定ScriptManager控制項屬性Service&gt;加入&gt;設定Path為WebService Url
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
                <Services>
                    <asp:ServiceReference Path="https://localhost:44367/ScriptManager%E5%A6%82%E4%BD%95%E4%BD%BF%E7%94%A8Web%E6%9C%8D%E5%8B%99.asmx" />
                </Services>
            </asp:ScriptManager>
            <asp:Button ID="Button1" runat="server" Text="Start" OnClientClick="MyClick()" />
        </div>
        <script type="text/javascript">
            function MyClick() {
                Output();
            }
            function Output() {
                CS_demo33.ScriptManager如何使用Web服務1.GetTime(OnSuccess);//命名空間.類別名稱.方法名稱(回呼)
            }
            function OnSuccess(rs) {
                alert(rs);
            }
        </script>
    </form>
</body>
</html>
