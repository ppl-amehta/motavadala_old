Imports System.io

Partial Class _Default
    Inherits System.Web.UI.Page

    Private Sub _Default_Load(sender As Object, e As EventArgs) Handles Me.Load

        'lblMessage.Text = My.Computer.Clock.LocalTime.ToString & vbCrLf & " " & My.Computer.Clock.GmtTime.ToString

		Try

			'lblMessage.Text = DateNow.ToLongTimeString

			'Dim FilePath As String = Server.MapPath("~") & "Receipt_PDF\" & "FILENAME.txt"
			'Dim FileContent As String = "Put File Content Here"
			'File.WriteAllText(FilePath, FileContent)

			'lblMessage.text = "File Created Successfully."

			'Dim readText As String() = File.ReadAllLines(FilePath)
			'Dim strbuild As New StringBuilder()
			'For Each s As String In readText
			'	strbuild.Append(s)
			'	strbuild.AppendLine()
			'Next
			'lblMessage.Text = strbuild.ToString()

			lblMessage.Text = Session("Error")

		Catch ex As Exception

            lblMessage.Text = ex.Message

        End Try
		
    End Sub

    Public Shared Function DateNow() As DateTime
        Dim utcTime As DateTime = DateTime.UtcNow
        Dim myZone As TimeZoneInfo = TimeZoneInfo.CreateCustomTimeZone("INDIA", New TimeSpan(+5, +30, 0), "India", "India")
        Dim custDateTime As DateTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, myZone)
        Return custDateTime
    End Function

End Class
