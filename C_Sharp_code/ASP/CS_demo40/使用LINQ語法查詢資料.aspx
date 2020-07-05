<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="使用LINQ語法查詢資料.aspx.cs" Inherits="CS_demo40.使用LINQ語法查詢資料" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        1.加入GridView、LinqDataSource控制項<br/>
        2.專案中新增項目>LINQ TO SQL類別>資料表拖曳到畫面中<br/>
        3.重建專案<br />
        4.LinqDataSource控制項快顯視窗&gt;設定資料來源&gt;選擇顯示欄位<br />
        5.GridView控制項快顯視窗&gt;設定資料來源<br />
        6.專案中新增項目&gt;ADO.NET實體資料模型<br />
        7.重建專案<br />
        8.加入EntityDataSource控制項>設定資料來源<br />
        9.GridView控制項快顯視窗&gt;設定資料來源<br />
        10.EntityDataSource控制項屬性OrderBy設定<br/>
        ------------------------------<br/>
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" ReadOnly="True" SortExpression="ProductName" />
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" ReadOnly="True" SortExpression="UnitPrice" />
                    <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" ReadOnly="True" SortExpression="Discontinued" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="CS_demo40.使用LINQ語法查詢資料DataContext" EntityTypeName="" Select="new (ProductID, ProductName, UnitPrice, Discontinued)" TableName="Products">
        </asp:LinqDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="EntityDataSource1">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ProductID" ReadOnly="True" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="ProductName" ReadOnly="True" SortExpression="ProductName" />
                <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" ReadOnly="True" SortExpression="Discontinued" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" ReadOnly="True" SortExpression="UnitPrice" />
            </Columns>
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=NorthwindEntities" DefaultContainerName="NorthwindEntities" EnableFlattening="False" EntitySetName="Products" OrderBy="it.[ProductID]" Select="it.[ProductID], it.[ProductName], it.[Discontinued], it.[UnitPrice]">
        </asp:EntityDataSource>
    </form>
</body>
</html>
