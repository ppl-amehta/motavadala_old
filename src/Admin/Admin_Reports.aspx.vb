
Partial Class Admin_Reports
    Inherits System.Web.UI.Page

    Private Sub Admin_Reports_Load(sender As Object, e As EventArgs) Handles Me.Load
        On Error Resume Next

        'if User ID or User Name Not Found, Redirect to Login Page, Display Please Please Login.
        If Session("UID") = "" Then

            Response.Redirect("Admin_Login.aspx")
            Exit Sub

        End If

        If Session("UserName") = "" Then

            Response.Redirect("Admin_Login.aspx")
            Exit Sub

        End If
    End Sub

    Private Sub btnDontionRegister_Click(sender As Object, e As EventArgs) Handles btnDontionRegister.Click

        On Error Resume Next

        Response.Redirect("Admin_Donation_Register.aspx")

    End Sub

    Private Sub btnForm10BD_Click(sender As Object, e As EventArgs) Handles btnForm10BD.Click

        On Error Resume Next

        Response.Redirect("Admin_10BD_Register.aspx")

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        On Error Resume Next

        Response.Redirect("Admin_Menu.aspx")

    End Sub
End Class
