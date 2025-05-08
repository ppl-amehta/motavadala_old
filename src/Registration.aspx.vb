Imports System.Data
Imports System.Data.SqlClient
Partial Class Registration

    Inherits System.Web.UI.Page

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles frmRegistration.Load

        On Error Resume Next

        If Page.IsPostBack = True Then

            'Do Nothing

        End If

    End Sub
    Private Sub btnSumbit_Click(sender As Object, e As EventArgs) Handles btnSumbit.Click

        Try

            '1st Check All Data.
            '2nd Store all data in variable.
            '3rd Open Tabel & Check User Name is allready given to another person or not.
            '4th Open Tabel & Insert All Data.
            '5th Successfull Registration Display Message


            lblMessage.Text = ""

            '1. Validation
            If String.IsNullOrEmpty(txtContactPersonName.Text) = True Then

                lblMessage.Text = "Please Enter Contact Person Name."

                Exit Sub
            ElseIf String.IsNullOrEmpty(txtUserName.Text) = True Then

                lblMessage.Text = "Please Enter RBU Name."

                Exit Sub

            ElseIf String.IsNullOrEmpty(txtPassword.Text) = True Then

                lblMessage.Text = "Please Enter Password."

                Exit Sub

            ElseIf String.IsNullOrEmpty(txtCity.Text) = True Then

                lblMessage.Text = "Please Enter City Name."

                Exit Sub

            ElseIf String.IsNullOrEmpty(txtMobile.Text) = True Then

                lblMessage.Text = "Please Enter Mobile Number."

                Exit Sub

            ElseIf String.IsNullOrEmpty(txtEmail.Text) = True Then

                lblMessage.Text = "Please Enter Email."

                Exit Sub

            End If

            '2. Store all data in variable.
            Dim UContactPersonName As String = Nothing
            Dim UMobile As String = Nothing
            Dim UAddress As String = Nothing
            Dim UCity As String = Nothing
            Dim UPincode As String = Nothing
            Dim UState As String = Nothing
            Dim UCountry As String = Nothing
            Dim UEmail As String = Nothing
            Dim URemarks As String = Nothing
            Dim UUserName As String = Nothing
            Dim UPassWord As String = Nothing
            Dim UActivated As String = Nothing
            Dim UUserRole As String = Nothing

            If String.IsNullOrEmpty(txtContactPersonName.Text) = True Then
                'Do Nothing
            Else
                UContactPersonName = txtContactPersonName.Text
            End If

            If String.IsNullOrEmpty(txtMobile.Text) = True Then
                'Do Nothing
            Else
                UMobile = txtMobile.Text
            End If

            If String.IsNullOrEmpty(txtAddress.Text) = True Then
                'Do Nothing
            Else
                UAddress = txtAddress.Text
            End If

            If String.IsNullOrEmpty(txtCity.Text) = True Then
                'Do Nothing
            Else
                UCity = txtCity.Text
            End If

            If String.IsNullOrEmpty(txtPincode.Text) = True Then
                'Do Nothing
            Else
                UPincode = txtPincode.Text
            End If

            If String.IsNullOrEmpty(txtState.Text) = True Then
                'Do Nothing
            Else
                UState = txtState.Text
            End If

            If String.IsNullOrEmpty(txtCountry.Text) = True Then
                'Do Nothing
            Else
                UCountry = txtCountry.Text
            End If

            If String.IsNullOrEmpty(txtEmail.Text) = True Then
                'Do Nothing
            Else
                UEmail = txtEmail.Text
            End If

            If String.IsNullOrEmpty(txtRemark.Text) = True Then
                'Do Nothing
            Else
                URemarks = txtRemark.Text
            End If

            If String.IsNullOrEmpty(txtUserName.Text) = True Then
                'Do Nothing
            Else
                UUserName = txtUserName.Text
            End If

            If String.IsNullOrEmpty(txtPassword.Text) = True Then
                'Do Nothing
            Else
                UPassWord = txtPassword.Text
            End If


            UActivated = ""

            '3. Open Tabel & Check User Name is allready given to another person or not.
            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand("SELECT UserName FROM UserData WHERE UserName = '" & UUserName & "' ORDER BY UID", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim I As Integer = Nothing

                If reader.HasRows Then

                    Dim U As String = Nothing

                    Do While reader.Read()

                        'Verify UserName is available or not.
                        If txtUserName.Text = reader.Item(0).ToString Then

                            lblMessage.Text = "RBU Name is not Available."

                            conn.Close()

                            Exit Sub

                        End If

                    Loop

                End If

                reader.Close()

                conn.Close()

            End Using

            '4. Open Tabel & Check Email Address is Registred or not.
            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand("SELECT Email FROM UserData WHERE Email = '" & UEmail & "' ORDER BY UID", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim I As Integer = Nothing

                If reader.HasRows Then

                    Dim U As String = Nothing

                    Do While reader.Read()

                        'Verify Email is available or not.
                        If txtEmail.Text = reader.Item(0).ToString Then

                            lblMessage.Text = "Email Address is Already Registered."

                            conn.Close()

                            Exit Sub

                        End If

                    Loop

                End If

                reader.Close()

                conn.Close()

            End Using

            '5. Open Tabel & Check Email Address is Registred or not.
            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand("SELECT Mobile FROM UserData WHERE Mobile = '" & UMobile & "' ORDER BY UID", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim I As Integer = Nothing

                If reader.HasRows Then

                    Dim U As String = Nothing

                    Do While reader.Read()

                        'Verify Mobile is available or not.
                        If txtMobile.Text = reader.Item(0).ToString Then

                            lblMessage.Text = "Mobile Number is Already Registered."

                            conn.Close()

                            Exit Sub

                        End If

                    Loop

                End If

                reader.Close()

                conn.Close()

            End Using

            '6. Open Tabel & Insert All Data.

            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand

                Using Query As New SqlClient.SqlCommand

                    conn.Open()

                    With Query

                        .Connection = conn

                        .CommandText = "INSERT INTO UserData ( UID, ContactPersonName, Mobile, Address, City, Pincode, State, Country, Email, Remarks, UserName, Password, Activated, UserRole ) VALUES ( NEXT VALUE for Sequence_UserData, @UContactPersonName, @UMobile, @UAddress, @UCity, @UPincode, @UState, @UCountry, @UEmail, @URemarks, @UUserName, @UPassWord, @UActivated, @UUserRole )"

                        If String.IsNullOrEmpty(UContactPersonName) = True Then
                            .Parameters.AddWithValue("@UContactPersonName", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UContactPersonName", UContactPersonName)
                        End If

                        If String.IsNullOrEmpty(UMobile) = True Then
                            .Parameters.AddWithValue("@UMobile", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UMobile", UMobile)
                        End If

                        If String.IsNullOrEmpty(UAddress) = True Then
                            .Parameters.AddWithValue("@UAddress", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UAddress", UAddress)
                        End If

                        If String.IsNullOrEmpty(UCity) = True Then
                            .Parameters.AddWithValue("@UCity", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UCity", UCity)
                        End If

                        If String.IsNullOrEmpty(UPincode) = True Then
                            .Parameters.AddWithValue("@UPincode", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UPincode", UPincode)
                        End If

                        If String.IsNullOrEmpty(UState) = True Then
                            .Parameters.AddWithValue("@UState", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UState", UState)
                        End If

                        If String.IsNullOrEmpty(UCountry) = True Then
                            .Parameters.AddWithValue("@UCountry", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UCountry", UCountry)
                        End If

                        If String.IsNullOrEmpty(UEmail) = True Then
                            .Parameters.AddWithValue("@UEmail", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UEmail", UEmail)
                        End If

                        If String.IsNullOrEmpty(URemarks) = True Then
                            .Parameters.AddWithValue("@URemarks", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@URemarks", URemarks)
                        End If


                        If String.IsNullOrEmpty(UUserName) = True Then
                            .Parameters.AddWithValue("@UUserName", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UUserName", UUserName)
                        End If

                        If String.IsNullOrEmpty(UPassWord) = True Then
                            .Parameters.AddWithValue("@UPassWord", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UPassWord", UPassWord)
                        End If


                        If String.IsNullOrEmpty(UActivated) = True Then
                            .Parameters.AddWithValue("@UActivated", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UActivated", UActivated)
                        End If


                        If String.IsNullOrEmpty(UUserRole) = True Then
                            .Parameters.AddWithValue("@UUserRole", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@UUserRole", UUserRole)
                        End If

                    End With

                    Query.ExecuteNonQuery()

                    conn.Close()

                End Using

            End Using

            '5th Display Confirmation
            Dim meta As New HtmlMeta()

            meta.HttpEquiv = "Refresh"
            meta.Content = "5;url=Login.aspx"

            Me.Page.Controls.Add(meta)

            lblMessage.Text = "Registration is Success, </br> Wait For Admin Approval, </br> You will now be redirected in 5 seconds"

        Catch ex As Exception

            'lblMessage.Text = "Problem in Database Connectivity."
            lblMessage.Text = ex.Message.ToString

        End Try

    End Sub

    Private Function ReturnConnection() As SqlConnection

        On Error Resume Next

        Dim conn As New SqlConnection()

        conn.ConnectionString = ConfigurationManager.ConnectionStrings("MotaVadala_MSSQL_ConnectionString").ConnectionString

        Return conn

    End Function

End Class
