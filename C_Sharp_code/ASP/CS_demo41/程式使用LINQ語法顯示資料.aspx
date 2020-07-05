<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="程式使用LINQ語法顯示資料.aspx.cs" Inherits="CS_demo41.程式使用LINQ語法顯示資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入DropDownList、LinqDataSource、GridView控制項<br />
        2.專案中加入項目&gt;LINQ TO SQL類別&gt;資料表拖曳到畫面中<br />
        3.撰寫後置程式碼<br />
        4.重建專案<br />
        5.LinqDataSource快顯視窗>資料來源設定>選擇欄位&gt;WHWRE設定<br />
        6.GridView快顯視窗&gt;資料來源設定<br/>
        ------------------------<br/>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="CS_demo41.程式使用LINQ語法顯示資料DataContext" EntityTypeName="" Select="new (CustomerID, CompanyName, ContactName, Address, Country)" TableName="Customers" Where="CustomerID == @CustomerID">
                <WhereParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="CustomerID" PropertyName="SelectedValue" Type="String" />
                </WhereParameters>
            </asp:LinqDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
                <Columns>
                    <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" SortExpression="CustomerID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" ReadOnly="True" SortExpression="CompanyName" />
                    <asp:BoundField DataField="ContactName" HeaderText="ContactName" ReadOnly="True" SortExpression="ContactName" />
                    <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="True" SortExpression="Address" />
                    <asp:BoundField DataField="Country" HeaderText="Country" ReadOnly="True" SortExpression="Country" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
