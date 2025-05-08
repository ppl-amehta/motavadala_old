Imports System.Data.SqlClient
Partial Class Login
    Inherits System.Web.UI.Page

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        On Error Resume Next

        Response.Redirect("Registration.aspx")

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            Session("UserName") = ""
            Session("UID") = ""

        Catch ex As Exception

            lblMessage.Text = "Error in Login Screen Loading, Please Contact Application Developer."

        End Try


    End Sub

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click

        On Error Resume Next

        Response.Redirect("ForgotPassword.aspx")

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Try

            '1st Check User Name is Empty or Not.
            If String.IsNullOrEmpty(txtUserName.Text) = True Then
                lblMessage.Text = "User Name is Empty."
                Exit Sub
            End If

            '2nd Check Password is Empty or Not.
            If String.IsNullOrEmpty(txtPassword.Text) = True Then
                lblMessage.Text = "Password is Empty."
                Exit Sub
            End If

            '3rd Run Query With User Name

            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand("SELECT * FROM UserData WHERE UserName = '" & txtUserName.Text & "' ORDER BY UID", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim I As Integer = Nothing

                If reader.HasRows Then

                    Dim U As String = Nothing

                    Do While reader.Read()

                        '4th Verify Password
                        If txtPassword.Text = reader.Item(11).ToString Then

                            '5th Verify Account is active or not.
                            If reader.Item(12).ToString.ToUpper = "YES" Then

                                If reader.Item(13).ToString.ToUpper = "ADMIN" Then

                                    lblMessage.Text = "You Can't Use Admin Login Credential, <br /> Please Use Other RBU Login Credential."

                                    conn.Close()

                                    Exit Sub

                                Else
                                    Session("UID") = reader.Item(0).ToString
                                    Session("UserName") = txtUserName.Text

                                    Response.Redirect("Receipt.aspx", False)

                                    conn.Close()

                                    Exit Sub
                                End If


                            Else

                                lblMessage.Text = "Your Account is not Acticated," & "<br />" & "Please Contact Administrator."

                                conn.Close()

                                Exit Sub

                            End If

                        Else

                            lblMessage.Text = "Your Password is Incorrect," & "<br />" & "Please Try Again."

                            conn.Close()

                            Exit Sub


                        End If


                    Loop


                Else

                    lblMessage.Text = "Your RBU Name is Incorrect," & "<br />" & "Please Try Again."

                    conn.Close()

                    Exit Sub

                End If

                reader.Close()

                conn.Close()

            End Using


        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub
    Private Function ReturnConnection() As SqlConnection

        On Error Resume Next

        Dim conn As New SqlConnection()

        conn.ConnectionString = ConfigurationManager.ConnectionStrings("MotaVadala_MSSQL_ConnectionString").ConnectionString

        Return conn

    End Function

End Class
