
Imports DevExpress.Web
Imports DevExpress.Export
Imports DevExpress.XtraPrinting
Imports System.IO
Imports DevExpress.XtraPrintingLinks
Imports System.Net.Mime

Partial Class Admin_User_List
    Inherits System.Web.UI.Page

    Private Sub btnExport2Excel_Click(sender As Object, e As EventArgs) Handles btnExport2Excel.Click

        On Error Resume Next

        'Working Perfect
        Dim ExcelExportOptions As DevExpress.XtraPrinting.XlsxExportOptionsEx = New XlsxExportOptionsEx() With {.ExportType = DevExpress.Export.ExportType.WYSIWYG}

        ExcelExportOptions.SheetName = "RBU List"

        ASPxGridView1.ExportXlsxToResponse("RBU List.xlsx", ExcelExportOptions)



        'Code For Testing Parpus only - Working perfect
        'Dim Report As New XtraReportDonationRegister

        'Report.printableComponentContainer1.PrintableComponent = ASPxGridView1

        'Report.ExportToXlsx("d:\userlist.xlsx")


    End Sub

    Private Sub btnExport2PDF_Click(sender As Object, e As EventArgs) Handles btnExport2PDF.Click
        On Error Resume Next

        ASPxGridView1.ExportPdfToResponse("RBU List.pdf")

        'Working, But Display PDF Online, You have to download manually.
        'Using ms As New MemoryStream()
        '    Dim pcl As New PrintableComponentLinkBase(New PrintingSystemBase())
        '    pcl.Component = ASPxGridViewExporter1
        '    pcl.Margins.Left = pcl.Margins.Right = 50
        '    pcl.Landscape = True
        '    pcl.CreateDocument(False)
        '    pcl.PrintingSystemBase.Document.AutoFitToPagesWidth = 1
        '    pcl.ExportToPdf(ms)
        '    WriteResponse(Me.Response, ms.ToArray(), System.Net.Mime.DispositionTypeNames.Inline.ToString())
        'End Using



    End Sub

    Private Sub btnBak_Click(sender As Object, e As EventArgs) Handles btnBak.Click

        On Error Resume Next

        Response.Redirect("Admin_Menu.aspx")

    End Sub

    Private Sub Admin_User_List_Load(sender As Object, e As EventArgs) Handles Me.Load

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

    'Public Shared Sub WriteResponse(response As HttpResponse, filearray As Byte(), type As String)

    '    response.ClearContent()
    '    response.Buffer = True
    '    response.Cache.SetCacheability(HttpCacheability.[Private])
    '    response.ContentType = "application/pdf"
    '    Dim contentDisposition As New ContentDisposition()
    '    contentDisposition.FileName = "User List.pdf"
    '    contentDisposition.DispositionType = type
    '    response.AddHeader("Content-Disposition", contentDisposition.ToString())
    '    response.BinaryWrite(filearray)
    '    HttpContext.Current.ApplicationInstance.CompleteRequest()
    '    Try
    '        response.[End]()
    '    Catch generatedExceptionName As System.Threading.ThreadAbortException
    '    End Try

    'End Sub

End Class
