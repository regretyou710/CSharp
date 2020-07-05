<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用GridView新增資料.aspx.cs" Inherits="CS_demo27.使用GridView新增資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入GridView控制項<br />
        2.選擇資料來源>資料庫<br />
        3.選擇Product資料表<br />
        4.進階按鈕勾選INSERT、UPDATE、DELETE陳述式<br />
        5.GridView控制項快顯示窗勾選顯示分頁、啟用編輯、啟用刪除<br />
        6.GridView控制項快顯示窗編輯資料行>選取的資料行修改欄位名稱<br />
        7.GridView控制項屬性中ShowFoot(顯示表尾)改為true<br />
        8.GridView控制項快顯示窗編輯資料行&gt;選取的資料行CommandField轉為TemplateField(才能選擇要編輯的樣式)<br />
        9.GridView控制項快顯示窗編輯樣板&gt;顯示FooterTemplate&gt;加入按鈕<br />
        10.加入PlaceHolder控制項,將要新增的TextBox控制項放到PlaceHolder標籤當中,設定PlaceHolder控制項屬性Visible為false(隱藏起來)<br />
        <br />
        ---------------------------------<br />
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ProductID" DataSourceID="SqlDataSource1" ShowFooter="True">
                <Columns>
                    <asp:TemplateField ShowHeader="False">
                        <EditItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="更新"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消"></asp:LinkButton>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="新增" />
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯"></asp:LinkButton>
                            &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" InsertVisible="False" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" SortExpression="ProductName" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                    <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>"
                DeleteCommand="DELETE FROM [Products] WHERE [ProductID] = @ProductID" 
                InsertCommand="INSERT INTO [Products] ([ProductName], [UnitPrice], [Discontinued]) VALUES (@ProductName, @UnitPrice, @Discontinued)"
                SelectCommand="SELECT [ProductID], [ProductName], [UnitPrice], [Discontinued] FROM [Products]" 
                UpdateCommand="UPDATE [Products] SET [ProductName] = @ProductName, [UnitPrice] = @UnitPrice, [Discontinued] = @Discontinued WHERE [ProductID] = @ProductID">
                <DeleteParameters>
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                    <asp:Parameter Name="Discontinued" Type="Boolean" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="ProductName" Type="String" />
                    <asp:Parameter Name="UnitPrice" Type="Decimal" />
                    <asp:Parameter Name="Discontinued" Type="Boolean" />
                    <asp:Parameter Name="ProductID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server" Visible="False">產品名稱:
                <asp:TextBox ID="txtName" Text="HTC Mobile Phone" runat="server" Width="188px"></asp:TextBox>
                    <br />
                    產品價格:
                <asp:TextBox ID="txtPrice" Text="7999.99" runat="server"></asp:TextBox>
                    <br />
                    續購:
                <asp:TextBox ID="txtDiscon" Text="true" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="儲存" />
            </asp:PlaceHolder>
        </div>
    </form>
</body>
</html>
