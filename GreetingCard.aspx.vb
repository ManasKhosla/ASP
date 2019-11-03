Imports System.Drawing

Public Class GreetingCard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Not Me.IsPostBack) Then
            lstBackColor.Items.Add("Red")
            lstBackColor.Items.Add("Green")
            lstBackColor.Items.Add("Blue")
            lstBackColor.Items.Add("Yellow")
            ' Set font options.
            lstFontName.Items.Add("Times New Roman")
            lstFontName.Items.Add("Arial")
            lstFontName.Items.Add("Verdana")
            lstFontName.Items.Add("Tahoma")

            Dim item As ListItem = New ListItem()
            item.Text = BorderStyle.None.ToString()
            item.Value = (CType(BorderStyle.None, Integer)).ToString()

            lstBorder.Items.Add(item)

            item = New ListItem()
            item.Text = BorderStyle.Double.ToString()
            item.Value = (CType(BorderStyle.Double, Integer)).ToString()
            lstBorder.Items.Add(item)
            item = New ListItem()
            item.Text = BorderStyle.Solid.ToString()
            item.Value = (CType(BorderStyle.Solid, Integer)).ToString()
            lstBorder.Items.Add(item)

            lstBorder.SelectedIndex = 0

            imgDefault.ImageUrl = "cake.png"
        End If
    End Sub
    Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdUpdate.Click
        pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text)

        lblGreeting.Font.Name = lstFontName.SelectedItem.Text

        If Val(txtFontSize.Text) > 0 Then
            lblGreeting.Font.Size = FontUnit.Point(Val(txtFontSize.Text))
        End If

        pnlCard.BorderStyle = Val(lstBorder.SelectedItem.Value)

        If chkPicture.Checked = True Then
            imgDefault.Visible = True
        Else
            imgDefault.Visible = False
        End If

        lblGreeting.Text = txtGreeting.Text
    End Sub

End Class