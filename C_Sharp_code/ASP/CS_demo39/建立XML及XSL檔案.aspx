<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="建立XML及XSL檔案.aspx.cs" Inherits="CS_demo39.建立XML及XSL檔案" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.產生XML並加入到專案中<br />
        2.加入XmlDataSource、GridView控制項<br />
        3.XmlDataSource控制項快顯視窗>設定資料來源>資料檔案&gt;瀏覽&gt;選擇產生的xml檔案<br />
        4.GridView控制項快顯視窗&gt;設定資料來源&gt;XmlDataSource1<br />
        5.手動建立emps.xsl檔加入XmlDataSource1制項快顯視窗&gt;設定資料來源&gt;轉換檔<br />
&nbsp;-----------------------<br />
        <div>
            <asp:Button ID="Button1" runat="server" Text="產生XML" OnClick="Button1_Click" />
            <br />
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/emps.xml" TransformFile="~/emps.xsl"></asp:XmlDataSource>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="XmlDataSource1">
            </asp:GridView>            
        </div>
    </form>
</body>
</html>
