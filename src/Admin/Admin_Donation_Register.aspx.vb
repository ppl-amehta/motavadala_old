
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.Web
Imports DevExpress.Web.ASPxScheduler.Internal
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraPrinting

Partial Class Admin_Donation_Register
    Inherits System.Web.UI.Page


    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click


        If DDLYear.SelectedValue = "Please Select Financial Year" Then

            'Do Nothing
            lblMessage.Text = "Please Select Year"
            Exit Sub
        Else

            Session("YearName") = DDLYear.SelectedValue

        End If

        If String.IsNullOrEmpty(txtStartDate.Text) = True Then
            'Do Nothing
            lblMessage.Text = "Please Select Start Date"
            Exit Sub
        Else

            Session("StartDate") = txtStartDate.Text

        End If


        If String.IsNullOrEmpty(txtEndDate.Text) = True Then
            'Do Nothing
            lblMessage.Text = "Please Select End Date"
            Exit Sub
        Else

            Session("EndDate") = txtEndDate.Text

        End If



        Dim meta As New HtmlMeta()

        meta.HttpEquiv = "Refresh"
        meta.Content = "0;url=Admin_Donation_Register.aspx"


        Me.Page.Controls.Add(meta)

    End Sub

    Private Sub Admin_Donation_Register_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            'If User Then ID Or User Name Not Found, Redirect To Login Page, Display Please Please Login.
            If Session("UID") = "" Then

                Response.Redirect("Admin_Login.aspx")
                Exit Sub

            End If

            If Session("UserName") = "" Then

                Response.Redirect("Admin_Login.aspx")
                Exit Sub

            End If

            If Page.IsPostBack = False Then

                If Session("YearName") = "" Then

                    'Do Nothing

                Else

                    ASPxGridView1.DataBind()

                End If

            End If


        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

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

    Private Sub ASPxGridView1_DataBinding(sender As Object, e As EventArgs) Handles ASPxGridView1.DataBinding

        Try

            If Session("YearName") = "" Then

                'Do Nothing

            Else

                Dim TableDonationRegisterDT As New DataTable()

                TableDonationRegisterDT.TableName = "Donation Register"
                ' Define columns
                'TableDonationRegisterDT.Columns.Add("UID", GetType(System.Int16))
                TableDonationRegisterDT.Columns.Add("Sr.", GetType(System.Int16))
                TableDonationRegisterDT.Columns.Add("ReceiptDate", GetType(System.String))
                TableDonationRegisterDT.Columns.Add("Receipt Number", GetType(System.String))
                TableDonationRegisterDT.Columns.Add("Donor's Name", GetType(System.String))
                TableDonationRegisterDT.Columns.Add("Amount", GetType(System.Double))
                TableDonationRegisterDT.Columns.Add("Cash", GetType(System.Double))
                TableDonationRegisterDT.Columns.Add("Cheque/Other", GetType(System.Double))
                TableDonationRegisterDT.Columns.Add("Transection Mode", GetType(System.String))

                'TableDonationRegisterDT.Rows.Add(TempData(0), TempData(1), TempData(2), TempData(3))

                'Update Row Using SQL to Cancel Receipt
                Using conn As SqlConnection = ReturnConnection()

                    Dim cmd As New SqlCommand("SELECT * FROM [" & Session("YearName") & "] WHERE ReceiptDate >= '" & Session("StartDate") & "' And ReceiptDate <= '" & Session("EndDate") & "'", conn)

                    conn.Open()

                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    Dim I As Integer = 0

                    If reader.HasRows Then

                        Do While reader.Read

                            Dim TempReceiptDate As String = Nothing
                            Dim TempReceiptNumber As String = Nothing
                            Dim TempName As String = Nothing
                            Dim TempAmount As Double = Nothing
                            Dim TempCashAmount As Double = Nothing
                            Dim TempChaqueOther As Double = Nothing
                            Dim TempTransectionMode As String = Nothing
                            Dim TempCancel As String = Nothing

                            'TempUID = reader.Item(0)

                            If ValidateStringControl(reader.Item(3)) = False Then

                                TempReceiptDate = CDate(reader.Item(3)).ToShortDateString

                            Else

                                'Do Nothing

                            End If

                            If ValidateStringControl(reader.Item(5)) = False Then

                                TempReceiptNumber = reader.Item(5)

                            Else

                                'Do Nothing

                            End If

                            If ValidateStringControl(reader.Item(23)) = False Then

                                TempCancel = reader.Item(23)

                            Else

                                'Do Nothing

                            End If

                            If ValidateStringControl(reader.Item(7)) = False Then

                                If TempCancel = Nothing Then

                                    TempName = reader.Item(7)

                                Else

                                    TempName = reader.Item(7) & " (" & StrConv(TempCancel, VbStrConv.Uppercase) & ")"

                                End If

                            Else

                                'Do Nothing

                            End If

                            If ValidateStringControl(reader.Item(11)) = False Then

                                TempAmount = CDbl(reader.Item(11))

                            Else

                                'Do Nothing

                            End If


                            If ValidateStringControl(reader.Item(15)) = False Then

                                TempTransectionMode = reader.Item(15)

                            Else

                                'Do Nothing

                            End If

                            If TempTransectionMode = "CASH" Then

                                TempCashAmount = TempAmount

                            Else

                                TempChaqueOther = TempAmount

                            End If

                            I = I + 1

                            'TableDonationRegisterDT.Rows.Add(TempUID, I, TempReceiptDate, TempName, TempAmount, TempCashAmount, TempCashSubTotal, TempChaqueOther, TempTransectionMode)
                            TableDonationRegisterDT.Rows.Add(I, TempReceiptDate, TempReceiptNumber, TempName, TempAmount, TempCashAmount, TempChaqueOther, TempTransectionMode)

                        Loop

                    End If

                    reader.Close()

                    conn.Close()

                End Using


                ASPxGridView1.Columns.Clear()
                'ASPxGridView1.AutoGenerateColumns = True

                For Each dataColumn As DataColumn In TableDonationRegisterDT.Columns
                    Dim column As New GridViewDataTextColumn()
                    column.FieldName = dataColumn.ColumnName

                    column.HeaderStyle.Font.Bold = True
                    column.HeaderStyle.Font.Size = 12
                    column.HeaderStyle.Font.Name = "Play"

                    column.CellStyle.Font.Size = 12
                    column.CellStyle.Font.Name = "Play"

                    column.FooterCellStyle.Font.Bold = True
                    column.FooterCellStyle.Font.Size = 12
                    column.FooterCellStyle.Font.Name = "Play"

                    If column.FieldName = "Cash" Or column.FieldName = "Amount" Or column.FieldName = "Cheque/Other" Then

                        column.PropertiesEdit.DisplayFormatString = "F2"

                    End If

                    ' set additional column properties
                    column.Caption = dataColumn.ColumnName
                    ASPxGridView1.Columns.Add(column)


                Next dataColumn

                ASPxGridView1.KeyFieldName = "Sr."
                ASPxGridView1.DataSource = TableDonationRegisterDT

            End If

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        Try

            ' Create a report. 
            Dim Report As New XtraReportDonationRegister

            Dim SDate As String = Nothing

            If CDate(Session("StartDate")).Day.ToString.Length = 1 Then
                SDate = "0" & CDate(Session("StartDate")).Day.ToString
            Else
                SDate = CDate(Session("StartDate")).Day.ToString
            End If

            If CDate(Session("StartDate")).Month.ToString.Length = 1 Then
                SDate = SDate & "-" & "0" & CDate(Session("StartDate")).Month.ToString
            Else
                SDate = SDate & "-" & CDate(Session("StartDate")).Month.ToString
            End If

            SDate = SDate & "-" & CDate(Session("StartDate")).Year.ToString

            Dim EDate As String = Nothing

            If CDate(Session("EndDate")).Day.ToString.Length = 1 Then
                EDate = "0" & CDate(Session("EndDate")).Day.ToString
            Else
                EDate = CDate(Session("EndDate")).Day.ToString
            End If

            If CDate(Session("EndDate")).Month.ToString.Length = 1 Then
                EDate = EDate & "-" & "0" & CDate(Session("EndDate")).Month.ToString
            Else
                EDate = EDate & "-" & CDate(Session("EndDate")).Month.ToString
            End If

            EDate = EDate & "-" & CDate(Session("EndDate")).Year.ToString


            Report.xrlblSubHeading.Text = "DONATION INCOME REGISTER (" & SDate & " TO " & EDate & ")"

            Report.printableComponentContainer1.PrintableComponent = ASPxGridView1

            lblMessage.Text = Report.xrLabel1.WidthF.ToString & " = " & Report.printableComponentContainer1.PrintableComponent.width.ToString
            'Report.xrLabel1.WidthF = Convert.ToSingle(Report.printableComponentContainer1.PrintableComponent.width)
            'Report.xrlblSubHeading.WidthF = Convert.ToSingle(Report.printableComponentContainer1.PrintableComponent.width)

            'Export Report 

            ' Specify export options.
            Dim xlsxExportOptions As New XlsxExportOptions() With {.ExportMode = XlsxExportMode.SingleFile, .ShowGridLines = True, .FitToPrintedPageHeight = True}

            Dim format As String = "xlsx"
            Dim fileName As String = String.Format("Donation Register{0}", format)

            Using ms As New MemoryStream()
                Report.ExportToXlsx(ms, xlsxExportOptions)
                WriteDocumentToResponse(ms.ToArray(), "xlsx", True, "Donation Register.xlsx")
            End Using


            'Working Code
            'Using ms As New MemoryStream()

            '    'Select Case format
            '    '    Case "pdf"
            '    '        Report.ExportToPdf(ms)
            '    '    Case "xls"
            '    '        Report.ExportToXls(ms)
            '    'Case "xlsx"
            '    Report.ExportToXlsx(ms, xlsxExportOptions)
            '    '    Case "rtf"
            '    '        Report.ExportToRtf(ms)
            '    '    Case "mht"
            '    '        Report.ExportToMht(ms)
            '    '    Case "html"
            '    '        Report.ExportToHtml(ms)
            '    '    Case "txt"
            '    '        Report.ExportToText(ms)
            '    '    Case "csv"
            '    '        Report.ExportToCsv(ms)
            '    '    Case "png"
            '    '        Report.ExportToImage(ms, New ImageExportOptions() With {.Format = System.Drawing.Imaging.ImageFormat.Png})
            '    '    Case Else
            '    '        Return
            '    'End Select

            '    WriteDocumentToResponse(ms.ToArray(), format, False, fileName)

            'End Using

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try


    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click

        Try

            Dim Report As New XtraReportDonationRegister

            Dim SDate As String = Nothing

            If CDate(Session("StartDate")).Day.ToString.Length = 1 Then
                SDate = "0" & CDate(Session("StartDate")).Day.ToString
            Else
                SDate = CDate(Session("StartDate")).Day.ToString
            End If

            If CDate(Session("StartDate")).Month.ToString.Length = 1 Then
                SDate = SDate & "-" & "0" & CDate(Session("StartDate")).Month.ToString
            Else
                SDate = SDate & "-" & CDate(Session("StartDate")).Month.ToString
            End If

            SDate = SDate & "-" & CDate(Session("StartDate")).Year.ToString

            Dim EDate As String = Nothing

            If CDate(Session("EndDate")).Day.ToString.Length = 1 Then
                EDate = "0" & CDate(Session("EndDate")).Day.ToString
            Else
                EDate = CDate(Session("EndDate")).Day.ToString
            End If

            If CDate(Session("EndDate")).Month.ToString.Length = 1 Then
                EDate = EDate & "-" & "0" & CDate(Session("EndDate")).Month.ToString
            Else
                EDate = EDate & "-" & CDate(Session("EndDate")).Month.ToString
            End If

            EDate = EDate & "-" & CDate(Session("EndDate")).Year.ToString


            Report.xrlblSubHeading.Text = "DONATION INCOME REGISTER (" & SDate & " TO " & EDate & ")"

            Report.printableComponentContainer1.PrintableComponent = ASPxGridView1
            lblMessage.Text = Report.xrLabel1.WidthF.ToString & " = " & Report.printableComponentContainer1.PrintableComponent.width.ToString
            'Report.xrLabel1.WidthF = Convert.ToSingle(Report.printableComponentContainer1.PrintableComponent.width)
            'Report.xrlblSubHeading.WidthF = Convert.ToSingle(Report.printableComponentContainer1.PrintableComponent.width)

            'Export Report 

            Using ms As New MemoryStream()
                Report.ExportToPdf(ms)
                WriteDocumentToResponse(ms.ToArray(), "pdf", True, "Donation Register.pdf")
            End Using


            'Working Code
            'Using ms As New MemoryStream()

            '    'Select Case format
            '    '    Case "pdf"
            '    '        Report.ExportToPdf(ms)
            '    '    Case "xls"
            '    '        Report.ExportToXls(ms)
            '    'Case "xlsx"
            '    Report.ExportToXlsx(ms, xlsxExportOptions)
            '    '    Case "rtf"
            '    '        Report.ExportToRtf(ms)
            '    '    Case "mht"
            '    '        Report.ExportToMht(ms)
            '    '    Case "html"
            '    '        Report.ExportToHtml(ms)
            '    '    Case "txt"
            '    '        Report.ExportToText(ms)
            '    '    Case "csv"
            '    '        Report.ExportToCsv(ms)
            '    '    Case "png"
            '    '        Report.ExportToImage(ms, New ImageExportOptions() With {.Format = System.Drawing.Imaging.ImageFormat.Png})
            '    '    Case Else
            '    '        Return
            '    'End Select

            '    WriteDocumentToResponse(ms.ToArray(), format, False, fileName)

            'End Using

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub

    Private Sub WriteDocumentToResponse(ByVal documentData() As Byte, ByVal format As String, ByVal isInline As Boolean, ByVal fileName As String)

        Try


            'INSTANT VB NOTE: The variable contentType was renamed since Visual Basic does not handle local variables named the same as class members well:
            Dim contentType_Renamed As String
            Dim disposition As String = If(isInline, "inline", "attachment")

            Select Case format.ToLower()
                Case "xls"
                    contentType_Renamed = "application/vnd.ms-excel"
                Case "xlsx"
                    contentType_Renamed = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                Case "mht"
                    contentType_Renamed = "message/rfc822"
                Case "html"
                    contentType_Renamed = "text/html"
                Case "txt", "csv"
                    contentType_Renamed = "text/plain"
                Case "png"
                    contentType_Renamed = "image/png"
                Case "pdf"
                    contentType_Renamed = "application/pdf"
                Case Else
                    contentType_Renamed = String.Format("application/{0}", format)
            End Select

            Response.Clear()
            Response.ContentType = contentType_Renamed
            Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}", disposition, fileName))
            Response.BinaryWrite(documentData)
            Response.End()

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        On Error Resume Next

        Response.Redirect("Admin_Reports.aspx")

    End Sub

End Class
