<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList連結異動資料.aspx.cs" Inherits="CS_demo30.DataList連結異動資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入DataList控制項<br />
        2.選擇資料來源&gt;資料庫<br />
        3.選擇Product資料表<br />
        4.進階按鈕勾選INSERT、UPDATE、DELETE陳述式<br />
        5.進入WHERE選項設定資料行、來源(Control)、控制項(GridView)&gt;加入<br />
        6.修改DataList屬性RepeatColumns、RepeatDirection<br />
        7.複製ItemTemplate標籤為EditItemTemplate貼上進行控制項標籤修改、加入Sava按鈕<br />
        8.ItemTemplate標籤中的ID標籤改為LinkButton並加上CommandName屬性<br />
        9.DataList控制項&gt;加入EditCommand事件<br />
        10.DataList控制項&gt;加入UpdateCommand事件<br />
            ------------------------------------------------------<br />
        <div>
            <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" DataSourceID="SqlDataSource1" RepeatColumns="3" RepeatDirection="Horizontal" OnEditCommand="DataList1_EditCommand" OnUpdateCommand="DataList1_UpdateCommand">
                <ItemTemplate>
                    ProductID:
                    <asp:LinkButton ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' CommandName="Edit"/>
                    <br />
                    ProductName:
                    <asp:Label ID="ProductNameLabel" runat="server" Text='<%# Eval("ProductName") %>' />
                    <br />
                    UnitPrice:
                    <asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' />
                    <br />
                    Discontinued:
                    <asp:Label ID="DiscontinuedLabel" runat="server" Text='<%# Eval("Discontinued") %>' />
                    <br />
                    <br />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Button ID="ButSave" Text="Save" runat="server" CommandName="Update" /><br />
                    ProductID:
                    <asp:Label ID="LabProductID" runat="server" Text='<%# Eval("ProductID") %>' />
                    <br />
                    ProductName:
                    <asp:TextBox ID="TxtProductName" runat="server" Text='<%# Eval("ProductName") %>' />
                    <br />
                    UnitPrice:
                    <asp:TextBox ID="TxtUnitPrice" runat="server" Text='<%# Eval("UnitPrice") %>' />
                    <br />
                    Discontinued:
                    <asp:CheckBox ID="TxtDiscontinued" runat="server" Checked='<%# Eval("Discontinued") %>' />
                    <br />
                    <br />
                </EditItemTemplate>
            </asp:DataList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" DeleteCommand="DELETE FROM [Products] WHERE [ProductID] = @ProductID" InsertCommand="INSERT INTO [Products] ([ProductName], [UnitPrice], [Discontinued]) VALUES (@ProductName, @UnitPrice, @Discontinued)" SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice], [Discontinued] FROM [Products] WHERE ([ProductID] &lt;= @ProductID)" UpdateCommand="UPDATE [Products] SET [ProductName] = @ProductName, [UnitPrice] = @UnitPrice, [Discontinued] = @Discontinued WHERE [ProductID] = @ProductID">
                <DeleteParameters>
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                    <asp:Parameter Name="Discontinued" Type="Boolean" />
                </InsertParameters>
                <SelectParameters>
                    <asp:ControlParameter ControlID="DataList1" DefaultValue="12" Name="ProductID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                    <asp:Parameter Name="Discontinued" Type="Boolean" />
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
