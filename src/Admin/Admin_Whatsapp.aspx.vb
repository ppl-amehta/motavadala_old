
Partial Class Admin_Whatsapp
    Inherits System.Web.UI.Page

    Private Sub Admin_Whatsapp_Load(sender As Object, e As EventArgs) Handles Me.Load

        On Error Resume Next

        If Session("TempMobile") <> "" And Session("PDFfileName") <> "" Then

            'Start Whatsapp in Computer and Send Message.
            Dim meta As New HtmlMeta()

            meta.HttpEquiv = "Refresh"
            meta.Content = "5;url=https://api.whatsapp.com/send?phone=91" & Session("TempMobile") & "&text=Donor%20Name%20%3A%20" & Session("DonorName") & "%0ARs.%20%3A%20" & Session("DonationAmount") & "%0APlease%20Download%20Donation%20Receipt%20From%20Below%20Location%20and%20Enter%20your%20mobile%20number%20as%20the%20password.%0Awww.motavadalagauseva.org%2FReceipt_PDF%2F" & Session("PDFfileName") & ".pdf"

            'meta.Content = "15;url=whatsapp://send?phone=91" & Session("DMobile") & "&text=Please%20Download%20Donation%20Receipt%20From%20Below%20Location.%20%20%20%20%20%20%20%20%20%20www.motavadalagauseva.org/Receipt_PDF/" & Session("PDFfileName") & ".pdf"

            Me.Page.Controls.Add(meta)

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        On Error Resume Next

        If Session("Page2Redirect") = "Admin_Modify_Receipt" Then

            Response.Redirect("Admin_Modify_Receipt.aspx")
            Session("Page2Redirect") = ""

        Else

            Response.Redirect("Admin_Receipt.aspx")

        End If

    End Sub

    Private Sub Admin_Whatsapp_Unload(sender As Object, e As EventArgs) Handles Me.Unload

        On Error Resume Next

        Session("Page2Redirect") = ""
        Session("TempMobile") = ""
        Session("DonorName") = ""
        Session("DonationAmount") = ""
        Session("PDFfileName") = ""

    End Sub

End Class
