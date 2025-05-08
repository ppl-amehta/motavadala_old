Partial Class Whatsapp

    Inherits System.Web.UI.Page

    Private Sub Whatsapp_Load(sender As Object, e As EventArgs) Handles Me.Load

        On Error Resume Next

        If Session("TempMobile") <> "" And Session("PDFfileName") <> "" Then

            'Start Whatsapp in Computer and Send Message.
            Dim meta As New HtmlMeta()

            meta.HttpEquiv = "Refresh"
            meta.Content = "5;url=https://api.whatsapp.com/send?phone=91" & Session("TempMobile") & "&text=Donor%20Name%20%3A%20" & Session("DonorName") & "%0ARs.%20%3A%20" & Session("DonationAmount") & "%0APlease%20Download%20Donation%20Receipt%20From%20Below%20Location%20and%20Enter%20your%20mobile%20number%20as%20the%20password.%0Awww.motavadalagauseva.org%2FReceipt_PDF%2F" & Session("PDFfileName") & ".pdf"

            Me.Page.Controls.Add(meta)

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        On Error Resume Next

        Response.Redirect("Receipt.aspx", False)

    End Sub

    Private Sub Whatsapp_Unload(sender As Object, e As EventArgs) Handles Me.Unload

        On Error Resume Next

        Session("Page2Redirect") = ""
        Session("TempMobile") = ""
        Session("DonorName") = ""
        Session("DonationAmount") = ""
        Session("PDFfileName") = ""

    End Sub

End Class
