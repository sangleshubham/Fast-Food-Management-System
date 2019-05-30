Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Resources
Public Class Send_sms_to_customer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim mobmes As String = TextBox1.Text
            Dim message = TextBox2.Text
            Dim strPost As String
            Dim url As String = "http://api.textlocal.in/send/?"
            Dim username As String = "sangleshubham9@gmail.com"
            Dim hash As String = "04b1a77a40a4d43e1d30d8522380fc9b488714ef3fe7170bdc7040aa70a955ef"


            strPost = url + "username=" & username & "&hash=" & hash & "&message=" & message & "&sender=TXTLCL&numbers=91" & mobmes & "&test=0"


            ' MessageBox.Show("send")
            Dim request As WebRequest = WebRequest.Create(strPost)
            request.Method = "POST"
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(strPost)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()

            Dim response As WebResponse = request.GetResponse()
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Console.WriteLine(responseFromServer)
            Console.ReadLine()

            reader.Close()
            dataStream.Close()
            response.Close()

            If responseFromServer.Length > 0 Then
                MessageBox.Show(responseFromServer)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show("Fail to send sms")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Dashboard.Show()

    End Sub
End Class