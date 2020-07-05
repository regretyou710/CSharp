Public Class WebForm3_Calendar
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
        Dim dts As SelectedDatesCollection = Calendar1.SelectedDates
        For Each dt As DateTime In dts
            Response.Write(dt & "</br>")
        Next
        Response.Write("所選日期:" & Calendar1.SelectedDate)
        Response.Write("</br>------------------------")
    End Sub
End Class