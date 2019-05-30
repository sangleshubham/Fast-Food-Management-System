Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Accord.Vision.Detection
Imports Accord.Vision.Detection.Cascades
Public Class CreateUserForm
    Dim picAdmin As New PictureBox
    Dim pic As New PictureBox
    Public isimageisgetfromcamera As Boolean = False
    Dim cameraimagepath As String = ""
    Public str As String = ""
    Public em As Boolean = False
    Friend camera As VideoCaptureDevice
    Public picfor As New PictureBox
    Private Sub CreateUserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblmess2.Hide() ' hide the label When form loads
    End Sub
    Friend Sub getframesonpicturebox()
        UserImage.Image = Nothing
        Dim camerass As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        camera = Login.camera
        AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf captures)
        camera.Start()

    End Sub
    Private Sub captures(sender As Object, evenArgs As NewFrameEventArgs)
        Try
            UserImage.Image = DirectCast(evenArgs.Frame.Clone, Bitmap)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub tmrerr_Tick(sender As Object, e As EventArgs) Handles tmrerr.Tick
        lblmess2.Hide() 'hide error message after some time
    End Sub

    Private Sub btnexit_Click_1(sender As Object, e As EventArgs) Handles btnexit.Click
        'The Main login form is shown when u click on this button
        txtname.Text = ""
        txtemail.Text = ""
        txtpass.Text = ""
        txtusername.Text = ""
        txtaddress.Text = ""
        txtadharno.Text = ""
        txtmobno.Text = ""
        txtSalary.Text = ""
        UserImage.BackgroundImage = Nothing
        DashboardAdmin.Show()
        Me.Hide()
        Try
            camera.Stop()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnCreateuser_Click(sender As Object, e As EventArgs) Handles btnCreateuser.Click

        If txtname.Text = "" Then
            txtname.Focus()
            lblmess2.Show()
            lblmess2.Text = "Enter your name"
            tmrerr.Start()
            txtname.Focus()
        ElseIf txtmobno.Text = "" Or txtmobno.Text.Length < 10 Then
            txtmobno.Focus()
            lblmess2.Show()
            lblmess2.Text = "Enter your Mobile Number"
            tmrerr.Start()
            txtmobno.Focus()

        ElseIf txtadharno.Text.Length < 1 Then
            txtadharno.Focus()
            lblmess2.Show()
            lblmess2.Text = "Enter your Adhar No Number"
            tmrerr.Start()
        ElseIf txtaddress.Text = "" Then
            txtaddress.Focus()
            lblmess2.Show()
            lblmess2.Text = "Enter your Residential Address"
            tmrerr.Start()
            txtaddress.Focus()
        ElseIf em = True And txtemail.Text.Contains("@") = False Then
            txtemail.Focus()
            lblmess2.Show()
            lblmess2.Text = "Enter your correct Email Id"
            tmrerr.Start()
            txtemail.Focus()

        ElseIf txtusername.Text = "" Then
            txtusername.Focus()
            lblmess2.Show()
            lblmess2.Text = "Enter your Username For Login Into Software"
            tmrerr.Start()
        ElseIf txtpass.Text = "" Then
            txtpass.Focus()
            lblmess2.Show()
            lblmess2.Text = "Enter your Password for Login into Software"
            tmrerr.Start()
        ElseIf str.ToString = "" And isimageisgetfromcamera = False Then
            lblmess2.Show()
            lblmess2.Text = "Please select your photo from directory"
            tmrerr.Start()
        ElseIf txtSalary.Text = "" Then
            lblmess2.Show()
            lblmess2.Text = "Enter salary"
            tmrerr.Start()
            txtSalary.Focus()



        Else
            Try
                cn.Close()

            Catch ex As Exception

            End Try


            connection()
            rs.Open("select * from userinfo where name='" & txtname.Text.ToString & "'", cn)

            If rs.EOF = False Then
                cn.Close()
                lblmess2.Show()
                lblmess2.Text = "Please Enter Another Name for User "
                tmrerr.Start()
            ElseIf isimageisgetfromcamera = True

                str = cameraimagepath
                Try
                    cn.Close()

                Catch ex As Exception

                End Try
                Try
                    connection()

                    rs.Open("INSERT INTO userinfo values('" & txtusername.Text & "','" & txtpass.Text & "','" & txtname.Text & "','" & txtmobno.Text & "','" & txtaddress.Text & "','" & txtemail.Text & "','" & str & "','" & txtadharno.Text & "','" & CInt(txtSalary.Text) & "','" & My.Computer.Clock.LocalTime.ToShortDateString & "')", cn)

                    Button1.PerformClick()

                    MessageBox.Show("User is created")

                    txtname.Text = ""
                    txtemail.Text = ""
                    txtpass.Text = ""
                    txtusername.Text = ""
                    txtaddress.Text = ""
                    txtadharno.Text = ""
                    txtmobno.Text = ""
                    txtSalary.Text = ""
                    UserImage.Image = Nothing
                    txtname.Focus()
                    DashboardAdmin.Show()
                    Me.Hide()
                    isimageisgetfromcamera = False
                Catch ex As Exception
                    lblmess2.Show()
                    lblmess2.Text = "The user is already present Please select another username"
                    tmrerr.Start()
                End Try
                UserInfo.reload_user()

                'UserInfo.cmb.Items.Add(txtname.Text.ToString)
                cn.Close()
            Else                    'working perfect
                cn.Close()

                Dim onlyfilename As String = selectuserimage.SafeFileName

                Dim sourcepath As String = selectuserimage.FileName 'here is the source path of file

                Dim destinationpath As String = Application.StartupPath & "\userimg\" 'here is the destination path of the image

                If Not My.Computer.FileSystem.DirectoryExists(destinationpath) = True Then
                    My.Computer.FileSystem.CreateDirectory(destinationpath)
                End If

                str = destinationpath.ToString + onlyfilename.ToString

                Dim file As New IO.FileInfo(sourcepath) 'total info is stored of file is stored in the fileinfo object

                Try
                    file.CopyTo(destinationpath & onlyfilename, False) 'file will copy to the destination path with file name False means overwriting is off
                Catch ex As Exception
                    Dim r As System.Random = New System.Random()

                    Dim a As Integer
                    a = r.Next(0, 10000)
                    file.CopyTo(destinationpath & onlyfilename & a & ".jpg", True)
                    str = destinationpath & onlyfilename & a & ".jpg"

                End Try


                connection()
                'MessageBox.Show("connection is ok")
                Try
                    rs.Open("INSERT INTO userinfo values('" & txtusername.Text & "','" & txtpass.Text & "','" & txtname.Text & "','" & txtmobno.Text & "','" & txtaddress.Text & "','" & txtemail.Text & "','" & str & "','" & txtadharno.Text & "','" & CInt(txtSalary.Text) & "','" & My.Computer.Clock.LocalTime.ToShortDateString & "')", cn)
                    Button1.PerformClick()
                    MessageBox.Show("User is created")
                    txtname.Text = ""
                    txtemail.Text = ""
                    txtpass.Text = ""
                    txtusername.Text = ""
                    txtaddress.Text = ""
                    txtadharno.Text = ""
                    txtmobno.Text = ""
                    txtSalary.Text = ""
                    UserImage.BackgroundImage = Nothing
                    UserImage.Image = Nothing
                    txtname.Focus()
                    'capture image of Admin


                    'capture image End
                    DashboardAdmin.Show()
                    Me.Hide()
                    '  camera.Stop()

                Catch ex As Exception
                    lblmess2.Show()
                    lblmess2.Text = "The user is already present Please select another username"
                    tmrerr.Start()
                End Try
                UserInfo.reload_user()


                cn.Close()

            End If


        End If
        Try
            camera.Stop()
        Catch ex As Exception

        End Try
        Try
            camera.Stop()

        Catch ex As Exception

        End Try

        'try From here

















    End Sub

    Private Sub UserImage_Click(sender As Object, e As EventArgs) Handles UserImage.Click
        SelectImageGetFrom.Show()

    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Not Asc(e.KeyChar) = 8 Then
            If Not Asc(e.KeyChar) = 32 Then
                If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 Then
                    If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txtmobno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmobno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If txtmobno.Text.Length >= 10 Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub tileCreateUser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtSalary_OnValueChanged(sender As Object, e As EventArgs) Handles txtSalary.OnValueChanged

    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtmobno_OnValueChanged(sender As Object, e As EventArgs) Handles txtmobno.OnValueChanged

    End Sub
    Dim picCap As New PictureBox


    Private Sub txtemail_OnValueChanged(sender As Object, e As EventArgs) Handles txtemail.OnValueChanged
        If txtemail.Text.Length > 0 Then
            em = True
        Else
            em = False
        End If
    End Sub
    Private Sub capturea(sender As Object, evenArgs As NewFrameEventArgs)

        pic.Image = DirectCast(evenArgs.Frame.Clone, Bitmap)


    End Sub

    Private Sub captureAdmin(sender As Object, evenArgs As NewFrameEventArgs)

        picAdmin.Image = DirectCast(evenArgs.Frame.Clone, Bitmap)


    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Try
            camera.Stop()
        Catch ex As Exception

        End Try


        UserImage.Image = UserImage.Image

        Dim des As String = Application.StartupPath & "\userimg\" 'here is the destination path of the image

        If Not My.Computer.FileSystem.DirectoryExists(des) = True Then
            My.Computer.FileSystem.CreateDirectory(des)
        End If


        Dim r2 As System.Random = New System.Random()
        Dim a2 As Integer
        a2 = r2.Next(0, 100000)

        Dim path As String = Application.StartupPath & "\userimg\" & txtname.Text.ToString & a2 & ".jpeg"

        UserImage.Image.Save(path, Imaging.ImageFormat.Jpeg)

        isimageisgetfromcamera = True

        cameraimagepath = path
        Timer1.Stop()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim detector As HaarObjectDetector
        Dim cascade As New FaceHaarCascade

        detector = New HaarObjectDetector(cascade, 30)


        detector.SearchMode = ObjectDetectorSearchMode.Average
        detector.ScalingFactor = 1.5
        detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller
        detector.UseParallelProcessing = True
        detector.Suppression = 2
        Dim im As New PictureBox
        Try
            'Dim ima As New PictureBox
            'Try
            '    ima.Image = UserImage.Image
            'Catch ex As Exception

            'End Try


            Dim faceObjects As Rectangle() = detector.ProcessFrame(UserImage.Image)
            Dim g As Graphics = Graphics.FromImage(UserImage.Image)
            Dim cn As Integer = 0
            Dim facecount As Integer = 0

            For Each face In faceObjects
                g.DrawRectangle(Pens.White, face)
                If faceObjects.Count > 0 Then
                    UserImage.Image = UserImage.Image
                    Timer1.Stop()
                    camera.Stop()
                    btnCapture.PerformClick()

                End If
            Next

            g.Dispose()

            UserImage.Invalidate()

        Catch ex As System.AccessViolationException

        End Try


    End Sub

    Private Sub chkbxDetectFace_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkbxDetectFace.ToggleStateChanged
        If chkbxDetectFace.Checked = True Then
            Timer1.Start()
            btnCapture.Visible = False
        Else
            Timer1.Stop()
            Timer1.Dispose()
            btnCapture.Visible = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim des As String = Application.StartupPath & "\AdminUserCreateImages\" 'here is the destination path of the image
        If Not My.Computer.FileSystem.DirectoryExists(des) = True Then
            My.Computer.FileSystem.CreateDirectory(des)
        End If


        Dim cam As VideoCaptureDevice

        cam = Login.camera
        AddHandler cam.NewFrame, New NewFrameEventHandler(AddressOf captureAdmin)
        cam.Start()


        Dim r As System.Random = New System.Random()
        Dim a As Integer
        a = r.Next(0, 100000)

        Dim path As String = Application.StartupPath & "\AdminUserCreateImages\" & txtusername.Text.ToString & a & ".jpeg"
        'Dim path As String = Application.StartupPath & "\AdminUserCreateImages\" & a & ".jpeg"

        Dim i As Integer = 0
        While (i < 10)
            Try

                picAdmin.Image.Save(path, Imaging.ImageFormat.Jpeg)
                i = 10

            Catch ex As Exception

            End Try

        End While


        cam.Stop()

    End Sub








End Class