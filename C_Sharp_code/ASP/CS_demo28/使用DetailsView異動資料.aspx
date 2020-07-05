<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用DetailsView異動資料.aspx.cs" Inherits="CS_demo28.使用DetailsView異動資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入GridView控制項<br />
        2.選擇資料來源&gt;資料庫<br />
        3.選擇Product資料表<br />
        4.進階按鈕勾選INSERT、UPDATE、DELETE陳述式<br />
        5.GridView控制項快顯示窗勾選顯示分頁<br />
        6.GridView控制項快顯示窗&gt;編輯資料行&gt;將CommandField欄位加入<br />
        7.修改CommandField屬性中ButtonType、ShowSelectButton<br />
        8.加入DetailView控制項<br />
        9.選擇資料來源&gt;資料庫&gt;新的來源(和GridView不同來源)<br />
        10.選擇Product資料表<br />
        11.進階按鈕勾選INSERT、UPDATE、DELETE陳述式<br />
        12.進入WHERE選項設定資料行、來源(Control)、控制項(GridView)&gt;加入<br />
        13.DetailView控制項快顯示窗&gt;啟用插入、編輯打勾<br />
        14.GridView控制項&gt;進入RowCommand事件(Select)<br />
        15.DetailView控制項&gt;進入ItemUpdated事件<br />
        16.GridView控制項快顯示窗&gt;編輯資料行&gt;選取CommandField欄位修改SelectInsertButton屬性為True<br />
        17.GridView控制項&gt;進入RowCommand事件(New)<br />
        18.DetailView控制項&gt;進入ItemInserted事件<br />
        ---------------------------------<br />
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" EnableViewState="False" Height="16px" OnRowCommand="GridView1_RowCommand" Width="641px">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowInsertButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                    <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" DeleteCommand="DELETE FROM [Products] WHERE [ProductID] = @ProductID" InsertCommand="INSERT INTO [Products] ([ProductName], [Discontinued], [UnitPrice]) VALUES (@ProductName, @Discontinued, @UnitPrice)" SelectCommand="SELECT [ProductID], [ProductName], [Discontinued], [UnitPrice] FROM [Products]" UpdateCommand="UPDATE [Products] SET [ProductName] = @ProductName, [Discontinued] = @Discontinued, [UnitPrice] = @UnitPrice WHERE [ProductID] = @ProductID">
                <DeleteParameters>
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="Discontinued" Type="Boolean" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="Discontinued" Type="Boolean" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource2" EnableViewState="False" Height="46px" OnItemInserted="DetailsView1_ItemInserted" OnItemUpdated="DetailsView1_ItemUpdated" Width="235px">
                <Fields>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                    <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
                    <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" DeleteCommand="DELETE FROM [Products] WHERE [ProductID] = @ProductID" InsertCommand="INSERT INTO [Products] ([ProductName], [UnitPrice], [Discontinued]) VALUES (@ProductName, @UnitPrice, @Discontinued)" SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice], [Discontinued] FROM [Products] WHERE ([ProductID] = @ProductID)" UpdateCommand="UPDATE [Products] SET [ProductName] = @ProductName, [UnitPrice] = @UnitPrice, [Discontinued] = @Discontinued WHERE [ProductID] = @ProductID">
                <DeleteParameters>
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                    <asp:Parameter Name="Discontinued" Type="Boolean" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="ProductID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                    <asp:Parameter Name="Discontinued" Type="Boolean" />
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
        </div>
    </form>
</body>
</html>
