Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient

' 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1_WSVB
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function
    <WebMethod()>
    Public Function getStudent() As DataSet
        Dim conString As String = "Data Source=USER-PC;Initial Catalog=School;User id=sa;password=sa;"
        Dim conn As New SqlConnection(conString)
        Dim sql As String = "SELECT * FROM Student"
        Dim da As New SqlDataAdapter(sql, conString)
        Dim ds As New DataSet()
        da.Fill(ds)
        Return ds
    End Function
End Class