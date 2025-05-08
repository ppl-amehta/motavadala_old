Imports System.Data.SqlClient
Partial Class ForgotPassword
    Inherits System.Web.UI.Page

    Dim UName As String = Nothing
    Dim PWord As String = Nothing
    Dim TempEmail As String = Nothing
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try

            '1st Check Email or Mobile is Empty or Not.
            '2nd Run Query With Provided Email Address or Mobile Number.
            '3rd Verify if record is found or not.
            '4th Verify Account is active or not.
            '5th if Account is not Active Then Display Message. ("Your Account is not activated, Please Wait for approval.")
            '6th if Account is Active Then Send Email With User Name & Password.


            '1st Check Email or Mobile is Empty or Not.
            If String.IsNullOrEmpty(txtEmail.Text) = True And String.IsNullOrEmpty(txtMobile.Text) = True Then

                lblMessage.Text = "Please Enter Your Registered Email Address or Registered Mobile Number."
                Exit Sub

            End If

            If String.IsNullOrEmpty(txtEmail.Text) = False And String.IsNullOrEmpty(txtMobile.Text) = False Then

                lblMessage.Text = "Please Enter Only Registered Email Address or Registered Mobile Number."
                Exit Sub

            End If


            If String.IsNullOrEmpty(txtEmail.Text) = False Then

                Using conn As SqlConnection = ReturnConnection()

                    Dim cmd As New SqlCommand("SELECT * FROM UserData WHERE Email = '" & txtEmail.Text & "' ORDER BY UID", conn)

                    conn.Open()

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    Dim I As Integer = Nothing

                    If reader.HasRows Then

                        Dim U As String = Nothing

                        Do While reader.Read()

                            'Verify Email is available or not.
                            If txtEmail.Text = reader.Item(8).ToString Then

                                If reader.Item(12).ToString = "YES" Then

                                    'Store User Name & Password to Variables
                                    TempEmail = reader.Item(8)
                                    UName = reader.Item(10)
                                    PWord = reader.Item(11)

                                    Call SendEmail()

                                    conn.Close()

                                    Exit Sub

                                Else

                                    lblMessage.Text = "Your Account is not Activated, Please Contact Administrator."

                                    conn.Close()

                                    Exit Sub

                                End If

                            Else

                                lblMessage.Text = "Your registered email Address is not found on our database, Please check email address or enter registered mobile number."
                                conn.Close()

                                Exit Sub

                            End If


                        Loop


                    Else

                        lblMessage.Text = "Your registered email Address is not found on our database, Please check email address or enter registered mobile number."

                        conn.Close()

                        Exit Sub

                    End If

                    reader.Close()

                    conn.Close()

                End Using

            End If

            If String.IsNullOrEmpty(txtMobile.Text) = False Then

                Using conn As SqlConnection = ReturnConnection()

                    Dim cmd As New SqlCommand("SELECT * FROM UserData WHERE Mobile = '" & txtMobile.Text & "' ORDER BY UID", conn)

                    conn.Open()

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    Dim I As Integer = Nothing

                    If reader.HasRows Then

                        Dim U As String = Nothing

                        Do While reader.Read()

                            'Verify Email is available or not.
                            If txtMobile.Text = reader.Item(2).ToString Then

                                If reader.Item(12).ToString.ToUpper = "YES" Then


                                    'Store User Name & Password to Variables
                                    TempEmail = reader.Item(8)
                                    UName = reader.Item(10)
                                    PWord = reader.Item(11)


                                    Call SendEmail()

                                    conn.Close()

                                    Exit Sub

                                Else

                                    lblMessage.Text = "Your Account is not Activated, Please Contact Administrator."

                                    conn.Close()

                                    Exit Sub

                                End If

                            Else

                                lblMessage.Text = "Your registered mobile number is not found on our database, Please check mobile number or enter registered email address."
                                conn.Close()

                                Exit Sub

                            End If


                        Loop


                    Else

                        lblMessage.Text = "Your registered mobile number is not found on our database, Please check mobile number or enter registered email address."

                        conn.Close()

                        Exit Sub

                    End If

                    reader.Close()

                    conn.Close()

                End Using

            End If

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub

    Private Sub SendEmail()

        Try

            'Create Email & Sent it.

            Dim StrHTML As String = ""
            StrHTML = StrHTML & "<h2> <b> Respected Sir, </b> "
            StrHTML = StrHTML & "<p> </p>"
            StrHTML = StrHTML & "Your RBU Name & Password For Mota Vadala Gau Seva Rahat Trust Application is Following."
            StrHTML = StrHTML & "<p> </p>"
            StrHTML = StrHTML & "<table border=1 align=left cellpadding=1 cellspacing=0 style=width:600px;>"
            StrHTML = StrHTML & "<tr>"
            StrHTML = StrHTML & "<td width=150 align=right>"
            StrHTML = StrHTML & "RBU Name : &nbsp;&nbsp;"
            StrHTML = StrHTML & "</td>"
            StrHTML = StrHTML & "<td align=left>"
            StrHTML = StrHTML & "&nbsp;&nbsp;" & UName.ToString
            StrHTML = StrHTML & "</td>"
            StrHTML = StrHTML & "</tr>"

            StrHTML = StrHTML & "<tr>"
            StrHTML = StrHTML & "<td align=right>"
            StrHTML = StrHTML & "Password : &nbsp;&nbsp;"
            StrHTML = StrHTML & "</td>"
            StrHTML = StrHTML & "<td align=left>"
            StrHTML = StrHTML & "&nbsp;&nbsp;" & PWord.ToString
            StrHTML = StrHTML & "</td>"
            StrHTML = StrHTML & "</tr>"

            StrHTML = StrHTML & "</table>"

            StrHTML = StrHTML & "<br>"
            StrHTML = StrHTML & "<br>"
            StrHTML = StrHTML & "<br>"
            StrHTML = StrHTML & "<br>"
            StrHTML = StrHTML & "<br>"
            StrHTML = StrHTML & "<br>"

            StrHTML = StrHTML & "<div><b>MOTA VADALA GAU SEVA RAHAT TRUST</b> </h2><div>"

            Dim MailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage

            MailMessage.From = New System.Net.Mail.MailAddress("info@motavadalagauseva.org")
            MailMessage.To.Add(New System.Net.Mail.MailAddress(TempEmail))
            MailMessage.Subject = "Mota Vadala Application RBU Name & Password."
            MailMessage.IsBodyHtml = True
            MailMessage.Body = StrHTML

            Dim SMTPClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient()

            SMTPClient.Host = "mail.motavadalagauseva.org"
            SMTPClient.Port = "25"
            SMTPClient.EnableSsl = False

            'SMTPClient.Credentials = New System.Net.NetworkCredential("info@motavadalagauseva.org", "MotaVadala@2022")
            SMTPClient.Credentials = New System.Net.NetworkCredential("info@motavadalagauseva.org", "Mota@123$")

            SMTPClient.Send(MailMessage)


            Dim meta As New HtmlMeta()

            meta.HttpEquiv = "Refresh"
            meta.Content = "5;url=Login.aspx"

            Me.Page.Controls.Add(meta)


            lblMessage.Text = "Email is Sent, You will now be redirected in 5 seconds"

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
