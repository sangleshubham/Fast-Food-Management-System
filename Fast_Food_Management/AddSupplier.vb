Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Accord.Vision.Detection
Imports Accord.Vision.Detection.Cascades
Public Class AddSupplier
    Dim source As String = ""
    Public isimageisgetfromcamera As Boolean = False
    Dim cameraimagepath As String = ""
    Public str As String = ""
    Public em As Boolean = False
    Friend camera As VideoCaptureDevice
    Private Sub btnSaveSupplier_Click(sender As Object, e As EventArgs) Handles btnSaveSupplier.Click

        If txtSupplierName.Text = "" Then
            lblmess2.Show()
            lblmess2.Text = "Please Enter Supplier Name"
            Timer1.Start()
        ElseIf txtSupplierPhoneNo.Text = "" Or txtSupplierPhoneNo.Text.Length < 10 Then
            lblmess2.Show()
            lblmess2.Text = "Please Enter Supplier Phone No"
            Timer1.Start()
        ElseIf txtAddress.Text = "" Then
            lblmess2.Show()
            lblmess2.Text = "Please Enter Supplier Personal Address"
            Timer1.Start()
        ElseIf txtProductName.Text = "" Then
            lblmess2.Show()
            lblmess2.Text = "Please Enter Product Name"
            Timer1.Start()
            'ElseIf source = "" Then

            '    lblmess2.Show()
            '    lblmess2.Text = "Please Select Image"
            '    Timer1.Start()


        Else
            If isimageisgetfromcamera = True Then
                str = cameraimagepath
                Try
                    cn.Close()

                Catch ex As Exception

                End Try
                Try
                    connection()

                    rs.Open("INSERT INTO supplierdata values('" & txtSupplierName.Text & "','" & txtAddress.Text & "','" & txtSupplierPhoneNo.Text & "','" & txtProductName.Text & "','" & str.ToString & "','" & txtPrice.Text & "')", cn)
                    ' MessageBox.Show("Supplier  Addeds")
                    'get image of creater at end



                    Dim des As String = Application.StartupPath & "\AdminUserCreateImages\" 'here is the destination path of the image
                    If Not My.Computer.FileSystem.DirectoryExists(des) = True Then
                        My.Computer.FileSystem.CreateDirectory(des)
                    End If


                    Dim cam As VideoCaptureDevice

                    cam = Login.camera
                    AddHandler cam.NewFrame, New NewFrameEventHandler(AddressOf captureAdmin)
                    cam.Start()


                    Dim r2 As System.Random = New System.Random()
                    Dim a2 As Integer
                    a2 = r2.Next(0, 100000)

                    Dim path As String = Application.StartupPath & "\AdminUserCreateImages\" & txtSupplierName.Text.ToString & a2 & ".jpeg"
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
                    txtProductName.Text = ""
                    txtAddress.Text = ""
                    txtSupplierName.Text = ""
                    txtSupplierPhoneNo.Text = ""
                    SupplierImage.Image = Nothing
                    txtPrice.Text = ""

                    DashboardAdmin.Show()
                    Me.Hide()
                    isimageisgetfromcamera = False
                Catch ex As Exception
                    lblmess2.Show()
                    lblmess2.Text = "The Supplier is already present Please select another username"
                    Timer1.Start()
                End Try
                UserInfo.reload_user()

                'UserInfo.cmb.Items.Add(txtname.Text.ToString)
                cn.Close()

            Else


                Dim onlyfilename As String = OpenFileDialog1.SafeFileName
                Dim sourcepath As String = OpenFileDialog1.FileName 'here is the source path of file
                Dim destinationpath As String = Application.StartupPath & "\supplier\" 'here is the destination path of the image
                If Not My.Computer.FileSystem.DirectoryExists(destinationpath) = True Then 'check if Directory is present else create one 
                    My.Computer.FileSystem.CreateDirectory(destinationpath)
                End If
                source = destinationpath.ToString + onlyfilename.ToString 'store destination address of image in ssource variables
                Dim file As New IO.FileInfo(sourcepath) 'total info is stored of file in the fileinfo object
                Try
                    file.CopyTo(destinationpath & onlyfilename, False) 'file will copy to the destination path with file name False means overwriting is off
                Catch ex As Exception
                    Dim r As System.Random = New System.Random()

                    Dim a As Integer
                    a = r.Next(0, 10000) 'the randimizer is only betn 0 t 10000
                    file.CopyTo(destinationpath & onlyfilename & a & ".jpg", True) 'now combine randomizer value with image path
                    source = destinationpath & onlyfilename & a & ".jpg"

                End Try

                Try
                    cnn.Close()

                Catch ex As Exception

                End Try
                Try
                    cn.Close()
                Catch ex As Exception

                End Try

                'MessageBox.Show("connection is ok")
                Try
                    connection()
                    rs.Open("INSERT INTO supplierdata values('" & txtSupplierName.Text & "','" & txtAddress.Text & "','" & txtSupplierPhoneNo.Text & "','" & txtProductName.Text & "','" & source.ToString & "','" & txtPrice.Text & "')", cn)
                    ' MessageBox.Show("Supplier  Addeds")
                    'get image of creater at end



                    Dim des As String = Application.StartupPath & "\AdminUserCreateImages\" 'here is the destination path of the image
                    If Not My.Computer.FileSystem.DirectoryExists(des) = True Then
                        My.Computer.FileSystem.CreateDirectory(des)
                    End If


                    Dim cam As VideoCaptureDevice

                    cam = Login.camera
                    AddHandler cam.NewFrame, New NewFrameEventHandler(AddressOf captureAdmin)
                    cam.Start()


                    Dim r2 As System.Random = New System.Random()
                    Dim a2 As Integer
                    a2 = r2.Next(0, 100000)

                    Dim path As String = Application.StartupPath & "\AdminUserCreateImages\" & txtSupplierName.Text.ToString & a2 & ".jpeg"
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
                    txtProductName.Text = ""
                    txtAddress.Text = ""
                    txtSupplierName.Text = ""
                    txtSupplierPhoneNo.Text = ""
                    SupplierImage.BackgroundImage = Nothing
                    txtPrice.Text = ""
                    cn.Close()
                Catch ex As Exception
                    lblmess2.Show()
                    lblmess2.Text = "The Supplier is already present Please select another username"
                    Timer1.Start()
                End Try

                If MessageBox.Show("Would you like to add anather supplier?", "Add Supplier", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    txtSupplierName.Focus()


                Else
                    DashboardAdmin.Show()
                    Me.Hide()
                End If
            End If
        End If



    End Sub
    Dim picAdmin As New PictureBox
    Private Sub captureAdmin(sender As Object, evenArgs As NewFrameEventArgs)

        picAdmin.Image = DirectCast(evenArgs.Frame.Clone, Bitmap)


    End Sub

    Private Sub SupplierImage_Click(sender As Object, e As EventArgs) Handles SupplierImage.Click
        getSupplierImages.Show()


    End Sub
    Private Sub txtSupplierName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupplierName.KeyPress
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

    Private Sub txtSupplierPhoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupplierPhoneNo.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        If txtSupplierPhoneNo.Text.Length >= 10 Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub txtProductName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProductName.KeyPress
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
    Private Sub AddSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblmess2.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtProductName.Text = ""
        txtAddress.Text = ""
        txtSupplierName.Text = ""
        txtSupplierPhoneNo.Text = ""
        SupplierImage.BackgroundImage = Nothing
        txtPrice.Text = ""
        Me.Hide()
        DashboardAdmin.Show()
        Try
            cnn.Close()

        Catch ex As Exception

        End Try
        Try
            cn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblmess2.Hide()

    End Sub
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Try
            camera.Stop()
        Catch ex As Exception

        End Try


        SupplierImage.Image = SupplierImage.Image

        Dim des As String = Application.StartupPath & "\supplier\" 'here is the destination path of the image

        If Not My.Computer.FileSystem.DirectoryExists(des) = True Then
            My.Computer.FileSystem.CreateDirectory(des)
        End If


        Dim r2 As System.Random = New System.Random()
        Dim a2 As Integer
        a2 = r2.Next(0, 100000)

        Dim path As String = Application.StartupPath & "\supplier\" & txtSupplierName.Text.ToString & a2 & ".jpeg"

        SupplierImage.Image.Save(path, Imaging.ImageFormat.Jpeg)

        isimageisgetfromcamera = True

        cameraimagepath = path
        Timer2.Stop()
    End Sub

    Private Sub chkbxDetectFace_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles chkbxDetectFace.ToggleStateChanged
        If chkbxDetectFace.Checked = True Then
            Timer2.Start()
            btnCapture.Visible = False
        Else
            Timer2.Stop()
            Timer2.Dispose()
            btnCapture.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            Dim g As Graphics
            Dim detector As HaarObjectDetector
            Dim cascade As New FaceHaarCascade

            detector = New HaarObjectDetector(cascade, 30)


            detector.SearchMode = ObjectDetectorSearchMode.Average
            detector.ScalingFactor = 1.5
            detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller
            detector.UseParallelProcessing = True
            detector.Suppression = 3
            Dim im As New PictureBox
            Try
                ' im.Image = UserImage.Image

                Dim faceObjects As Rectangle() = detector.ProcessFrame(SupplierImage.Image)


                g = Graphics.FromImage(SupplierImage.Image)
                Dim cn As Integer = 0
                Dim facecount As Integer = 0

                For Each face In faceObjects
                    g.DrawRectangle(Pens.White, face)
                    If faceObjects.Count > 0 Then
                        SupplierImage.Image = SupplierImage.Image
                        btnCapture.PerformClick()
                        Timer2.Stop()
                        camera.Stop()
                        btnCapture.PerformClick()

                    End If
                Next

                g.Dispose()

                SupplierImage.Invalidate()

            Catch ex As System.AccessViolationException

            End Try

        Catch ex As Exception

        End Try
    End Sub
    Friend Sub getframesonpicturebox()
        SupplierImage.Image = Nothing
        Dim camerass As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        camera = Login.camera
        AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf captures)
        camera.Start()
    End Sub
    Private Sub captures(sender As Object, evenArgs As NewFrameEventArgs)

        SupplierImage.Image = DirectCast(evenArgs.Frame.Clone, Bitmap)



    End Sub
End Class