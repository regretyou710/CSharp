<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XML文件結合TreeView控制項.aspx.cs" Inherits="CS_demo22.XML文件結合TreeView控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1" Height="207px" ShowLines="True" Width="176px">
                <DataBindings>
                    <asp:TreeNodeBinding DataMember="手機" FormatString="{0}" NavigateUrl="~/mobile.aspx" TextField="名稱" />
                    <asp:TreeNodeBinding DataMember="電腦" FormatString="{0}" NavigateUrl="~/computer.aspx" TextField="名稱" />
                    <asp:TreeNodeBinding DataMember="平板電腦" FormatString="{0}" NavigateUrl="~/tablet.aspx" TextField="名稱" />
                </DataBindings>
            </asp:TreeView>
            <br />
            <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml"></asp:XmlDataSource>
            <br />
            --------------------<br />
            1.加入TreeView控制項<br />
            2.加入XmlDataSource控制項(資料)<br />
            3.建立xml檔案<br />
            4.XmlDataSource控制項屬性中設定DataFile來自xml檔案<br />
            5.點選TreeView控制項(快顯選單)&gt;資料來源選擇XmlDataSource<br />
            6.點選TreeView控制項(快顯選單)&gt;編輯TreeNode資料繫結&gt;將手機、電腦、平板電腦加入<br />
            7.FormatString設定{0}、TextFile設定名稱(對應xm檔案中設定的名稱)、設定NavigateUrl</div>
    </form>
</body>
</html>
