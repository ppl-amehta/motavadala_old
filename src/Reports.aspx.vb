
Partial Class Reports

    Inherits System.Web.UI.Page

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

        Try

            ' Create a report. 
            'Dim Report As New XtraReportReceipt

            ''Report.xrLabel1.Text = "My Address :"

            'Report.ExportToPdf("d:\Test.pdf")

            'lblMessage.Text = "PDF Generated Successfully."

            'lblMessage.Text = Server.MapPath("~") & "Receipt_PDF\123.pdf"

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try

            hlTest.NavigateUrl = "whatsapp://send?phone=919427253489&text=Please%20Download%20Donation%20Receipt%20From%20Below%20Location.%20%20%20%20%20%20%20%20%20%20www.motavadalagauseva.org\Receipt_PDF\123.pdf"

            Page.ClientScript.RegisterStartupScript(Me.[GetType](), "clickLink", "ClickLink();", True)

            lblMessage.Text = "This is Hyperlink Testing."

        Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try

    End Sub

End Class
