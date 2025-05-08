Public Class XtraReportDonationRegister
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Public WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Public WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Public WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Public WithEvents printableComponentContainer1 As DevExpress.XtraReports.UI.PrintableComponentContainer
    Public WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Public WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents xrlblSubHeading As DevExpress.XtraReports.UI.XRLabel

    'Required by the Designer
    Public components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Dim resourceFileName As String = "XtraReportDonationRegister.resx"
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.printableComponentContainer1 = New DevExpress.XtraReports.UI.PrintableComponentContainer()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrlblSubHeading = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 75.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 75.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.printableComponentContainer1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 480.4833!
        Me.Detail.HierarchyPrintOptions.Indent = 50.8!
        Me.Detail.Name = "Detail"
        '
        'printableComponentContainer1
        '
        Me.printableComponentContainer1.Dpi = 254.0!
        Me.printableComponentContainer1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.printableComponentContainer1.Name = "printableComponentContainer1"
        Me.printableComponentContainer1.SizeF = New System.Drawing.SizeF(2769.6!, 429.6833!)
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlblSubHeading, Me.xrLabel1})
        Me.ReportHeader.Dpi = 254.0!
        Me.ReportHeader.HeightF = 138.0067!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'xrlblSubHeading
        '
        Me.xrlblSubHeading.CanGrow = False
        Me.xrlblSubHeading.Dpi = 254.0!
        Me.xrlblSubHeading.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlblSubHeading.LocationFloat = New DevExpress.Utils.PointFloat(0!, 75.35335!)
        Me.xrlblSubHeading.Name = "xrlblSubHeading"
        Me.xrlblSubHeading.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrlblSubHeading.SizeF = New System.Drawing.SizeF(1757.833!, 62.65335!)
        Me.xrlblSubHeading.StylePriority.UseFont = False
        Me.xrlblSubHeading.StylePriority.UseTextAlignment = False
        Me.xrlblSubHeading.Text = "DONATION INCOME REGISTER"
        Me.xrlblSubHeading.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrlblSubHeading.WordWrap = False
        '
        'xrLabel1
        '
        Me.xrLabel1.CanGrow = False
        Me.xrLabel1.Dpi = 254.0!
        Me.xrLabel1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(1757.833!, 75.35334!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "MOTA VADALA GAU SEVA RAHAT TRUST"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrLabel1.WordWrap = False
        '
        'XtraReportDonationRegister
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader})
        Me.Dpi = 254.0!
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(75, 75, 75, 75)
        Me.PageHeight = 2100
        Me.PageWidth = 2970
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.Version = "22.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class