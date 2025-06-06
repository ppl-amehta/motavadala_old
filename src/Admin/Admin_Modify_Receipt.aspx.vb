﻿Imports DevExpress.Web
Imports DevExpress.Export
Imports DevExpress.XtraPrinting
Imports System.IO
Imports DevExpress.XtraPrintingLinks
Imports System.Net.Mime
Imports DevExpress.Web.Data
Imports System.Data
Imports System.Data.SqlClient

Partial Class Admin_Modify_Receipt
    Inherits System.Web.UI.Page

    Friend ResultMessage As String = Nothing

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        On Error Resume Next

        Response.Redirect("Admin_Menu.aspx")

    End Sub

    Private Sub Admin_Modify_Receipt_Load(sender As Object, e As EventArgs) Handles Me.Load
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



        If Session("YearName") = "" Then

            'Do Nothing


            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            'Working Code For Get Table Name
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


            Dim CurrentDate As String = DateNow.Date.ToShortDateString
            Dim FutureDate As String = "01/04/" & DateNow.Year

            'lblMessage.Text = CurrentDate & " - " & FutureDate

            If CDate(CurrentDate) >= CDate(FutureDate) Then
                'lblMessage.Text = "[" & DateNow.Year & "_" & DateNow.Year + 1 & "]"
                Session("YearName") = DateNow.Year & "_" & DateNow.Year + 1
            Else
                If CDate(CurrentDate).Month.ToString = "1" Or CDate(CurrentDate).Month.ToString = "2" Or CDate(CurrentDate).Month.ToString = "3" Then
                    'lblMessage.Text = "[" & DateNow.Year - 1 & "_" & DateNow.Year & "]"
                    Session("YearName") = DateNow.Year - 1 & "_" & DateNow.Year
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
                    Session("YearName") = DateNow.Year - 1 & "_" & DateNow.Year
                Else
                    'lblMessage.Text = "[" & DateNow.Year & "_" & DateNow.Year + 1 & "]"
                    Session("YearName") = DateNow.Year & "_" & DateNow.Year + 1
                End If
            End If

            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            SqlDataSource1.ID = "SqlDataSource1"
            ' Me.Page.Controls.Add(SqlDataSource1)
            SqlDataSource1.ConnectionString = ConfigurationManager.ConnectionStrings("MotaVadala_MSSQL_ConnectionString").ConnectionString
            SqlDataSource1.SelectCommand = "SELECT * FROM  [" & Session("YearName") & "] ORDER BY [UID] DESC"
            SqlDataSource1.UpdateCommand = "UPDATE [" & Session("YearName") & "] SET [UserDataMasterID] = @UserDataMasterID, [UserName] = @UserName, [ReceiptDate] = @ReceiptDate, [ReceiptTime] = @ReceiptTime, [ReceiptNumber] = @ReceiptNumber, [Title] = @Title, [DonorName] = @DonorName, [DonorAddress] = @DonorAddress, [DonorMobile] = @DonorMobile, [DonorEmail] = @DonorEmail, [DonationAmount] = @DonationAmount, [DocumentType] = @DocumentType, [DocumentNumber] = @DocumentNumber, [DonationType] = @DonationType, [ModeOfDonation] = @ModeOfDonation, [TransectionChaqueNumber] = @TransectionChaqueNumber, [PaymentDate] = @PaymentDate, [BankName] = @BankName, [BranchName] = @BranchName, [Details] = @Details, [BySupport] = @BySupport, [CashDepositBank] = @CashDepositBank, [DELETED] = @DELETED WHERE [UID] = @original_UID"

            ASPxGridView1.DataSourceID = "SqlDataSource1"
            ASPxGridView1.DataBind()


        Else

            SqlDataSource1.ID = "SqlDataSource1"
            ' Me.Page.Controls.Add(SqlDataSource1)
            SqlDataSource1.ConnectionString = ConfigurationManager.ConnectionStrings("MotaVadala_MSSQL_ConnectionString").ConnectionString
            SqlDataSource1.SelectCommand = "SELECT * FROM  [" & Session("YearName") & "] ORDER BY [UID] DESC"
            SqlDataSource1.UpdateCommand = "UPDATE [" & Session("YearName") & "] SET [UserDataMasterID] = @UserDataMasterID, [UserName] = @UserName, [ReceiptDate] = @ReceiptDate, [ReceiptTime] = @ReceiptTime, [ReceiptNumber] = @ReceiptNumber, [Title] = @Title, [DonorName] = @DonorName, [DonorAddress] = @DonorAddress, [DonorMobile] = @DonorMobile, [DonorEmail] = @DonorEmail, [DonationAmount] = @DonationAmount, [DocumentType] = @DocumentType, [DocumentNumber] = @DocumentNumber, [DonationType] = @DonationType, [ModeOfDonation] = @ModeOfDonation, [TransectionChaqueNumber] = @TransectionChaqueNumber, [PaymentDate] = @PaymentDate, [BankName] = @BankName, [BranchName] = @BranchName, [Details] = @Details, [BySupport] = @BySupport, [CashDepositBank] = @CashDepositBank, [DELETED] = @DELETED WHERE [UID] = @original_UID"

            ASPxGridView1.DataSourceID = "SqlDataSource1"
            ASPxGridView1.DataBind()

        End If

        'Not Working
        'Dim YearName As String = Nothing

        'Do While YearName = "2022_2023"

        '    If String.IsNullOrEmpty(YearName) = True Then

        '        YearName = Session("YearName")

        '    Else

        '        YearName = Microsoft.VisualBasic.Mid(YearName, 1, 2) & Val(Microsoft.VisualBasic.Mid(YearName, 3, 2) - 1).ToString & "_" & Microsoft.VisualBasic.Mid(YearName, 6, 2) & Val(Microsoft.VisualBasic.Mid(YearName, 8, 2) - 1).ToString

        '        'Add Dropdown Items.
        '        DDLYear.Items.Add(New ListItem(YearName, YearName))

        '    End If

        'Loop


    End Sub

    Private Sub ASPxGridView1_CustomButtonCallback(sender As Object, e As ASPxGridViewCustomButtonCallbackEventArgs) Handles ASPxGridView1.CustomButtonCallback

        Try

            If e.ButtonID = "DOWNLOAD" Then

                '1. Diclare Variables & Store All Data in Variables
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
                Dim RCashDepositBank As Date = Nothing
                Dim RDELETED As String = Nothing

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UID")) = False Then

                    RUID = ASPxGridView1.GetRowValues(e.VisibleIndex, "UID")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UserDataMasterID")) = False Then

                    RUserDataMasterID = ASPxGridView1.GetRowValues(e.VisibleIndex, "UserDataMasterID")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "Title")) = False Then

                    RTitle = ASPxGridView1.GetRowValues(e.VisibleIndex, "Title")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UserName")) = False Then

                    RUserName = ASPxGridView1.GetRowValues(e.VisibleIndex, "UserName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptDate")) = False Then

                    RReceiptDate = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptDate")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptTime")) = False Then

                    RReceiptTime = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptTime")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptNumber")) = False Then

                    RReceiptNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorName")) = False Then

                    RDonorName = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorAddress")) = False Then

                    RDonorAddress = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorAddress")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorMobile")) = False Then

                    RDonorMobile = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorMobile")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorEmail")) = False Then

                    RDonorEmail = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorEmail")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationAmount")) = False Then

                    RDonationAmount = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationAmount")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentType")) = False Then

                    RDocumentType = ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentType")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentNumber")) = False Then

                    RDocumentNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationType")) = False Then

                    RDonationType = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationType")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ModeOfDonation")) = False Then

                    RModeOfDonation = ASPxGridView1.GetRowValues(e.VisibleIndex, "ModeOfDonation")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "TransectionChaqueNumber")) = False Then

                    RTransectionChaqueNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "TransectionChaqueNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "PaymentDate")) = False Then

                    RPaymentDate = CDate(ASPxGridView1.GetRowValues(e.VisibleIndex, "PaymentDate")).ToShortDateString

                Else

                    'Do Nothing

                End If

                'ROtherDonationType = ASPxGridView1.GetRowValues(e.VisibleIndex, "OtherDonationType")

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BankName")) = False Then

                    RBankName = ASPxGridView1.GetRowValues(e.VisibleIndex, "BankName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BranchName")) = False Then

                    RBranchName = ASPxGridView1.GetRowValues(e.VisibleIndex, "BranchName")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "Details")) = False Then

                    RDetails = ASPxGridView1.GetRowValues(e.VisibleIndex, "Details")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BySupport")) = False Then

                    RBySupport = ASPxGridView1.GetRowValues(e.VisibleIndex, "BySupport")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "CashDepositBank")) = False Then

                    RCashDepositBank = ASPxGridView1.GetRowValues(e.VisibleIndex, "CashDepositBank")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DELETED")) = False Then

                    RDELETED = ASPxGridView1.GetRowValues(e.VisibleIndex, "DELETED")

                Else

                    'Do Nothing

                End If

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

                Else

                    If RTitle = "Please Select Title" Then

                        'Do Nothing

                    Else

                        Report.xrDonorName.Text = StrConv(RTitle, VbStrConv.ProperCase) & " " & StrConv(RDonorName, VbStrConv.ProperCase)

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

                End If

                Report.xrAmount1.Text = RDonationAmount & ".00"

                If String.IsNullOrEmpty(RDELETED) = True Then

                    'Do Nothing

                Else

                    Report.xrCanceled.Text = "Cancel"
                    Report.xrCanceled.Visible = True

                    Report.xrCanceled1.Text = "Cancel"
                    Report.xrCanceled1.Visible = True

                End If

                'For Abhar Darshan
                Report.xrReceiptDate1.Text = RReceiptDate


                If String.IsNullOrEmpty(RTitle) = True Then
                    Report.xrDonorName1.Text = StrConv(RDonorName, VbStrConv.ProperCase)
                Else
                    If RTitle = "Please Select Title" Then
                        'Do Nothing
                    Else
                        Report.xrDonorName1.Text = StrConv(RTitle, VbStrConv.ProperCase) & " " & StrConv(RDonorName, VbStrConv.ProperCase)
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

                ASPxWebControl.RedirectOnCallback(VirtualPathUtility.ToAbsolute("~/Receipt_PDF/" & TempPDFName & ".pdf"))

                'Response.Redirect("http://www.motavadalagauseva.org/Receipt_PDF/" & TempPDFName & ".pdf", False)

            End If

            If e.ButtonID = "Email" Then

                '1. Diclare Variables & Store All Data in Variables
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
                Dim RCashDepositBank As Date = Nothing
                Dim RDELETED As String = Nothing

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UID")) = False Then

                    RUID = ASPxGridView1.GetRowValues(e.VisibleIndex, "UID")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UserDataMasterID")) = False Then

                    RUserDataMasterID = ASPxGridView1.GetRowValues(e.VisibleIndex, "UserDataMasterID")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "Title")) = False Then

                    RTitle = ASPxGridView1.GetRowValues(e.VisibleIndex, "Title")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UserName")) = False Then

                    RUserName = ASPxGridView1.GetRowValues(e.VisibleIndex, "UserName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptDate")) = False Then

                    RReceiptDate = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptDate")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptTime")) = False Then

                    RReceiptTime = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptTime")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptNumber")) = False Then

                    RReceiptNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorName")) = False Then

                    RDonorName = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorAddress")) = False Then

                    RDonorAddress = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorAddress")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorMobile")) = False Then

                    RDonorMobile = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorMobile")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorEmail")) = False Then

                    RDonorEmail = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorEmail")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationAmount")) = False Then

                    RDonationAmount = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationAmount")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentType")) = False Then

                    RDocumentType = ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentType")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentNumber")) = False Then

                    RDocumentNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationType")) = False Then

                    RDonationType = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationType")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ModeOfDonation")) = False Then

                    RModeOfDonation = ASPxGridView1.GetRowValues(e.VisibleIndex, "ModeOfDonation")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "TransectionChaqueNumber")) = False Then

                    RTransectionChaqueNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "TransectionChaqueNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "PaymentDate")) = False Then

                    RPaymentDate = CDate(ASPxGridView1.GetRowValues(e.VisibleIndex, "PaymentDate")).ToShortDateString

                Else

                    'Do Nothing

                End If

                'ROtherDonationType = ASPxGridView1.GetRowValues(e.VisibleIndex, "OtherDonationType")

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BankName")) = False Then

                    RBankName = ASPxGridView1.GetRowValues(e.VisibleIndex, "BankName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BranchName")) = False Then

                    RBranchName = ASPxGridView1.GetRowValues(e.VisibleIndex, "BranchName")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "Details")) = False Then

                    RDetails = ASPxGridView1.GetRowValues(e.VisibleIndex, "Details")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BySupport")) = False Then

                    RBySupport = ASPxGridView1.GetRowValues(e.VisibleIndex, "BySupport")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "CashDepositBank")) = False Then

                    RCashDepositBank = ASPxGridView1.GetRowValues(e.VisibleIndex, "CashDepositBank")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DELETED")) = False Then

                    RDELETED = ASPxGridView1.GetRowValues(e.VisibleIndex, "DELETED")

                Else

                    'Do Nothing

                End If

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

                Else

                    If RTitle = "Please Select Title" Then

                        'Do Nothing

                    Else

                        Report.xrDonorName.Text = StrConv(RTitle, VbStrConv.ProperCase) & " " & StrConv(RDonorName, VbStrConv.ProperCase)

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

                End If

                Report.xrAmount1.Text = RDonationAmount & ".00"

                If String.IsNullOrEmpty(RDELETED) = True Then

                    'Do Nothing

                Else

                    Report.xrCanceled.Text = "Cancel"
                    Report.xrCanceled.Visible = True

                    Report.xrCanceled1.Text = "Cancel"
                    Report.xrCanceled1.Visible = True

                End If


                'For Abhar Darshan
                Report.xrReceiptDate1.Text = RReceiptDate


                If String.IsNullOrEmpty(RTitle) = True Then
                    Report.xrDonorName1.Text = StrConv(RDonorName, VbStrConv.ProperCase)
                Else
                    If RTitle = "Please Select Title" Then
                        'Do Nothing
                    Else
                        Report.xrDonorName1.Text = StrConv(RTitle, VbStrConv.ProperCase) & " " & StrConv(RDonorName, VbStrConv.ProperCase)
                    End If
                End If

                Report.xrAmount2.Text = RDonationAmount & ".00"
                Report.xrReceiptNumber1.Text = RReceiptNumber

                Dim TempPDFName As String = Nothing
                TempPDFName = Microsoft.VisualBasic.Replace(RReceiptNumber, "/", "_", 1, -1, CompareMethod.Text)

                Report.ExportToPdf(Server.MapPath("~") & "Receipt_PDF\" & TempPDFName & ".pdf")


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
                    MailMessage.Headers.Add("Reply-To", "info@motavadalagauseva.org")
                    MailMessage.To.Add(New System.Net.Mail.MailAddress(RDonorEmail))
                    MailMessage.Subject = "Mota Vadala Gau Seva Rahat Trust - Donation Receipt"
                    MailMessage.IsBodyHtml = True
                    MailMessage.Body = StrHTML

                    Dim ct As System.Net.Mime.ContentType = New System.Net.Mime.ContentType("Application/PDF")

                    'Add Quotation as Attachment.
                    Dim Att As New System.Net.Mail.Attachment(Server.MapPath("~") & "Receipt_PDF\" & TempPDFName & ".pdf", ct)
                    MailMessage.Attachments.Add(Att)

                    Dim SMTPClient As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient()

                    SMTPClient.Host = "mail.motavadalagauseva.org"
                    SMTPClient.Port = "25"
                    SMTPClient.EnableSsl = False

                    SMTPClient.Credentials = New System.Net.NetworkCredential("info@motavadalagauseva.org", "Mota@123$")

                    SMTPClient.Send(MailMessage)

                End If

            End If

            If e.ButtonID = "Whatsapp" Then

                Dim RUserDataMasterID As Integer = Nothing
                Dim RUserName As String = Nothing
                Dim RBUMobileNumber As String = Nothing

                Dim RReceiptNumber As String = Nothing

                Dim RTitle As String = Nothing
                Dim RDonorName As String = Nothing
                Dim RDonorMobile As String = Nothing

                Dim RDonationAmount As String = Nothing

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UserDataMasterID")) = False Then

                    RUserDataMasterID = ASPxGridView1.GetRowValues(e.VisibleIndex, "UserDataMasterID")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UserName")) = False Then

                    RUserName = ASPxGridView1.GetRowValues(e.VisibleIndex, "UserName")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptNumber")) = False Then

                    RReceiptNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "Title")) = False Then

                    RTitle = ASPxGridView1.GetRowValues(e.VisibleIndex, "Title")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorName")) = False Then

                    RDonorName = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorMobile")) = False Then

                    RDonorMobile = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorMobile")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationAmount")) = False Then

                    RDonationAmount = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationAmount")

                Else

                    'Do Nothing

                End If

                Using conn As SqlConnection = ReturnConnection()

                    Dim cmd As New SqlCommand("SELECT Mobile FROM UserData WHERE UID = '" & RUserDataMasterID & "' ", conn)

                    conn.Open()

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then

                        Do While reader.Read()

                            RBUMobileNumber = reader.Item(0).ToString

                        Loop

                    End If

                    reader.Close()

                    conn.Close()

                End Using


                Dim TempPDFName As String = Nothing
                TempPDFName = Microsoft.VisualBasic.Replace(RReceiptNumber, "/", "_", 1, -1, CompareMethod.Text)

                Dim TempMobileNumber As String = Nothing

                If String.IsNullOrEmpty(RDonorMobile) = True Then

                    TempMobileNumber = RBUMobileNumber

                Else

                    TempMobileNumber = RDonorMobile

                End If


                Session("Page2Redirect") = "Admin_Modify_Receipt"
                Session("TempMobile") = TempMobileNumber

                If String.IsNullOrEmpty(RTitle) = True Then
                    Session("DonorName") = RDonorName
                Else
                    Session("DonorName") = RTitle & " " & RDonorName
                End If

                Session("DonationAmount") = RDonationAmount
                Session("PDFfileName") = TempPDFName

                'ASPxWebControl.RedirectOnCallback("https://api.whatsapp.com/send?phone=91" & Session("TempMobile") & "&text=Name%20%3A%20" & RTitle & "%20" & Session("DonorName") & "%0AAmount%20%3A%20" & Session("DonationAmount") & "%0APlease%20Download%20Donation%20Receipt%20From%20Below%20Location.%0Awww.motavadalagauseva.org%2FReceipt_PDF%2F" & Session("PDFfileName") & ".pdf")
                ASPxWebControl.RedirectOnCallback(VirtualPathUtility.ToAbsolute("~/Admin/Admin_Whatsapp.aspx?91" & Session("TempMobile") & "," & Session("DonorName") & "," & Session("DonationAmount") & "," & Session("PDFfileName") & ".pdf"))


            End If

            If e.ButtonID = "CancelReceipt" Then

                '1. Diclare Variables & Store All Data in Variables
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
                Dim RCashDepositBank As Date = Nothing
                Dim RDELETED As String = Nothing

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UID")) = False Then

                    RUID = ASPxGridView1.GetRowValues(e.VisibleIndex, "UID")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UserDataMasterID")) = False Then

                    RUserDataMasterID = ASPxGridView1.GetRowValues(e.VisibleIndex, "UserDataMasterID")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "Title")) = False Then

                    RTitle = ASPxGridView1.GetRowValues(e.VisibleIndex, "Title")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "UserName")) = False Then

                    RUserName = ASPxGridView1.GetRowValues(e.VisibleIndex, "UserName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptDate")) = False Then

                    RReceiptDate = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptDate")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptTime")) = False Then

                    RReceiptTime = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptTime")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptNumber")) = False Then

                    RReceiptNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "ReceiptNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorName")) = False Then

                    RDonorName = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorAddress")) = False Then

                    RDonorAddress = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorAddress")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorMobile")) = False Then

                    RDonorMobile = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorMobile")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorEmail")) = False Then

                    RDonorEmail = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonorEmail")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationAmount")) = False Then

                    RDonationAmount = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationAmount")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentType")) = False Then

                    RDocumentType = ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentType")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentNumber")) = False Then

                    RDocumentNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "DocumentNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationType")) = False Then

                    RDonationType = ASPxGridView1.GetRowValues(e.VisibleIndex, "DonationType")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "ModeOfDonation")) = False Then

                    RModeOfDonation = ASPxGridView1.GetRowValues(e.VisibleIndex, "ModeOfDonation")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "TransectionChaqueNumber")) = False Then

                    RTransectionChaqueNumber = ASPxGridView1.GetRowValues(e.VisibleIndex, "TransectionChaqueNumber")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "PaymentDate")) = False Then

                    RPaymentDate = CDate(ASPxGridView1.GetRowValues(e.VisibleIndex, "PaymentDate")).ToShortDateString

                Else

                    'Do Nothing

                End If

                'ROtherDonationType = ASPxGridView1.GetRowValues(e.VisibleIndex, "OtherDonationType")

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BankName")) = False Then

                    RBankName = ASPxGridView1.GetRowValues(e.VisibleIndex, "BankName")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BranchName")) = False Then

                    RBranchName = ASPxGridView1.GetRowValues(e.VisibleIndex, "BranchName")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "Details")) = False Then

                    RDetails = ASPxGridView1.GetRowValues(e.VisibleIndex, "Details")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "BySupport")) = False Then

                    RBySupport = ASPxGridView1.GetRowValues(e.VisibleIndex, "BySupport")

                Else

                    'Do Nothing

                End If


                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "CashDepositBank")) = False Then

                    RCashDepositBank = ASPxGridView1.GetRowValues(e.VisibleIndex, "CashDepositBank")

                Else

                    'Do Nothing

                End If

                If ValidateStringControl(ASPxGridView1.GetRowValues(e.VisibleIndex, "DELETED")) = False Then

                    RDELETED = ASPxGridView1.GetRowValues(e.VisibleIndex, "DELETED")

                Else

                    'Do Nothing

                End If

                'Update Row Using SQL to Cancel Receipt
                Using conn As SqlConnection = ReturnConnection()

                    Dim cmd As New SqlCommand("UPDATE [" & Session("YearName") & "] SET [DELETED] = 'Canceled' , [DonationAmount] = '0'" & "WHERE UID = '" & RUID & "'", conn)

                    conn.Open()

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    reader.Close()

                    conn.Close()

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

                Else

                    If RTitle = "Please Select Title" Then

                        'Do Nothing

                    Else

                        Report.xrDonorName.Text = StrConv(RTitle, VbStrConv.ProperCase) & " " & StrConv(RDonorName, VbStrConv.ProperCase)

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

                End If

                Report.xrAmount1.Text = RDonationAmount & ".00"

                'For Receipt
                Report.xrCanceled.Text = "Cancel"
                Report.xrCanceled.Visible = True

                'For Abhar Patra
                Report.xrCanceled1.Text = "Cancel"
                Report.xrCanceled1.Visible = True

                'For Abhar Darshan
                Report.xrReceiptDate1.Text = RReceiptDate


                If String.IsNullOrEmpty(RTitle) = True Then
                    Report.xrDonorName1.Text = StrConv(RDonorName, VbStrConv.ProperCase)
                Else
                    If RTitle = "Please Select Title" Then
                        'Do Nothing
                    Else
                        Report.xrDonorName1.Text = StrConv(RTitle, VbStrConv.ProperCase) & " " & StrConv(RDonorName, VbStrConv.ProperCase)
                    End If
                End If

                Report.xrAmount2.Text = RDonationAmount & ".00"
                Report.xrReceiptNumber1.Text = RReceiptNumber

                Dim TempPDFName As String = Nothing
                TempPDFName = Microsoft.VisualBasic.Replace(RReceiptNumber, "/", "_", 1, -1, CompareMethod.Text)

                Report.ExportToPdf(Server.MapPath("~") & "Receipt_PDF\" & TempPDFName & ".pdf")

                ASPxWebControl.RedirectOnCallback(VirtualPathUtility.ToAbsolute("~/Admin/Admin_Modify_Receipt.aspx"))

            End If

        Catch ex As Exception

            ResultMessage = ex.Message

        End Try

    End Sub

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

    Public Function ValidateStringControl(ByVal CheckString) As Boolean

        On Error Resume Next

        ValidateStringControl = Nothing

        If IsDBNull(CheckString) = True Then

            ValidateStringControl = True

            Return ValidateStringControl

            Exit Function

        ElseIf TypeOf CheckString Is String Then

            If String.IsNullOrEmpty(CheckString) = True Then

                ValidateStringControl = True

                Return ValidateStringControl

                Exit Function

            ElseIf CheckString = "" Then
                ValidateStringControl = True

                Return ValidateStringControl

                Exit Function

            End If

        Else

            ValidateStringControl = False

            Return ValidateStringControl

        End If

    End Function

    Private Sub ASPxGridView1_CallbackError(sender As Object, e As EventArgs) Handles ASPxGridView1.CallbackError

        On Error Resume Next

        'Display Message

        lblMessage.Text = ResultMessage

    End Sub

    Private Sub ASPxGridView1_AfterPerformCallback(sender As Object, e As ASPxGridViewAfterPerformCallbackEventArgs) Handles ASPxGridView1.AfterPerformCallback

        On Error Resume Next

        'Display Message

        lblMessage.Text = ResultMessage

    End Sub


    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click

        On Error Resume Next

        If DDLYear.SelectedValue = "Please Select Financial Year" Then

            'Do Nothing
            lblMessage.Text = "Please Select Year"

        Else

            Session("YearName") = DDLYear.SelectedValue

            Dim meta As New HtmlMeta()

            meta.HttpEquiv = "Refresh"
            meta.Content = "0;url=Admin_Modify_Receipt.aspx"


            Me.Page.Controls.Add(meta)


        End If

    End Sub

    Public Shared Function DateNow() As DateTime

        On Error Resume Next

        Dim utcTime As DateTime = DateTime.UtcNow
        Dim myZone As TimeZoneInfo = TimeZoneInfo.CreateCustomTimeZone("INDIA", New TimeSpan(+5, +30, 0), "India", "India")
        Dim custDateTime As DateTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, myZone)
        Return custDateTime

    End Function

    Private Function ReturnConnection() As SqlConnection

        On Error Resume Next

        Dim conn As New SqlConnection()

        conn.ConnectionString = ConfigurationManager.ConnectionStrings("MotaVadala_MSSQL_ConnectionString").ConnectionString

        Return conn

    End Function

    Private Sub btnExport2PDF_Click(sender As Object, e As EventArgs) Handles btnExport2PDF.Click
        On Error Resume Next

        ASPxGridView1.ExportPdfToResponse("View Modify Receipt List.pdf")

    End Sub

    Private Sub btnExport2Excel_Click(sender As Object, e As EventArgs) Handles btnExport2Excel.Click

        On Error Resume Next

        'Working Perfect
        Dim ExcelExportOptions As DevExpress.XtraPrinting.XlsxExportOptionsEx = New XlsxExportOptionsEx() With {.ExportType = DevExpress.Export.ExportType.WYSIWYG}

        ExcelExportOptions.SheetName = "View Modify Receipt List"

        ASPxGridView1.ExportXlsxToResponse("View Modify Receipt List.xlsx", ExcelExportOptions)

    End Sub

    Private Sub ASPxGridView1_HeaderFilterFillItems(sender As Object, e As ASPxGridViewHeaderFilterEventArgs) Handles ASPxGridView1.HeaderFilterFillItems

        If e.Column.FieldName <> "CashDepositBank" Then
            Return
        End If

        e.Values.Insert(0, FilterValue.CreateShowBlanksValue(e.Column, "Blanks"))
        e.Values.Insert(1, FilterValue.CreateShowNonBlanksValue(e.Column, "Non Blanks"))

    End Sub
End Class
