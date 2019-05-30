Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Resources
Public Class ForgetPassword
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        If txtgetUserName.Text.Length > 0 Then
            connect2()
            cnn.Open()
            Try
                cmd.Connection = cnn
                cmd.CommandText = "select mobno,password from userinfo where username ='" & txtgetUserName.Text.ToString & "'"

            Catch ex As Exception

            End Try

            da.SelectCommand = cmd
            Dim dt2 As New DataTable
            Try
                da.Fill(dt2)
            Catch ex As Exception
                MessageBox.Show("Invalid Uesrname")
            End Try

            Dim row As DataRow


            Try
                row = dt2.Rows(0)
            Catch ex As Exception

            End Try
            Try
                'send message 
                Dim mobn As String = row.Item("mobno")
                lblNo.Text = "PASSWORD SENDED ON : +91 " & mobn
                lblNo.Show()
                Try
                    Dim mobmes As String = row.Item("password")
                    Dim message = "Your Password Is : " & mobmes
                    Dim strPost As String
                    Dim url As String = "http://api.textlocal.in/send/?"
                    Dim username As String = "sangleshubham9@gmail.com"
                    Dim hash As String = "04b1a77a40a4d43e1d30d8522380fc9b488714ef3fe7170bdc7040aa70a955ef"


                    strPost = url + "username=" & username & "&hash=" & hash & "&message=" & message & "&sender=TXTLCL&numbers=91" & mobn & "&test=0"


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



            Catch ex As Exception
                MessageBox.Show("No user found")
                lblNo.Hide()

            End Try



            cnn.Close()
        Else
            txtgetUserName.Focus()

        End If






    End Sub
End Class