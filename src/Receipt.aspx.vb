Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports DevExpress.Office.NumberConverters
Imports DevExpress.Office.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraSpreadsheet.Commands
Imports DevExpress.XtraSpreadsheet.Model
Imports Microsoft.CodeAnalysis.VisualBasic.Syntax

Partial Class Receipt

    Inherits System.Web.UI.Page

    Dim TableName As String = Nothing

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles Me.Load

        On Error Resume Next

        'if User ID or User Name Not Found, Redirect to Login Page, Display Please Please Login.
        If Session("UID") = "" Then

            Response.Redirect("Login.aspx")
            Exit Sub

        End If

        If Session("UserName") = "" Then

            Response.Redirect("Login.aspx")
            Exit Sub

        End If


        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        'Working Code For Get Table Name
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        Dim CurrentDate As String = DateNow.Date.ToShortDateString
        Dim FutureDate As String = "01/04/" & DateNow.Year

        'lblMessage.Text = CurrentDate & " - " & FutureDate

        If CDate(CurrentDate) >= CDate(FutureDate) Then
            'lblMessage.Text = "[" & DateNow.Year & "_" & DateNow.Year + 1 & "]"
            TableName = "[" & DateNow.Year & "_" & DateNow.Year + 1 & "]"
        Else
            If CDate(CurrentDate).Month.ToString = "1" Or CDate(CurrentDate).Month.ToString = "2" Or CDate(CurrentDate).Month.ToString = "3" Then
                'lblMessage.Text = "[" & DateNow.Year - 1 & "_" & DateNow.Year & "]"
                TableName = "[" & DateNow.Year - 1 & "_" & DateNow.Year & "]"
            ElseIf CDate(CurrentDate).Month.ToString = "4" Or
                CDate(CurrentDate).Month.ToString = "5" Or
                CDate(CurrentDate).Month.ToString = "6" Or
                CDate(CurrentDate).Month.ToString = "7" Or
                CDate(CurrentDate).Month.ToString = "8" Or
                CDate(CurrentDate).Month.ToString = "9" Or
                CDate(CurrentDate).Month.ToString = "10" Or
                CDate(CurrentDate).Month.ToString = "11" Or
                CDate(CurrentDate).Month.ToString = "12" And DateNow.Year - 1 Then
                'lblMessage.Text = "[" & DateNow.Year - 1 & "_" & DateNow.Year & "]"
                TableName = "[" & DateNow.Year - 1 & "_" & DateNow.Year & "]"
            Else
                'lblMessage.Text = "[" & DateNow.Year & "_" & DateNow.Year + 1 & "]"
                TableName = "[" & DateNow.Year & "_" & DateNow.Year + 1 & "]"
            End If
        End If

        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        lblUserID.Text = "User ID : " & Session("UID")
        lblUsername.Text = "RBU Name : " & Session("UserName")

        If Page.IsPostBack = False Then

            txtDate.Text = DateNow.ToString("yyyy-MM-dd")

        End If

        'Code For Disable Datepicker Future Dates & Past Dates (Before Last Receipt Date)
        'txtDate.Attributes("max") = DateTime.Now.ToString("2022-12-22")
        Dim CurrentYear As String
        Dim CurrentMonth As String
        Dim CurrentDay As String

        If DateNow.Year.ToString.Length = 2 Then
            CurrentYear = "20" & DateNow.Year.ToString
        Else
            CurrentYear = DateNow.Year.ToString
        End If

        If DateNow.Month.ToString.Length = 1 Then
            CurrentMonth = "0" & DateNow.Month.ToString
        Else
            CurrentMonth = DateNow.Month.ToString
        End If

        If DateNow.Day.ToString.Length = 1 Then
            CurrentDay = "0" & DateNow.Day.ToString
        Else
            CurrentDay = DateNow.Day.ToString
        End If


        'txtDate.Attributes("max") = DateTime.Now.ToString(DateTime.Now.Year & "-" & DateNow.Month & "-" & DateNow.Day)
        txtDate.Attributes("max") = DateTime.Now.ToString(CurrentYear & "-" & CurrentMonth & "-" & CurrentDay)

        'lblMessage.Text = DateTime.Now.ToString(DateTime.Now.Year & "-" & DateNow.Month & "-" & DateNow.Day)

        Dim TempLastDate As Date = Nothing
        Dim TempMonth As String = Nothing
        Dim TempDay As String = Nothing

        TempLastDate = GetLastDate()

        ' lblMessage.Text = DateTime.Now.ToString(TempLastDate.Year & "-" & TempLastDate.Month & "-" & TempLastDate.Day)


        If TempLastDate.Day.ToString.Length = 1 Then

            TempDay = "0" & TempLastDate.Day.ToString

        Else

            TempDay = TempLastDate.Day.ToString

        End If

        If TempLastDate.Month.ToString.Length = 1 Then

            TempMonth = "0" & TempLastDate.Month.ToString

        Else

            TempMonth = TempLastDate.Month.ToString

        End If

        txtDate.Attributes("min") = DateTime.Now.ToString(TempLastDate.Year & "-" & TempMonth & "-" & TempDay)


    End Sub

    Public Function GetLastDate() As Date

        On Error Resume Next

        GetLastDate = Nothing

        'Dim TableName As String = ConfigurationManager.AppSettings("TableName").ToString()

        Using conn As SqlConnection = ReturnConnection()

            Dim cmd As New SqlCommand("SELECT TOP (1) [ReceiptDate] FROM " & TableName & " WHERE DELETED Is NULL ORDER BY UID DESC", conn)

            conn.Open()

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then

                Do While reader.Read()

                    GetLastDate = reader.Item(0).ToString

                Loop

            End If

            reader.Close()

            conn.Close()

            Return GetLastDate

        End Using

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Try

            '1. Validate All Field
            '2. Get Total No. of Receipt From Receipt Table to Set Receipt No. (Total + 1)
            '3. Store All Data in Variables
            '4. Store New Receipt No. in Variables
            '5. Store All Data in Database.
            '6. Create Receipt From Stored Receipt No.
            '7. Save Receipt PDF on Server.
            '8. Send Email With Download Link.
            '9. Send Whatsapp Message With Download Link.
            '10. Display Message & Clear All Data For New Receipt.

            '1. Validate All Data

            lblMessage.Text = ""

            'if User ID or User Name Not Found, Redirect to Login Page, Display Please Please Login.
            If Session("UID") = "" Then

                Response.Redirect("Login.aspx")
                Exit Sub

            End If

            If Session("UserName") = "" Then

                Response.Redirect("Login.aspx")
                Exit Sub

            End If

            'If Date is empty, Then Display Message
            If String.IsNullOrEmpty(txtDate.Text) = True Then

                lblMessage.Text = "Please Select Receipt Date."
                txtDate.Focus()
                Exit Sub

            End If

            'If Donor Name is empty, Then Display Message
            If String.IsNullOrEmpty(txtDonorName.Text) = True Then

                lblMessage.Text = "Please Enter Name."
                txtDonorName.Focus()
                Exit Sub

            End If


            'If Amount is empty, Then Display Message
            If String.IsNullOrEmpty(txtAmount.Text) = True Then

                lblMessage.Text = "Please Enter Donation Amount."
                txtAmount.Focus()
                Exit Sub

            End If


            ''if Amout is More Then 2000 and mode of donation is cash then display message.
            'If Val(txtAmount.Text) > 2000 Then

            '    If DDLModeOfDonation.SelectedValue.ToUpper = "CASH" Then

            '        lblMessage.Text = "Cannot Accept Donation Amount More Then 2000 in Cash."
            '        DDLModeOfDonation.Focus()
            '        Exit Sub

            '    End If

            'End If


            'Mode of Donation is complsary From Date : 29/02/2024 - Dipakbhai na kahevathi - whatsapp ma message karelo hato.
            If String.IsNullOrEmpty(DDLModeOfDonation.SelectedValue) = True Then

                lblMessage.Text = "Please Select Mdoe of Donation."

                DDLModeOfDonation.Focus()

                Exit Sub

            End If

            ''If Mobile Number is Empty, Then Display Message.
            'If String.IsNullOrEmpty(txtMobileNumber.Text) = True Then

            '    lblMessage.Text = "Please Enter Mobile Number."
            '    txtMobileNumber.Focus()

            '    Exit Sub

            'End If

            'If Document Type is Empty, Then Display Message.
            If String.IsNullOrEmpty(DDLDocumentType.SelectedValue) = True Then

                lblMessage.Text = "Please Select Document Type."
                DDLDocumentType.Focus()

                Exit Sub

            End If

            'If Document Type is Empty, Then Display Message.
            If DDLDocumentType.SelectedValue = "0 - WITHOUT DOCUMENT" Then

                'Do Nothing

            Else

                If String.IsNullOrEmpty(txtDocumentNumber.Text) = True Then

                    lblMessage.Text = "Please Enter Document Number."
                    txtDocumentNumber.Focus()

                    Exit Sub

                End If

            End If

            If String.IsNullOrEmpty(txtPaymentDate.Text) = True Then
                lblMessage.Text = "Please Select Payment Date."
                Exit Sub
            Else
                'Do Nothing
            End If

            'If Donation Type is Empty & Also Other Type of Donation is Empty, Then Display Message.
            If String.IsNullOrEmpty(DDLDonationType.SelectedValue) = True Then

                lblMessage.Text = "Please Select Donation Type or Enter Other Type of Donation Information.."
                DDLDonationType.Focus()

                Exit Sub

            End If


            ''If Donor Address is Empty, Then Display Message.
            'If String.IsNullOrEmpty(txtDonorAddress.Text) = True Then

            '    lblMessage.Text = "Please Enter Donor Address."
            '    txtDonorAddress.Focus()

            '    Exit Sub

            'End If

            ''If Donor Email is Empty, Then Display Message.
            'If String.IsNullOrEmpty(txtDonorEmail.Text) = True Then

            '    lblMessage.Text = "Please Enter Donor Email."
            '    txtDonorEmail.Focus()

            '    Exit Sub

            'End If


            '2. Get Total No. of Receipt From Receipt Table to Set Receipt No. (Total + 1)
            Dim TotalRowCount As Integer = Nothing
            'Dim TableName As String = Nothing

            'TableName = "[2022_2023]"

            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand("Select COUNT(*) From " & TableName, conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then

                    Do While reader.Read()

                        TotalRowCount = reader.Item(0).ToString

                        'conn.Close()

                        ' Exit Sub

                    Loop

                Else

                    TotalRowCount = "0"

                    'conn.Close()

                    'Exit Sub

                End If

                reader.Close()

                conn.Close()

            End Using


            '3. Diclare Variables & Store All Data in Variables
            Dim RUID As Integer = Nothing
            Dim RUserDataMasterID As Integer = Nothing
            Dim RTitle As String = Nothing
            Dim RUserName As String = Nothing
            Dim RReceiptDate As Date = Nothing
            Dim RReceiptTime As String = Nothing
            Dim RReceiptNumber As String = Nothing
            Dim RDonorName As String = Nothing
            Dim RDonorAddress As String = Nothing
            Dim RDonorMobile As String = Nothing
            Dim RDonorEmail As String = Nothing
            Dim RDonationAmount As String = Nothing
            Dim RDocumentType As String = Nothing
            Dim RDocumentNumber As String = Nothing
            Dim RDonationType As String = Nothing
            Dim RModeOfDonation As String = Nothing
            Dim RTransectionChaqueNumber As String = Nothing
            Dim RPaymentDate As Date = Nothing
            Dim RBankName As String = Nothing
            Dim RBranchName As String = Nothing
            Dim RDetails As String = Nothing
            Dim RBySupport As String = Nothing
            Dim RCashDepositBank As String = Nothing
            Dim RDELETED As String = Nothing


            'Store Data in Variable

            RUserDataMasterID = Session("UID")

            RUserName = Session("UserName").ToString

            'If String.IsNullOrEmpty(DDLTitle.Text) = True Then
            '    'Do Nothing
            'Else

            If DDLTitle.Text = "Please Select Title" Then
                'Do Nothing
            Else
                RTitle = DDLTitle.Text
            End If

            'End If


            If String.IsNullOrEmpty(txtDate.Text) = True Then
                'Do Nothing
            Else
                RReceiptDate = txtDate.Text
            End If

            RReceiptTime = DateNow.ToLongTimeString

            TotalRowCount = TotalRowCount + 1

            If TotalRowCount = 0 Then

                RReceiptNumber = Mid(TableName, 2, 4) & "-" & Mid(TableName, 9, 2) & "/000" & Val(TotalRowCount)

            ElseIf TotalRowCount.ToString.Length = 1 Then

                RReceiptNumber = Mid(TableName, 2, 4) & "-" & Mid(TableName, 9, 2) & "/000" & Val(TotalRowCount)

            ElseIf TotalRowCount.ToString.Length = 2 Then

                RReceiptNumber = Mid(TableName, 2, 4) & "-" & Mid(TableName, 9, 2) & "/00" & Val(TotalRowCount)

            ElseIf TotalRowCount.ToString.Length = 3 Then

                RReceiptNumber = Mid(TableName, 2, 4) & "-" & Mid(TableName, 9, 2) & "/0" & Val(TotalRowCount)

            ElseIf TotalRowCount.ToString.Length = 4 Then

                RReceiptNumber = Mid(TableName, 2, 4) & "-" & Mid(TableName, 9, 2) & "/" & Val(TotalRowCount)

            End If

            If String.IsNullOrEmpty(txtDonorName.Text) = True Then

                'Do Nothing
            Else

                RDonorName = txtDonorName.Text


            End If

            If String.IsNullOrEmpty(txtDonorAddress.Text) = True Then

                'Do Nothing
            Else

                RDonorAddress = txtDonorAddress.Text
                RDonorAddress = Replace(RDonorAddress, vbCrLf, " ")
                RDonorAddress = Replace(RDonorAddress, vbCr, " ")
                RDonorAddress = Replace(RDonorAddress, vbLf, " ")

            End If

            If String.IsNullOrEmpty(txtMobileNumber.Text) = True Then

                'Do Nothing
            Else

                If Microsoft.VisualBasic.Left(txtMobileNumber.Text, 1) = "0" Or Microsoft.VisualBasic.Left(txtMobileNumber.Text, 1) = "+" Then
                    RDonorMobile = Microsoft.VisualBasic.Mid(txtMobileNumber.Text, 2)
                Else
                    RDonorMobile = txtMobileNumber.Text
                End If

            End If


            If String.IsNullOrEmpty(txtDonorEmail.Text) = True Then

                'Do Nothing
            Else

                RDonorEmail = txtDonorEmail.Text

            End If


            If String.IsNullOrEmpty(txtAmount.Text) = True Then

                'Do Nothing
            Else

                RDonationAmount = Val(txtAmount.Text)

            End If


            If String.IsNullOrEmpty(DDLDocumentType.SelectedValue) = True Then

                'Do Nothing
            Else

                RDocumentType = DDLDocumentType.SelectedValue

            End If

            If String.IsNullOrEmpty(txtDocumentNumber.Text) = True Then

                'Do Nothing
            Else

                RDocumentNumber = txtDocumentNumber.Text

            End If



            If String.IsNullOrEmpty(DDLDonationType.SelectedValue) = True Then

                'Do Nothing

            Else

                RDonationType = DDLDonationType.SelectedValue

            End If


            If String.IsNullOrEmpty(DDLModeOfDonation.SelectedValue) = True Then

                'Do Nothing

            Else

                RModeOfDonation = DDLModeOfDonation.SelectedValue

            End If

            If String.IsNullOrEmpty(txtTransectionChaqueNumber.Text) = True Then

                'Do Nothing
            Else

                RTransectionChaqueNumber = txtTransectionChaqueNumber.Text

            End If

            If String.IsNullOrEmpty(txtPaymentDate.Text) = True Then

                'Do Nothing
            Else

                RPaymentDate = txtPaymentDate.Text

            End If

            If String.IsNullOrEmpty(txtBankName.Text) = True Then

                'Do Nothing
            Else

                RBankName = txtBankName.Text

            End If


            If String.IsNullOrEmpty(txtBranchName.Text) = True Then

                'Do Nothing
            Else

                RBranchName = txtBranchName.Text

            End If


            If String.IsNullOrEmpty(txtDetail.Text) = True Then

                'Do Nothing
            Else

                RDetails = txtDetail.Text

            End If


            If String.IsNullOrEmpty(txtBySupport.Text) = True Then

                'Do Nothing
            Else

                RBySupport = txtBySupport.Text


            End If


            '5. Store All Data in Database (Insert New Data)
            'Using conn As SqlConnection = ReturnConnection()

            '    Dim cmd As New SqlCommand("INSERT INTO " & TableName & " ( UserDataMasterID, UserName, ReceiptDate, ReceiptNumber, DonorName, DonationAmount, DonorMobile, DocumentType, DocumentNumber, DonationType, OtherDonationType, ModeOfDonation, OtherModeOfDonation, DonorAddress, DonorEmail, DonorCountry, Remarks, DELETED ) VALUES ( '" & RUserDataMasterID & "' , '" & RUserName & "',  '" & RReceiptDate & "',  '" & RReceiptNumber & "',  '" & RDonorName & "',  '" & RDonationAmount & "',  '" & RDonorMobile & "',  '" & RDocumentType & "',  '" & RDocumentNumber & "',  '" & RDonationType & "',  '" & ROtherDonationType & "',  '" & RModeOfDonation & "',  '" & ROtherModeOfDonation & "',  '" & RDonorAddress & "',  '" & RDonorEmail & "',  '" & RDonorCountry & "',  '" & RRemarks & "',  '" & RDELETED & "')", conn)

            '    conn.Open()

            '    cmd.ExecuteNonQuery()

            '    conn.Close()

            'End Using

            If String.IsNullOrEmpty(RReceiptNumber) = True Then

                lblMessage.Text = "Receipt Number is Not Created, Please Contact Admin."
                Exit Sub

            End If

            '6.  Open Tabel & Insert All Data.

            Dim SQName As String = Nothing
            SQName = "Sequence_" & Mid(TableName, 2, 9)

            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand

                Using Query As New SqlClient.SqlCommand

                    conn.Open()

                    With Query

                        .Connection = conn

                        .CommandText = "INSERT INTO " & TableName & " (UID, UserDataMasterID,  UserName, ReceiptDate,  ReceiptTime, ReceiptNumber, Title, DonorName, DonorAddress, DonorMobile, DonorEmail, DonationAmount, DocumentType, DocumentNumber, DonationType, ModeOfDonation, TransectionChaqueNumber, PaymentDate, BankName, BranchName, Details, BySupport, CashDepositBank, DELETED) VALUES (NEXT VALUE for " & SQName & ", @RUserDataMasterID,  @RUserName, @RReceiptDate, @RReceiptTime, @RReceiptNumber, @RTitle, @RDonorName, @RDonorAddress, @RDonorMobile, @RDonorEmail, @RDonationAmount, @RDocumentType, @RDocumentNumber, @RDonationType, @RModeOfDonation, @RTransectionChaqueNumber, @RPaymentDate, @RBankName, @RBranchName, @RDetails, @RBySupport, @RCashDepositBank, @RDELETED)"

                        If String.IsNullOrEmpty(RUserDataMasterID) = True Then
                            .Parameters.AddWithValue("@RUserDataMasterID", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RUserDataMasterID", RUserDataMasterID)
                        End If


                        If String.IsNullOrEmpty(RUserName) = True Then
                            .Parameters.AddWithValue("@RUserName", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RUserName", RUserName)
                        End If

                        'Check SQLDateNull Variable in ModVariable Module
                        'Check This Website
                        'https://www.c-sharpcorner.com/article/enter-null-values-for-datetime-column-of-sql-server/
                        If String.IsNullOrEmpty(RReceiptDate) = True Then

                            .Parameters.AddWithValue("@RReceiptDate", SqlDateTime.Null)

                        ElseIf RReceiptDate = "#1/1/0001 12:00:00 AM#" Then

                            .Parameters.AddWithValue("@RReceiptDate", SqlDateTime.Null)

                        Else

                            .Parameters.AddWithValue("@RReceiptDate", RReceiptDate)

                        End If

                        If String.IsNullOrEmpty(RReceiptTime) = True Then
                            .Parameters.AddWithValue("@RReceiptTime", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RReceiptTime", RReceiptTime)
                        End If

                        If String.IsNullOrEmpty(RReceiptNumber) = True Then
                            .Parameters.AddWithValue("@RReceiptNumber", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RReceiptNumber", RReceiptNumber)
                        End If

                        If String.IsNullOrEmpty(RTitle) = True Then
                            .Parameters.AddWithValue("@RTitle", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RTitle", RTitle)
                        End If


                        If String.IsNullOrEmpty(RDonorName) = True Then
                            .Parameters.AddWithValue("@RDonorName", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDonorName", RDonorName)
                        End If

                        If String.IsNullOrEmpty(RDonorAddress) = True Then
                            .Parameters.AddWithValue("@RDonorAddress", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDonorAddress", RDonorAddress)
                        End If

                        If String.IsNullOrEmpty(RDonorMobile) = True Then
                            .Parameters.AddWithValue("@RDonorMobile", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDonorMobile", RDonorMobile)
                        End If

                        If String.IsNullOrEmpty(RDonorEmail) = True Then
                            .Parameters.AddWithValue("@RDonorEmail", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDonorEmail", RDonorEmail)
                        End If

                        If String.IsNullOrEmpty(RDonationAmount) = True Then
                            .Parameters.AddWithValue("@RDonationAmount", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDonationAmount", RDonationAmount)
                        End If

                        If String.IsNullOrEmpty(RDocumentType) = True Then
                            .Parameters.AddWithValue("@RDocumentType", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDocumentType", RDocumentType)
                        End If


                        If String.IsNullOrEmpty(RDocumentNumber) = True Then
                            .Parameters.AddWithValue("@RDocumentNumber", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDocumentNumber", RDocumentNumber)
                        End If

                        If String.IsNullOrEmpty(RDonationType) = True Then
                            .Parameters.AddWithValue("@RDonationType", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDonationType", RDonationType)
                        End If


                        If String.IsNullOrEmpty(RModeOfDonation) = True Then
                            .Parameters.AddWithValue("@RModeOfDonation", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RModeOfDonation", RModeOfDonation)
                        End If

                        If String.IsNullOrEmpty(RTransectionChaqueNumber) = True Then
                            .Parameters.AddWithValue("@RTransectionChaqueNumber", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RTransectionChaqueNumber", RTransectionChaqueNumber)
                        End If


                        'Check SQLDateNull Variable in ModVariable Module
                        'Check This Website
                        'https://www.c-sharpcorner.com/article/enter-null-values-for-datetime-column-of-sql-server/
                        If String.IsNullOrEmpty(RPaymentDate) = True Then

                            .Parameters.AddWithValue("@RPaymentDate", SqlDateTime.Null)

                        ElseIf RReceiptDate = "#1/1/0001 12:00:00 AM#" Then

                            .Parameters.AddWithValue("@RPaymentDate", SqlDateTime.Null)

                        Else

                            .Parameters.AddWithValue("@RPaymentDate", RPaymentDate)

                        End If


                        If String.IsNullOrEmpty(RBankName) = True Then
                            .Parameters.AddWithValue("@RBankName", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RBankName", RBankName)
                        End If

                        If String.IsNullOrEmpty(RBranchName) = True Then
                            .Parameters.AddWithValue("@RBranchName", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RBranchName", RBranchName)
                        End If


                        If String.IsNullOrEmpty(RDetails) = True Then
                            .Parameters.AddWithValue("@RDetails", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDetails", RDetails)
                        End If

                        If String.IsNullOrEmpty(RBySupport) = True Then
                            .Parameters.AddWithValue("@RBySupport", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RBySupport", RBySupport)
                        End If


                        If String.IsNullOrEmpty(RCashDepositBank) = True Then
                            .Parameters.AddWithValue("@RCashDepositBank", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RCashDepositBank", RCashDepositBank)
                        End If


                        If String.IsNullOrEmpty(RDELETED) = True Then
                            .Parameters.AddWithValue("@RDELETED", DBNull.Value)
                        Else
                            .Parameters.AddWithValue("@RDELETED", RDELETED)
                        End If

                    End With

                    Query.ExecuteNonQuery()

                    conn.Close()

                End Using

            End Using


            'GetRBU ContactPersonName And Mobile Number
            Dim RBUContactPersonName As String = Nothing
            Dim RBUMobileNumber As String = Nothing

            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand("SELECT [ContactPersonName], [Mobile] FROM UserData WHERE UID = '" & RUserDataMasterID & "' ", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then

                    Do While reader.Read()

                        RBUContactPersonName = reader.Item(0).ToString
                        RBUMobileNumber = reader.Item(1).ToString

                    Loop

                End If

                reader.Close()

                conn.Close()

            End Using


            'Create Receipt PDF & Abhar Darshan PDF And Save to Server.
            ' Create a report. 
            Dim Report As New XtraReportReceipt

            'Code For Create Receipt
            Report.xrReceiptNumber.Text = RReceiptNumber
            Report.xrReceiptDate.Text = RReceiptDate
            Report.xrReceiptTime.Text = RReceiptTime
            Report.xrRBUName.Text = RBUContactPersonName
            Report.xrCanceled.Visible = False

            If String.IsNullOrEmpty(RDonorMobile) = True Then

                Report.xrMobile.Text = "-"

            Else

                Report.xrMobile.Text = RDonorMobile

            End If

            If String.IsNullOrEmpty(RDonorEmail) = True Then

                Report.xrEmail.Text = "-"

            Else

                Report.xrEmail.Text = StrConv(RDonorEmail, VbStrConv.Lowercase)

            End If

            If String.IsNullOrEmpty(RTitle) = True Then

                Report.xrDonorName.Text = StrConv(RDonorName, VbStrConv.ProperCase)

                If RDonorName.ToString.Length > 66 Then
                    Report.xrDonorName.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly
                End If

            Else

                If RTitle = "Please Select Title" Then

                    'Do Nothing

                Else

                    Report.xrDonorName.Text = StrConv(RTitle, VbStrConv.ProperCase) & " " & StrConv(RDonorName, VbStrConv.ProperCase)

                    If RDonorName.ToString.Length > 66 Then
                        Report.xrDonorName.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly
                    End If

                End If

            End If

            If String.IsNullOrEmpty(RDonorAddress) = True Then

                Report.xrAddress.Text = "-"

            Else

                Report.xrAddress.Text = StrConv(RDonorAddress, VbStrConv.ProperCase)

                If RDonorAddress.ToString.Length > 66 Then
                    Report.xrAddress.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly
                End If


            End If

            If String.IsNullOrEmpty(RDocumentType) = True Or RDocumentType = "0 - WITHOUT DOCUMENT" Then

                Report.xrlblDocumentType.Text = "-"

            Else

                Report.xrlblDocumentType.Text = StrConv(RDocumentType, VbStrConv.ProperCase)

            End If

            If String.IsNullOrEmpty(RDocumentNumber) = True Then

                Report.xrDocumentNumber.Text = "-"

            Else

                Report.xrDocumentNumber.Text = StrConv(RDocumentNumber, VbStrConv.Uppercase)

            End If

            Report.xrAmount.Text = RDonationAmount & ".00"
            Report.xrRupeesInWord.Text = StrConv(RupeesToWord(RDonationAmount), VbStrConv.ProperCase)

            If String.IsNullOrEmpty(RModeOfDonation) = True Then

                Report.xrModeOfDonation.Text = "-"

            Else

                Report.xrModeOfDonation.Text = StrConv(RModeOfDonation, VbStrConv.ProperCase)

            End If

            If String.IsNullOrEmpty(RTransectionChaqueNumber) = True Then

                Report.xrTransectionNumber.Text = "-"

            Else

                Report.xrTransectionNumber.Text = StrConv(RTransectionChaqueNumber, VbStrConv.ProperCase)

            End If


            Report.xrPaymentDate.Text = RPaymentDate

            If String.IsNullOrEmpty(RBankName) = True Then

                Report.xrBankName.Text = "-"

            Else

                Report.xrBankName.Text = StrConv(RBankName, VbStrConv.Uppercase)

            End If

            If String.IsNullOrEmpty(RBranchName) = True Then

                Report.xrBranchName.Text = "-"

            Else

                Report.xrBranchName.Text = StrConv(RBranchName, VbStrConv.ProperCase)

            End If

            If String.IsNullOrEmpty(RDonationType) = True Then

                Report.xrDonationType.Text = "-"

            Else

                Report.xrDonationType.Text = StrConv(RDonationType, VbStrConv.ProperCase)

            End If

            If String.IsNullOrEmpty(RDetails) = True Then

                Report.xrDetail.Text = "-"

            Else

                Report.xrDetail.Text = StrConv(RDetails, VbStrConv.ProperCase)

            End If

            If String.IsNullOrEmpty(RBySupport) = True Then

                Report.xrBySupport.Text = "-"

            Else

                Report.xrBySupport.Text = StrConv(RBySupport, VbStrConv.ProperCase)

                If RBySupport.ToString.Length > 66 Then
                    Report.xrBySupport.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly
                End If

            End If

            Report.xrAmount1.Text = RDonationAmount & ".00"

            'For Abhar Darshan
            Report.xrReceiptDate1.Text = RReceiptDate


            If String.IsNullOrEmpty(RTitle) = True Then
                Report.xrDonorName1.Text = StrConv(RDonorName, VbStrConv.ProperCase)

                If RDonorName.ToString.Length > 66 Then
                    Report.xrDonorName1.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly
                End If

            Else
                If RTitle = "Please Select Title" Then
                    'Do Nothing
                Else
                    Report.xrDonorName1.Text = StrConv(RTitle, VbStrConv.ProperCase) & " " & StrConv(RDonorName, VbStrConv.ProperCase)

                    If RDonorName.ToString.Length > 66 Then
                        Report.xrDonorName1.TextFitMode = DevExpress.XtraReports.UI.TextFitMode.ShrinkOnly
                    End If

                End If

            End If

            Report.xrAmount2.Text = RDonationAmount & ".00"
            Report.xrReceiptNumber1.Text = RReceiptNumber

            Dim TempPDFName As String = Nothing
            TempPDFName = Microsoft.VisualBasic.Replace(RReceiptNumber, "/", "_", 1, -1, CompareMethod.Text)


            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            'Set Password and Permission
            Report.ExportOptions.Pdf.PasswordSecurityOptions.PermissionsOptions.EnableCopying = False
            Report.ExportOptions.Pdf.PasswordSecurityOptions.PermissionsOptions.ChangingPermissions = DevExpress.XtraPrinting.ChangingPermissions.None


            'Check Mobile Number is avilable or not, If Availble then set as mobile number as password else set password is : 1234

            If Report.xrMobile.Text = "-" Then
                Report.ExportOptions.Pdf.PasswordSecurityOptions.PermissionsPassword = "1234"
                Report.ExportOptions.Pdf.PasswordSecurityOptions.OpenPassword = "1234"
            Else
                Report.ExportOptions.Pdf.PasswordSecurityOptions.PermissionsPassword = Report.xrMobile.Text
                Report.ExportOptions.Pdf.PasswordSecurityOptions.OpenPassword = Report.xrMobile.Text
            End If

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            Report.ExportToPdf(Server.MapPath("~") & "Receipt_PDF\" & TempPDFName & ".pdf")



            lblMessage.Text = "PDF Generated Successfully."

            If String.IsNullOrEmpty(RDonorEmail) = True Then
                'Don't Send Email

            Else

                'Send Email With Attachment.
                Dim StrHTML As String = Nothing

                StrHTML = StrHTML & "Dear " & RDonorName & ","
                StrHTML = StrHTML & "<BR><BR>"
                StrHTML = StrHTML & "🙏🏼Thank you for your generous donation to Mota Vadala Gau Seva Rahat Trust."
                StrHTML = StrHTML & "<BR><BR>"
                StrHTML = StrHTML & "Your contribution will play a large role in helping us in 🐂🐄 Animal Welfare 🐕‍🦺🐑🐓."
                StrHTML = StrHTML & "<BR><BR>"
                StrHTML = StrHTML & "⁉️&nbsp;If you have any questions/query, please don’t hesitate to contact us."
                StrHTML = StrHTML & "<BR><BR>"
                StrHTML = StrHTML & "✅&nbsp;Looking forward to your continued support in future."
                StrHTML = StrHTML & "<BR><BR>"
                StrHTML = StrHTML & "Please download donation receipt no.:&nbsp;" & RReceiptNumber & " from pdf attachment."
                StrHTML = StrHTML & "<BR><BR>"
                StrHTML = StrHTML & "Enter your mobile number as the password."
                StrHTML = StrHTML & "<BR><BR>"
                StrHTML = StrHTML & "Thanks again. ✍️"
                StrHTML = StrHTML & "<BR><BR>"
                StrHTML = StrHTML & "In gratitude,"
                StrHTML = StrHTML & "<BR>"
                StrHTML = StrHTML & "Trustees & Management Committee,"
                StrHTML = StrHTML & "<BR>"
                StrHTML = StrHTML & "Mota Vadala Gau Seva Rahat Trust."


                Dim MailMessage As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage

                MailMessage.From = New System.Net.Mail.MailAddress("info@motavadalagauseva.org", "info@motavadalagauseva.org")
                'MailMessage.Headers.Add("Reply-To", "motavadalagauseva@gmail.com")
                MailMessage.Headers.Add("Reply-To", "info@motavadalagauseva.org")
                MailMessage.To.Add(New System.Net.Mail.MailAddress(RDonorEmail.ToLower))
                MailMessage.Subject = "Mota Vadala Gau Seva Rahat Trust - Donation Receipt"
                MailMessage.IsBodyHtml = True
                MailMessage.Body = StrHTML

                Dim ct As System.Net.Mime.ContentType = New System.Net.Mime.ContentType("Application/PDF")

                'Add Receipt as Attachment.
                Dim Att As New System.Net.Mail.Attachment(Server.MapPath("~") & "Receipt_PDF\" & TempPDFName & ".pdf", ct)
                MailMessage.Attachments.Add(Att)

                Dim SMTPClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient()

                SMTPClient.Host = "mail.motavadalagauseva.org"
                SMTPClient.Port = "25"
                SMTPClient.EnableSsl = False

                SMTPClient.Credentials = New System.Net.NetworkCredential("info@motavadalagauseva.org", "Mota@123$")

                SMTPClient.Send(MailMessage)

            End If


            Dim TempMobileNumber As String = Nothing

            If String.IsNullOrEmpty(RDonorMobile) = True Then

                TempMobileNumber = RBUMobileNumber

            Else

                TempMobileNumber = RDonorMobile

            End If

            Session("Page2Redirect") = "Receipt"
            Session("TempMobile") = TempMobileNumber

            If String.IsNullOrEmpty(RTitle) = True Then
                Session("DonorName") = RDonorName
            Else
                Session("DonorName") = RTitle & " " & RDonorName
            End If

            Session("DonationAmount") = RDonationAmount
            Session("PDFfileName") = TempPDFName


            'Send Whatsapp Message
            If String.IsNullOrEmpty(Session("TempMobile")) = True Then
                'Don't Send Whatsapp
                'Display Confirmation

                Dim meta As New HtmlMeta()

                meta.HttpEquiv = "Refresh"
                meta.Content = "10;url=Receipt.aspx"

                Me.Page.Controls.Add(meta)
                lblMessage.Text = "Receipt is Generated, </br> You will now be redirected in 10 seconds."

            Else

                'Below All 3 Line of Code is Working Perfectly.
                'Line With Start Whatsapp Protocol is For Web and Also Mobile.

                'Send PDF Download link to Whatsapp.
                'Response.Redirect("https://api.whatsapp.com/send?phone=" & RDonorMobile & "&text=Please%20Download%20Donation%20Receipt%20From%20Below%20Location.%20%20%20%20%20%20%20%20%20%20www.motavadalagauseva.org\Receipt_PDF\" & TempPDFName & ".pdf")
                'Response.Redirect("whatsapp://send?phone=" & RDonorMobile & "&text=Please%20Download%20Donation%20Receipt%20From%20Below%20Location.%20%20%20%20%20%20%20%20%20%20www.motavadalagauseva.org\Receipt_PDF\" & TempPDFName & ".pdf", False)
                'hlTest.NavigateUrl = "whatsapp://send?phone=" & RDonorMobile & "&text=Please%20Download%20Donation%20Receipt%20From%20Below%20Location.%20%20%20%20%20%20%20%20%20%20www.motavadalagauseva.org\Receipt_PDF\" & TempPDFName & ".pdf"

                'Page.ClientScript.RegisterStartupScript(Me.[GetType](), "clickLink", "ClickLink();", True)


                'Display Confirmation
                Dim meta1 As New HtmlMeta()

                meta1.HttpEquiv = "Refresh"
                meta1.Content = "10;url=whatsapp.aspx?91" & Session("TempMobile") & "," & Session("DonorName") & "," & Session("DonationAmount") & "," & Session("PDFfileName") & ".pdf"

                Me.Page.Controls.Add(meta1)
                lblMessage.Text = "Receipt is Generated, </br> You will now be redirected in 10 seconds."

            End If

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

    Public Function RupeesToWord(ByVal MyNumber As String) As String

        On Error Resume Next

        Dim Temp = Nothing
        Dim Rupees As String = Nothing
        Dim Paisa As String = Nothing
        Dim DecimalPlace = Nothing
        Dim iCount = Nothing
        Dim Hundreds As String = Nothing
        Dim Words As String = Nothing
        Dim place(9) As String
        place(0) = " Thousand "
        place(2) = " Lakh "
        place(4) = " Crore "
        place(6) = " Arab "
        place(8) = " Kharab "
        On Error Resume Next
        ' Convert MyNumber to a string, trimming extra spaces.
        MyNumber = Trim(Str(MyNumber))

        ' Find decimal place.
        DecimalPlace = InStr(MyNumber, ".")

        ' If we find decimal place...
        If DecimalPlace > 0 Then
            ' Convert Paisa
            Temp = Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            Paisa = " and " & ConvertTens(Temp) & " Paisa"

            ' Strip off paisa from remainder to convert.
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If

        '===============================================================
        Dim TM As String  ' If MyNumber between Rs.1 To 99 Only.
        TM = Right(MyNumber, 2)

        If Len(MyNumber) > 0 And Len(MyNumber) <= 2 Then
            If Len(TM) = 1 Then
                Words = ConvertDigit(TM)
                RupeesToWord = Words & Paisa & " Only"

                Exit Function

            Else
                If Len(TM) = 2 Then
                    Words = ConvertTens(TM)
                    RupeesToWord = Words & Paisa & " Only"
                    Exit Function

                End If
            End If
        End If
        '===============================================================


        ' Convert last 3 digits of MyNumber to ruppees in word.
        Hundreds = ConvertHundreds(Right(MyNumber, 3))
        ' Strip off last three digits
        MyNumber = Left(MyNumber, Len(MyNumber) - 3)

        iCount = 0
        Do While MyNumber <> ""
            'Strip last two digits
            Temp = Right(MyNumber, 2)
            If Len(MyNumber) = 1 Then


                If Trim(Words) = "Thousand" Or
                Trim(Words) = "Lakh  Thousand" Or
                Trim(Words) = "Lakh" Or
                Trim(Words) = "Crore" Or
                Trim(Words) = "Crore  Lakh  Thousand" Or
                Trim(Words) = "Arab  Crore  Lakh  Thousand" Or
                Trim(Words) = "Arab" Or
                Trim(Words) = "Kharab  Arab  Crore  Lakh  Thousand" Or
                Trim(Words) = "Kharab" Then

                    Words = ConvertDigit(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                Else

                    Words = ConvertDigit(Temp) & place(iCount) & Words
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                End If
            Else

                If Trim(Words) = "Thousand" Or
                   Trim(Words) = "Lakh  Thousand" Or
                   Trim(Words) = "Lakh" Or
                   Trim(Words) = "Crore" Or
                   Trim(Words) = "Crore  Lakh  Thousand" Or
                   Trim(Words) = "Arab  Crore  Lakh  Thousand" Or
                   Trim(Words) = "Arab" Then


                    Words = ConvertTens(Temp) & place(iCount)


                    MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                Else

                    '=================================================================
                    ' if only Lakh, Crore, Arab, Kharab

                    If Trim(ConvertTens(Temp) & place(iCount)) = "Lakh" Or
                       Trim(ConvertTens(Temp) & place(iCount)) = "Crore" Or
                       Trim(ConvertTens(Temp) & place(iCount)) = "Arab" Then

                        Words = Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    Else
                        Words = ConvertTens(Temp) & place(iCount) & Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    End If

                End If
            End If

            iCount = iCount + 2
        Loop

        RupeesToWord = Words & Hundreds & Paisa & " Only"
    End Function

    ' Conversion for hundreds
    '*****************************************
    Private Function ConvertHundreds(ByVal MyNumber As String) As String
        ConvertHundreds = Nothing
        Dim Result As String = Nothing

        ' Exit if there is nothing to convert.
        If Val(MyNumber) = 0 Then Exit Function

        ' Append leading zeros to number.
        MyNumber = Right("000" & MyNumber, 3)

        ' Do we have a hundreds place digit to convert?
        If Left(MyNumber, 1) <> "0" Then
            Result = ConvertDigit(Left(MyNumber, 1)) & " Hundred "
        End If

        ' Do we have a tens place digit to convert?
        If Mid(MyNumber, 2, 1) <> "0" Then
            Result = Result & ConvertTens(Mid(MyNumber, 2))
        Else
            ' If not, then convert the ones place digit.
            Result = Result & ConvertDigit(Mid(MyNumber, 3))
        End If

        ConvertHundreds = Trim(Result)

    End Function

    ' Conversion for tens
    '*****************************************
    Private Function ConvertTens(ByVal MyTens As String) As String
        Dim Result As String = Nothing

        ' Is value between 10 and 19?
        If Val(Left(MyTens, 1)) = 1 Then
            Select Case Val(MyTens)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else
            ' .. otherwise it's between 20 and 99.
            Select Case Val(Left(MyTens, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select

            ' Convert ones place digit.
            Result = Result & ConvertDigit(Right(MyTens, 1))
        End If

        ConvertTens = Result
    End Function

    Private Function ConvertDigit(ByVal MyDigit As String) As String
        Select Case Val(MyDigit)
            Case 1 : ConvertDigit = "One"
            Case 2 : ConvertDigit = "Two"
            Case 3 : ConvertDigit = "Three"
            Case 4 : ConvertDigit = "Four"
            Case 5 : ConvertDigit = "Five"
            Case 6 : ConvertDigit = "Six"
            Case 7 : ConvertDigit = "Seven"
            Case 8 : ConvertDigit = "Eight"
            Case 9 : ConvertDigit = "Nine"
            Case Else : ConvertDigit = ""
        End Select
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Try

            'DDLTitle.Text = "Please Select Title."
            DDLTitle.SelectedIndex = 0
            txtDonorName.Text = ""
            txtDonorAddress.Text = ""
            txtMobileNumber.Text = ""
            txtDonorEmail.Text = ""
            txtAmount.Text = ""
            'DDLDocumentType.Text = "Select Document Type"
            DDLDocumentType.SelectedIndex = 0
            txtDocumentNumber.Text = ""
            DDLDonationType.SelectedIndex = 0
            'DDLModeOfDonation.Text = "Select Mode of Donation"
            DDLModeOfDonation.SelectedIndex = 0
            txtTransectionChaqueNumber.Text = ""
            txtPaymentDate.Text = ""
            txtBankName.Text = ""
            txtBranchName.Text = ""
            txtDetail.Text = ""
            txtBySupport.Text = ""
            lblMessage.Text = ""

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub

    Private Sub btnViewOldReceipt_Click(sender As Object, e As EventArgs) Handles btnViewOldReceipt.Click

        Try

            'Session(UID) is Used in SQL Query

            Response.Redirect("ViewOldReceipt.aspx")

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click

        'Dim TableName As String = ConfigurationManager.AppSettings("TableName").ToString()

        On Error Resume Next

        Dim YearName As String = ""

        Do While Not YearName = "[2022_2023]"

            If String.IsNullOrEmpty(YearName) = True Then

                YearName = TableName

            Else

                YearName = "[" & Microsoft.VisualBasic.Mid(YearName, 2, 2) & Val(Microsoft.VisualBasic.Mid(YearName, 4, 2) - 1).ToString & "_" & Microsoft.VisualBasic.Mid(YearName, 7, 2) & Val(Microsoft.VisualBasic.Mid(YearName, 9, 2) - 1).ToString & "]"

            End If

            'lblMessage.Text = YearName

            Using conn As SqlConnection = ReturnConnection()

                Dim cmd As New SqlCommand("SELECT TOP (1) * FROM " & YearName & " WHERE DELETED Is NULL AND DonorMobile = '" & txtMobileNumber.Text & "' ORDER BY UID DESC", conn)

                conn.Open()

                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then

                    Do While reader.Read()

                        Select Case reader.Item(6).ToString.ToUpper
                            Case "SHRIMAN"
                                DDLTitle.SelectedIndex = 1
                            Case "SHRI"
                                DDLTitle.SelectedIndex = 2
                            Case "SHRIMATI"
                                DDLTitle.SelectedIndex = 3
                            Case "SHREEMATI"
                                DDLTitle.SelectedIndex = 3
                            Case "MR."
                                DDLTitle.SelectedIndex = 4
                            Case "MRS."
                                DDLTitle.SelectedIndex = 5
                            Case "M/S."
                                DDLTitle.SelectedIndex = 6
                            Case "MASTER"
                                DDLTitle.SelectedIndex = 7
                            Case "MISS."
                                DDLTitle.SelectedIndex = 8
                            Case Else
                                DDLTitle.SelectedIndex = 0
                        End Select

                        txtDonorName.Text = reader.Item(7).ToString
                        txtDonorAddress.Text = reader.Item(8).ToString
                        txtDonorEmail.Text = reader.Item(10).ToString

                        Select Case reader.Item(12).ToString.ToUpper
                            Case "1 - PAN CARD"
                                DDLDocumentType.SelectedIndex = 1
                            Case "2 - AADHAAR CARD"
                                DDLDocumentType.SelectedIndex = 2
                            Case "4 - PASSPORT"
                                DDLDocumentType.SelectedIndex = 3
                            Case "6 - DRIVING LICENSE"
                                DDLDocumentType.SelectedIndex = 4
                            Case "0 - WITHOUT DOCUMENT"
                                DDLDocumentType.SelectedIndex = 5
                        End Select

                        txtDocumentNumber.Text = reader.Item(13).ToString

                    Loop

                    Exit Do

                End If

                reader.Close()

                conn.Close()

            End Using

        Loop

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        On Error Resume Next

        Session("UID") = ""
        Session("UserName") = ""

        Response.Redirect("Login.aspx")

    End Sub

    Public Shared Function DateNow() As DateTime

        On Error Resume Next

        Dim utcTime As DateTime = DateTime.UtcNow
        Dim myZone As TimeZoneInfo = TimeZoneInfo.CreateCustomTimeZone("INDIA", New TimeSpan(+5, +30, 0), "India", "India")
        Dim custDateTime As DateTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, myZone)
        Return custDateTime

    End Function

End Class


