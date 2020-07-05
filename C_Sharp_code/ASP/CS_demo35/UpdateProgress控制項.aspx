<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProgress控制項.aspx.cs" Inherits="CS_demo35.UpdateProgress控制項" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 200px;
            height: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        1.加入ScriptManager控制項<br />
        2.加入UpdatePanel控制項<br />
        3.UpdateProgress控制項加入UpdatePanel中<br />
        4.加入GridView控制項放入UpdatePanel中與進度條分開<br />
        5.選擇資料來源&gt;資料庫<br />
        6.選擇Product資料表<br />
        7.<ProgressTemplate>ProgressTemplate標籤插入圖片&gt;替代文字取消打勾<br />
        8.UpdatePanel控制項屬性AssociatedUpdatePanelID設定UpdatePanel1<br />
        9.GridView加入PageIndexChanging事件<br />
        -------------------------------<br />
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
                        <ProgressTemplate>
                            Waiting <br />
                             <img class="auto-style3" src="progress.gif" />
                             <br />
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                 <!--------------------------------------->
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" OnPageIndexChanging="GridView1_PageIndexChanging">
                        <Columns>
                            <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                            <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                            <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                            <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
                        </Columns>
                    </asp:GridView>
                 <!--------------------------------------->
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice], [Discontinued] FROM [Products]"></asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
