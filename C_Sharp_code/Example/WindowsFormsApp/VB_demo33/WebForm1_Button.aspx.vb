Public Class WebForm1_Button
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.form1.Attributes.Add("onsubmit", "return frmSubmit()")
    End Sub

    Protected Sub CommandBtn_Command(sender As Object, e As CommandEventArgs) Handles Button1.Command
        Select Case (e.CommandName)
            Case "sort"
                Sort_List(CType(e.CommandArgument, String))
            Case "submit"
                Label1.Text = "點擊了button按鈕"
            Case Else
                Label1.Text = "無法辨識命令名稱"
        End Select
    End Sub
    Public Sub Sort_List(ByVal commandArgument As String)
        Select Case commandArgument
            Case Is = "ascending"
                Label1.Text = "點擊了升冪排序"
            Case Is = "descending"
                Label1.Text = "點擊了降冪排序"
            Case Else
                Label1.Text = "無法辨識命令名稱"
        End Select
    End Sub
End Class