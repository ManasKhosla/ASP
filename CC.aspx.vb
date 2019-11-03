Public Class CC
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Me.IsPostBack) Then
            Currency.Items.Add(New ListItem(“Euro”, “1.12”))
            Currency.Items.Add(New ListItem(“Japanese Yen”, “122.33”))
            Currency.Items.Add(New ListItem(“Canadian Dollars”, ”1.58”))
        End If
    End Sub
    Private Sub Convert_ServerClick(ByVal sender As Object, ByVal e As EventArgs) Handles Convert.ServerClick
        Dim Amount As Decimal = Val(US.Value)
        Dim Item As ListItem
        Item = Currency.Items(Currency.SelectedIndex)
        Dim NewAmount As Decimal = Amount * Val(Item.Value)
        RESULT.InnerText = Amount.ToString() & " US Dollar = "
        RESULT.InnerText &= NewAmount.ToString() & "" & Item.Text
    End Sub

End Class