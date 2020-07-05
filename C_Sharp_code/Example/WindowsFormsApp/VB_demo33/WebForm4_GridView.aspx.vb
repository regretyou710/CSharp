Imports System.Data.SqlClient

Public Class WebForm4_GridView
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conString As String = "Data Source=USER-PC;Initial Catalog=School;User id=sa;password=sa;"
        Dim conn As New SqlConnection(conString)
        Dim sql As String = "SELECT * FROM Student"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet()
        da.Fill(ds)
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub
End Class