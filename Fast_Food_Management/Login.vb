Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class Login
    Public iscameraon As Boolean = False

    Public camera As VideoCaptureDevice
    Public loginname As String = ""
    Public isadmin As Boolean = False


    Private Sub tmrerr_Tick(sender As Object, e As EventArgs) Handles tmrerr.Tick
        lblerror.Hide()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblerror.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim camerass As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        Dim i As Integer = 0

        If iscameraon = False Then
            If camerass.ShowDialog = DialogResult.OK Then
                camera = camerass.VideoDevice
                iscameraon = True

            End If

        Else

            If txtboxusername.Text = "" Then
                txtboxusername.Focus()
                lblerror.Show()
                lblerror.Text = "Enter Username"
                tmrerr.Start()
            ElseIf txtboxppass.Text = "" Then
                txtboxppass.Focus()
                lblerror.Show()
                lblerror.Text = "Enter Password"
                tmrerr.Start()
            ElseIf txtboxusername.Text = "Admin" And txtboxppass.Text = "Admin"
                Dim mes As String = "You are succesfully login " & Environment.NewLine & " You Are Logged In As Admin "
                isadmin = True

                RadDesktopAlert1.ContentText = mes
                RadDesktopAlert1.Show()
                txtboxusername.Text = ""
                txtboxppass.Text = ""
                DashboardAdmin.Show()
                Hide()
                FloatingWebBrowseOpener.Show()



            Else
                'code for datatabse connection and access databse form here for login
                Try
                    connection()
                    rs.Open("select * from userinfo where username='" & txtboxusername.Text & "' AND password='" & txtboxppass.Text & "'", cn)
                    If rs.EOF = False Then
                        'rs.Open("select Name_Of_user from User_Info='" & txtboxusername.Text & "' and Password='" & txtboxppass.Text & "'", cn)
                        cn.Close()
                        loginname = txtboxusername.Text
                        Dim mes As String = "You are succesfully login " & Environment.NewLine & " Hello Mr " & txtboxusername.Text & ""
                        RadDesktopAlert1.ContentText = mes
                        RadDesktopAlert1.Show()
                        txtboxusername.Text = ""
                        txtboxppass.Text = ""
                        Dashboard.Show()
                        Hide()
                        FloatingWebBrowseOpener.Show()

                    Else
                        MessageBox.Show("Username and Password are Invalid")
                        cn.Close()
                    End If
                Catch ex As Exception
                    cn.Close()
                    MessageBox.Show("Something went going wrong please Contact to administrator")
                End Try
            End If
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click
        ForgetPassword.Show()
        Hide()

    End Sub
End Class