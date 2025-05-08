Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraRichEdit
Public Class XtraReportReceipt
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Public WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Public WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Public WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Public WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Public WithEvents xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
    Public WithEvents xrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Public WithEvents xrMobile As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrReceiptNumber As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrReceiptDate As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrEmail As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrDonorName As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrDocumentNumber As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrModeOfDonation As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrRupeesInWord As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrPaymentDate As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrAmount As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrBranchName As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrDetail As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrBySupport As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrAmount1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrBankName As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrDonorName1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrAmount2 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrReceiptDate1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrReceiptNumber1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrTransectionNumber As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlblDocumentType As XRLabel
    Public WithEvents xrAddress As XRLabel
    Public WithEvents xrDonationType As XRLabel
    Public WithEvents xrRBUName As XRLabel
    Public WithEvents xrCanceled As XRLabel
    Public WithEvents xrReceiptTime As XRLabel
    Public WithEvents xrCanceled1 As XRLabel

    'Required by the Designer
    Public components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Dim resourceFileName As String = "XtraReportReceipt.resx"
        Dim resources As System.Resources.ResourceManager = Global.Resources.XtraReportReceipt.ResourceManager
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrCanceled1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrCanceled = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrReceiptTime = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrRBUName = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDonationType = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblDocumentType = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTransectionNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrReceiptNumber1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrReceiptDate1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrAmount2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDonorName1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrBankName = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrAmount1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrBySupport = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDetail = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrBranchName = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrAmount = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPaymentDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrRupeesInWord = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrModeOfDonation = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDocumentNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrDonorName = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrEmail = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrReceiptDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrReceiptNumber = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrMobile = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 90.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 90.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrCanceled1, Me.xrCanceled, Me.xrReceiptTime, Me.xrRBUName, Me.xrDonationType, Me.xrAddress, Me.xrlblDocumentType, Me.xrTransectionNumber, Me.xrReceiptNumber1, Me.xrReceiptDate1, Me.xrAmount2, Me.xrDonorName1, Me.xrBankName, Me.xrAmount1, Me.xrBySupport, Me.xrDetail, Me.xrBranchName, Me.xrAmount, Me.xrPaymentDate, Me.xrRupeesInWord, Me.xrModeOfDonation, Me.xrDocumentNumber, Me.xrDonorName, Me.xrEmail, Me.xrReceiptDate, Me.xrReceiptNumber, Me.xrMobile, Me.xrPictureBox2, Me.xrPageBreak1, Me.xrPictureBox1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 5565.08!
        Me.Detail.HierarchyPrintOptions.Indent = 50.8!
        Me.Detail.Name = "Detail"
        '
        'xrCanceled1
        '
        Me.xrCanceled1.Angle = 45.0!
        Me.xrCanceled1.CanGrow = False
        Me.xrCanceled1.Dpi = 254.0!
        Me.xrCanceled1.Font = New DevExpress.Drawing.DXFont("Calibri", 56.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.xrCanceled1.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrCanceled1.LocationFloat = New DevExpress.Utils.PointFloat(118.0165!, 3584.533!)
        Me.xrCanceled1.Multiline = True
        Me.xrCanceled1.Name = "xrCanceled1"
        Me.xrCanceled1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrCanceled1.SizeF = New System.Drawing.SizeF(1662.289!, 922.02!)
        Me.xrCanceled1.StylePriority.UseFont = False
        Me.xrCanceled1.StylePriority.UseForeColor = False
        Me.xrCanceled1.StylePriority.UseTextAlignment = False
        Me.xrCanceled1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrCanceled
        '
        Me.xrCanceled.Angle = 45.0!
        Me.xrCanceled.CanGrow = False
        Me.xrCanceled.Dpi = 254.0!
        Me.xrCanceled.Font = New DevExpress.Drawing.DXFont("Calibri", 56.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.xrCanceled.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrCanceled.LocationFloat = New DevExpress.Utils.PointFloat(193.5109!, 547.5234!)
        Me.xrCanceled.Multiline = True
        Me.xrCanceled.Name = "xrCanceled"
        Me.xrCanceled.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrCanceled.SizeF = New System.Drawing.SizeF(1662.289!, 922.02!)
        Me.xrCanceled.StylePriority.UseFont = False
        Me.xrCanceled.StylePriority.UseForeColor = False
        Me.xrCanceled.StylePriority.UseTextAlignment = False
        Me.xrCanceled.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrReceiptTime
        '
        Me.xrReceiptTime.CanGrow = False
        Me.xrReceiptTime.Dpi = 254.0!
        Me.xrReceiptTime.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrReceiptTime.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrReceiptTime.LocationFloat = New DevExpress.Utils.PointFloat(1640.722!, 440.5732!)
        Me.xrReceiptTime.Multiline = True
        Me.xrReceiptTime.Name = "xrReceiptTime"
        Me.xrReceiptTime.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrReceiptTime.SizeF = New System.Drawing.SizeF(198.261!, 49.95331!)
        Me.xrReceiptTime.StylePriority.UseFont = False
        Me.xrReceiptTime.StylePriority.UseForeColor = False
        Me.xrReceiptTime.StylePriority.UseTextAlignment = False
        Me.xrReceiptTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrReceiptTime.TextFormatString = "{0:hh:mm:ss tt}"
        '
        'xrRBUName
        '
        Me.xrRBUName.CanGrow = False
        Me.xrRBUName.Dpi = 254.0!
        Me.xrRBUName.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.xrRBUName.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrRBUName.LocationFloat = New DevExpress.Utils.PointFloat(279.5833!, 393.0066!)
        Me.xrRBUName.Multiline = True
        Me.xrRBUName.Name = "xrRBUName"
        Me.xrRBUName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrRBUName.SizeF = New System.Drawing.SizeF(628.65!, 58.41998!)
        Me.xrRBUName.StylePriority.UseFont = False
        Me.xrRBUName.StylePriority.UseForeColor = False
        Me.xrRBUName.StylePriority.UseTextAlignment = False
        Me.xrRBUName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrDonationType
        '
        Me.xrDonationType.CanGrow = False
        Me.xrDonationType.Dpi = 254.0!
        Me.xrDonationType.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrDonationType.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrDonationType.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 1294.042!)
        Me.xrDonationType.Multiline = True
        Me.xrDonationType.Name = "xrDonationType"
        Me.xrDonationType.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrDonationType.SizeF = New System.Drawing.SizeF(1385.711!, 49.95325!)
        Me.xrDonationType.StylePriority.UseFont = False
        Me.xrDonationType.StylePriority.UseForeColor = False
        '
        'xrAddress
        '
        Me.xrAddress.CanGrow = False
        Me.xrAddress.Dpi = 254.0!
        Me.xrAddress.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrAddress.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrAddress.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 802.8453!)
        Me.xrAddress.Multiline = True
        Me.xrAddress.Name = "xrAddress"
        Me.xrAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrAddress.SizeF = New System.Drawing.SizeF(1385.711!, 118.175!)
        Me.xrAddress.StylePriority.UseFont = False
        Me.xrAddress.StylePriority.UseForeColor = False
        '
        'xrlblDocumentType
        '
        Me.xrlblDocumentType.CanGrow = False
        Me.xrlblDocumentType.Dpi = 254.0!
        Me.xrlblDocumentType.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrlblDocumentType.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrlblDocumentType.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 735.6006!)
        Me.xrlblDocumentType.Multiline = True
        Me.xrlblDocumentType.Name = "xrlblDocumentType"
        Me.xrlblDocumentType.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrlblDocumentType.SizeF = New System.Drawing.SizeF(577.1443!, 49.95331!)
        Me.xrlblDocumentType.StylePriority.UseFont = False
        Me.xrlblDocumentType.StylePriority.UseForeColor = False
        '
        'xrTransectionNumber
        '
        Me.xrTransectionNumber.CanGrow = False
        Me.xrTransectionNumber.Dpi = 254.0!
        Me.xrTransectionNumber.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrTransectionNumber.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrTransectionNumber.LocationFloat = New DevExpress.Utils.PointFloat(889.1889!, 1083.256!)
        Me.xrTransectionNumber.Multiline = True
        Me.xrTransectionNumber.Name = "xrTransectionNumber"
        Me.xrTransectionNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrTransectionNumber.SizeF = New System.Drawing.SizeF(553.861!, 49.95337!)
        Me.xrTransectionNumber.StylePriority.UseFont = False
        Me.xrTransectionNumber.StylePriority.UseForeColor = False
        '
        'xrReceiptNumber1
        '
        Me.xrReceiptNumber1.CanGrow = False
        Me.xrReceiptNumber1.Dpi = 254.0!
        Me.xrReceiptNumber1.Font = New DevExpress.Drawing.DXFont("Calibri", 13.8!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.xrReceiptNumber1.ForeColor = System.Drawing.Color.Red
        Me.xrReceiptNumber1.LocationFloat = New DevExpress.Utils.PointFloat(480.8912!, 4736.67!)
        Me.xrReceiptNumber1.Name = "xrReceiptNumber1"
        Me.xrReceiptNumber1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrReceiptNumber1.SizeF = New System.Drawing.SizeF(327.4761!, 67.17041!)
        Me.xrReceiptNumber1.StylePriority.UseFont = False
        Me.xrReceiptNumber1.StylePriority.UseForeColor = False
        Me.xrReceiptNumber1.StylePriority.UseTextAlignment = False
        Me.xrReceiptNumber1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrReceiptDate1
        '
        Me.xrReceiptDate1.CanGrow = False
        Me.xrReceiptDate1.Dpi = 254.0!
        Me.xrReceiptDate1.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.xrReceiptDate1.ForeColor = System.Drawing.Color.Red
        Me.xrReceiptDate1.LocationFloat = New DevExpress.Utils.PointFloat(1500.363!, 3338.606!)
        Me.xrReceiptDate1.Name = "xrReceiptDate1"
        Me.xrReceiptDate1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrReceiptDate1.SizeF = New System.Drawing.SizeF(316.1874!, 42.15527!)
        Me.xrReceiptDate1.StylePriority.UseFont = False
        Me.xrReceiptDate1.StylePriority.UseForeColor = False
        Me.xrReceiptDate1.StylePriority.UseTextAlignment = False
        Me.xrReceiptDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrReceiptDate1.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'xrAmount2
        '
        Me.xrAmount2.CanGrow = False
        Me.xrAmount2.Dpi = 254.0!
        Me.xrAmount2.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.xrAmount2.ForeColor = System.Drawing.Color.Red
        Me.xrAmount2.LocationFloat = New DevExpress.Utils.PointFloat(1202.561!, 3649.514!)
        Me.xrAmount2.Name = "xrAmount2"
        Me.xrAmount2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrAmount2.SizeF = New System.Drawing.SizeF(257.6261!, 42.15527!)
        Me.xrAmount2.StylePriority.UseFont = False
        Me.xrAmount2.StylePriority.UseForeColor = False
        Me.xrAmount2.StylePriority.UseTextAlignment = False
        Me.xrAmount2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrDonorName1
        '
        Me.xrDonorName1.CanGrow = False
        Me.xrDonorName1.Dpi = 254.0!
        Me.xrDonorName1.Font = New DevExpress.Drawing.DXFont("Calibri", 13.8!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.xrDonorName1.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrDonorName1.LocationFloat = New DevExpress.Utils.PointFloat(397.6545!, 3425.851!)
        Me.xrDonorName1.Multiline = True
        Me.xrDonorName1.Name = "xrDonorName1"
        Me.xrDonorName1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrDonorName1.SizeF = New System.Drawing.SizeF(1402.644!, 66.39917!)
        Me.xrDonorName1.StylePriority.UseFont = False
        Me.xrDonorName1.StylePriority.UseForeColor = False
        '
        'xrBankName
        '
        Me.xrBankName.CanGrow = False
        Me.xrBankName.Dpi = 254.0!
        Me.xrBankName.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrBankName.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrBankName.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 1154.855!)
        Me.xrBankName.Multiline = True
        Me.xrBankName.Name = "xrBankName"
        Me.xrBankName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrBankName.SizeF = New System.Drawing.SizeF(1385.711!, 49.95337!)
        Me.xrBankName.StylePriority.UseFont = False
        Me.xrBankName.StylePriority.UseForeColor = False
        '
        'xrAmount1
        '
        Me.xrAmount1.CanGrow = False
        Me.xrAmount1.Dpi = 254.0!
        Me.xrAmount1.Font = New DevExpress.Drawing.DXFont("Calibri", 13.8!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.xrAmount1.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrAmount1.LocationFloat = New DevExpress.Utils.PointFloat(164.6442!, 1542.134!)
        Me.xrAmount1.Multiline = True
        Me.xrAmount1.Name = "xrAmount1"
        Me.xrAmount1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrAmount1.SizeF = New System.Drawing.SizeF(434.6221!, 58.4198!)
        Me.xrAmount1.StylePriority.UseFont = False
        Me.xrAmount1.StylePriority.UseForeColor = False
        Me.xrAmount1.TextFormatString = "{0:#.00}"
        '
        'xrBySupport
        '
        Me.xrBySupport.CanGrow = False
        Me.xrBySupport.Dpi = 254.0!
        Me.xrBySupport.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrBySupport.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrBySupport.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 1432.655!)
        Me.xrBySupport.Multiline = True
        Me.xrBySupport.Name = "xrBySupport"
        Me.xrBySupport.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrBySupport.SizeF = New System.Drawing.SizeF(1385.711!, 49.95337!)
        Me.xrBySupport.StylePriority.UseFont = False
        Me.xrBySupport.StylePriority.UseForeColor = False
        '
        'xrDetail
        '
        Me.xrDetail.CanGrow = False
        Me.xrDetail.Dpi = 254.0!
        Me.xrDetail.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrDetail.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrDetail.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 1364.055!)
        Me.xrDetail.Multiline = True
        Me.xrDetail.Name = "xrDetail"
        Me.xrDetail.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrDetail.SizeF = New System.Drawing.SizeF(1385.711!, 49.95325!)
        Me.xrDetail.StylePriority.UseFont = False
        Me.xrDetail.StylePriority.UseForeColor = False
        '
        'xrBranchName
        '
        Me.xrBranchName.CanGrow = False
        Me.xrBranchName.Dpi = 254.0!
        Me.xrBranchName.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrBranchName.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrBranchName.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 1223.455!)
        Me.xrBranchName.Multiline = True
        Me.xrBranchName.Name = "xrBranchName"
        Me.xrBranchName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrBranchName.SizeF = New System.Drawing.SizeF(1385.711!, 49.95325!)
        Me.xrBranchName.StylePriority.UseFont = False
        Me.xrBranchName.StylePriority.UseForeColor = False
        '
        'xrAmount
        '
        Me.xrAmount.CanGrow = False
        Me.xrAmount.Dpi = 254.0!
        Me.xrAmount.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrAmount.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrAmount.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 945.056!)
        Me.xrAmount.Multiline = True
        Me.xrAmount.Name = "xrAmount"
        Me.xrAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrAmount.SizeF = New System.Drawing.SizeF(1385.711!, 49.95325!)
        Me.xrAmount.StylePriority.UseFont = False
        Me.xrAmount.StylePriority.UseForeColor = False
        Me.xrAmount.TextFormatString = "{0:#.00}"
        '
        'xrPaymentDate
        '
        Me.xrPaymentDate.CanGrow = False
        Me.xrPaymentDate.Dpi = 254.0!
        Me.xrPaymentDate.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.xrPaymentDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrPaymentDate.LocationFloat = New DevExpress.Utils.PointFloat(1512.9!, 1083.256!)
        Me.xrPaymentDate.Multiline = True
        Me.xrPaymentDate.Name = "xrPaymentDate"
        Me.xrPaymentDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrPaymentDate.SizeF = New System.Drawing.SizeF(316.0889!, 49.95325!)
        Me.xrPaymentDate.StylePriority.UseFont = False
        Me.xrPaymentDate.StylePriority.UseForeColor = False
        Me.xrPaymentDate.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'xrRupeesInWord
        '
        Me.xrRupeesInWord.CanGrow = False
        Me.xrRupeesInWord.Dpi = 254.0!
        Me.xrRupeesInWord.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrRupeesInWord.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrRupeesInWord.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 1013.656!)
        Me.xrRupeesInWord.Multiline = True
        Me.xrRupeesInWord.Name = "xrRupeesInWord"
        Me.xrRupeesInWord.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrRupeesInWord.SizeF = New System.Drawing.SizeF(1385.711!, 49.95325!)
        Me.xrRupeesInWord.StylePriority.UseFont = False
        Me.xrRupeesInWord.StylePriority.UseForeColor = False
        '
        'xrModeOfDonation
        '
        Me.xrModeOfDonation.CanGrow = False
        Me.xrModeOfDonation.Dpi = 254.0!
        Me.xrModeOfDonation.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrModeOfDonation.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrModeOfDonation.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 1083.256!)
        Me.xrModeOfDonation.Multiline = True
        Me.xrModeOfDonation.Name = "xrModeOfDonation"
        Me.xrModeOfDonation.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrModeOfDonation.SizeF = New System.Drawing.SizeF(333.7276!, 49.95337!)
        Me.xrModeOfDonation.StylePriority.UseFont = False
        Me.xrModeOfDonation.StylePriority.UseForeColor = False
        '
        'xrDocumentNumber
        '
        Me.xrDocumentNumber.CanGrow = False
        Me.xrDocumentNumber.Dpi = 254.0!
        Me.xrDocumentNumber.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrDocumentNumber.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrDocumentNumber.LocationFloat = New DevExpress.Utils.PointFloat(1124.139!, 735.6006!)
        Me.xrDocumentNumber.Multiline = True
        Me.xrDocumentNumber.Name = "xrDocumentNumber"
        Me.xrDocumentNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrDocumentNumber.SizeF = New System.Drawing.SizeF(706.2607!, 49.95331!)
        Me.xrDocumentNumber.StylePriority.UseFont = False
        Me.xrDocumentNumber.StylePriority.UseForeColor = False
        '
        'xrDonorName
        '
        Me.xrDonorName.CanGrow = False
        Me.xrDonorName.Dpi = 254.0!
        Me.xrDonorName.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrDonorName.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrDonorName.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 661.2542!)
        Me.xrDonorName.Multiline = True
        Me.xrDonorName.Name = "xrDonorName"
        Me.xrDonorName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrDonorName.SizeF = New System.Drawing.SizeF(1385.711!, 55.69989!)
        Me.xrDonorName.StylePriority.UseFont = False
        Me.xrDonorName.StylePriority.UseForeColor = False
        '
        'xrEmail
        '
        Me.xrEmail.CanGrow = False
        Me.xrEmail.Dpi = 254.0!
        Me.xrEmail.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrEmail.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrEmail.LocationFloat = New DevExpress.Utils.PointFloat(942.8109!, 522.1233!)
        Me.xrEmail.Multiline = True
        Me.xrEmail.Name = "xrEmail"
        Me.xrEmail.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrEmail.SizeF = New System.Drawing.SizeF(887.5885!, 49.95331!)
        Me.xrEmail.StylePriority.UseFont = False
        Me.xrEmail.StylePriority.UseForeColor = False
        Me.xrEmail.StylePriority.UseTextAlignment = False
        Me.xrEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrReceiptDate
        '
        Me.xrReceiptDate.CanGrow = False
        Me.xrReceiptDate.Dpi = 254.0!
        Me.xrReceiptDate.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrReceiptDate.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrReceiptDate.LocationFloat = New DevExpress.Utils.PointFloat(1365.555!, 442.6899!)
        Me.xrReceiptDate.Multiline = True
        Me.xrReceiptDate.Name = "xrReceiptDate"
        Me.xrReceiptDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrReceiptDate.SizeF = New System.Drawing.SizeF(263.8777!, 49.95331!)
        Me.xrReceiptDate.StylePriority.UseFont = False
        Me.xrReceiptDate.StylePriority.UseForeColor = False
        Me.xrReceiptDate.StylePriority.UseTextAlignment = False
        Me.xrReceiptDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.xrReceiptDate.TextFormatString = "{0:dd/MM/yyyy}"
        '
        'xrReceiptNumber
        '
        Me.xrReceiptNumber.CanGrow = False
        Me.xrReceiptNumber.Dpi = 254.0!
        Me.xrReceiptNumber.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.xrReceiptNumber.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrReceiptNumber.LocationFloat = New DevExpress.Utils.PointFloat(279.5833!, 458.6232!)
        Me.xrReceiptNumber.Multiline = True
        Me.xrReceiptNumber.Name = "xrReceiptNumber"
        Me.xrReceiptNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrReceiptNumber.SizeF = New System.Drawing.SizeF(376.7667!, 58.41998!)
        Me.xrReceiptNumber.StylePriority.UseFont = False
        Me.xrReceiptNumber.StylePriority.UseForeColor = False
        Me.xrReceiptNumber.StylePriority.UseTextAlignment = False
        Me.xrReceiptNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrMobile
        '
        Me.xrMobile.CanGrow = False
        Me.xrMobile.Dpi = 254.0!
        Me.xrMobile.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!)
        Me.xrMobile.ForeColor = System.Drawing.Color.DarkBlue
        Me.xrMobile.LocationFloat = New DevExpress.Utils.PointFloat(444.6888!, 523.1233!)
        Me.xrMobile.Multiline = True
        Me.xrMobile.Name = "xrMobile"
        Me.xrMobile.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrMobile.SizeF = New System.Drawing.SizeF(359.8334!, 49.95331!)
        Me.xrMobile.StylePriority.UseFont = False
        Me.xrMobile.StylePriority.UseForeColor = False
        Me.xrMobile.StylePriority.UseTextAlignment = False
        Me.xrMobile.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrPictureBox2
        '
        Me.xrPictureBox2.Dpi = 254.0!
        Me.xrPictureBox2.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.xrPictureBox2.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox2.ImageSource"))
        Me.xrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(0.00004306369!, 2785.08!)
        Me.xrPictureBox2.Name = "xrPictureBox2"
        Me.xrPictureBox2.SizeF = New System.Drawing.SizeF(1900.0!, 2780.0!)
        Me.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'xrPageBreak1
        '
        Me.xrPageBreak1.Dpi = 254.0!
        Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2780.0!)
        Me.xrPageBreak1.Name = "xrPageBreak1"
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.Dpi = 254.0!
        Me.xrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"))
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(1900.0!, 2780.0!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XtraReportReceipt
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Dpi = 254.0!
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(100.0!, 100.0!, 90.0!, 90.0!)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.SnappingMode = DevExpress.XtraReports.UI.SnappingMode.None
        Me.Version = "24.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class