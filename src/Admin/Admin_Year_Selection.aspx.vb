Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Partial Class Admin_Year_Selection
    Inherits System.Web.UI.Page

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        On Error Resume Next

        If lstYearSelection.SelectedItem Is Nothing Then

            lblMessage.Text = "Please Select Year."

        Else

            Dim Success = TableExists(lstYearSelection.SelectedItem.ToString)

            lblMessage.Text = Success.ToString

            If Success = True Then

                Dim CurrentYear As String = DateAndTime.Now.Year.ToString

                Dim FYear As String = Mid(lstYearSelection.SelectedItem.ToString, 1, 4)
                Dim LYear As String = Mid(lstYearSelection.SelectedItem.ToString, 6, 4)

                If lstYearSelection.SelectedItem.ToString = "2022_2023" Then

                    Session("SelectedYear") = "[" & lstYearSelection.SelectedItem.ToString & "]"

                    'lblMessage.Text = lstYearSelection.SelectedItem.ToString

                    Response.Redirect("Admin_Receipt.aspx")

                    Exit Sub

                End If

                If FYear = CurrentYear Or LYear = CurrentYear Then

                    Session("SelectedYear") = "[" & lstYearSelection.SelectedItem.ToString & "]"

                    'lblMessage.Text = lstYearSelection.SelectedItem.ToString

                    Response.Redirect("Admin_Receipt.aspx")

                Else

                    lblMessage.Text = "You Can Not Create Reciept in Future Year."

                    Exit Sub

                End If


            Else

                lblMessage.Text = lstYearSelection.SelectedItem.ToString & " - Table Does Not Exit, Please Contact Admin."

            End If

        End If

    End Sub

    Private Sub Admin_Year_Selection_Load(sender As Object, e As EventArgs) Handles Me.Load

        On Error Resume Next

        If lstYearSelection.Items.Count >= 1 Then

            'Do Nothing
        Else
            lstYearSelection.Items.Add("2022_2023")
            lstYearSelection.Items.Add(DateAndTime.Now.Year - 1 & "_" & DateAndTime.Now.Year)
        End If





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

    Public Function TableExists(TableName As String) As Boolean

        Dim success As Boolean = False

        Try

            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand("IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME='" & TableName & "') SELECT 1 ELSE SELECT 0", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then

                    Do While reader.Read

                        If reader.Item(0).ToString = "0" Then
                            success = False
                        ElseIf reader.Item(0).ToString = "1" Then
                            success = True
                        End If

                    Loop

                End If

                conn.Close()

            End Using

        Catch ex As Exception

            lblMessage.Text = ex.Message.ToString

        End Try

        Return success

    End Function

    Private Function ReturnConnection() As SqlConnection

        On Error Resume Next

        Dim conn As New SqlConnection()

        conn.ConnectionString = ConfigurationManager.ConnectionStrings("MotaVadala_MSSQL_ConnectionString").ConnectionString

        Return conn

    End Function
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        On Error Resume Next

        Session("SelectedYear") = ""

        Response.Redirect("Admin_Menu.aspx")

    End Sub


End Class
