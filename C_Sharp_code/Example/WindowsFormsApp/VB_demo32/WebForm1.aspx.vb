Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write("Page_Load")
        Response.Write("</br>")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("Button1_Click:Hello World VB")
        Response.Write("</br>")
    End Sub

    Private Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        Response.Write("Page_Init")
        Response.Write("</br>")
    End Sub
End Class