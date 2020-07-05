Public Class WebForm2_DropDownList
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        '將表單所選的項目對應送回
        'DropDownList的屬性AutoPostBack改成true
        Response.Write("No:" & DropDownList1.SelectedValue)
        Response.Write("</br>=============================")
    End Sub
End Class