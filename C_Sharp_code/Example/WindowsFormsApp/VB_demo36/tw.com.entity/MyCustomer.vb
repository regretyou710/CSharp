Imports System.Data.Linq.Mapping
<Table(Name:="dbo.Customers")>
Public Class MyCustomer
    Private _id As String
    Private _contactName As String
    <Column(Name:="CustomerID", Storage:="_id", IsPrimaryKey:=True, IsDbGenerated:=False)>
    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property
    <Column(Name:="ContactName", Storage:="_contactName")>
    Public Property ContactName As String
        Get
            Return _contactName
        End Get
        Set(value As String)
            _contactName = value
        End Set
    End Property
End Class
