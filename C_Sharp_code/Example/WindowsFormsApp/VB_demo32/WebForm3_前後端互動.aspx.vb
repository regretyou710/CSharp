Public Class WebForm3_前後端互動
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.form1.Attributes.Add("onsubmit", "return frmSubmit()")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Write("Server Button Event 被觸發 VB")
    End Sub
End Class