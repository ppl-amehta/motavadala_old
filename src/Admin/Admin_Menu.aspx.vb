
Partial Class Admin_Menu

    Inherits System.Web.UI.Page

    Private Sub btnCreateNewReceipt_Click(sender As Object, e As EventArgs) Handles btnCreateNewReceipt.Click

        On Error Resume Next

        Session("SelectedYear") = ""

        Response.Redirect("Admin_Receipt.aspx")

    End Sub

    Private Sub btnUserList_Click(sender As Object, e As EventArgs) Handles btnUserList.Click

        On Error Resume Next

        Response.Redirect("Admin_User_List.aspx")

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

        On Error Resume Next

        Response.Redirect("\Payment.aspx")

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        On Error Resume Next

        Response.Redirect("Admin_Reports.aspx")

    End Sub

    Private Sub btnModifyReceipt_Click(sender As Object, e As EventArgs) Handles btnModifyReceipt.Click

        On Error Resume Next

        Response.Redirect("Admin_Modify_Receipt.aspx")

    End Sub

    Private Sub btnOldDatabaseSelectionAndCreateReceipt_Click(sender As Object, e As EventArgs) Handles btnOldDatabaseSelectionAndCreateReceipt.Click

        On Error Resume Next

        Response.Redirect("Admin_Year_Selection.aspx")

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        On Error Resume Next

        Session("UserName") = ""
        Session("UID") = ""
        Session("UserType") = ""

        Response.Redirect("Admin_Login.aspx")

    End Sub

    Private Sub Admin_Menu_Load(sender As Object, e As EventArgs) Handles Me.Load

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
End Class
