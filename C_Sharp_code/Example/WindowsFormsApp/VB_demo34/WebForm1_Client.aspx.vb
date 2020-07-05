Public Class WebForm1_Client
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ws As New localWS_VB.WebService1
        Dim ds As New DataSet()
        ds = ws.getStudent
        GridView1.DataSource = ds.Tables(0)
        GridView1.DataBind()
    End Sub
End Class