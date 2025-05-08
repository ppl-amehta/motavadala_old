
Partial Class Payment
    Inherits System.Web.UI.Page
    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click

        On Error Resume Next

        Response.Redirect("Login.aspx")

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles Me.Load

        On Error Resume Next

        If Session("UserType") = "ADMIN" Then

            btnBack.Visible = True
            btnSkip.Visible = False

        Else

            btnBack.Visible = False
            btnSkip.Visible = True

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Response.Redirect("Admin/Admin_Menu.aspx")

    End Sub
End Class
