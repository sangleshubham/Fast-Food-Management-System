Imports AForge.Video
Imports AForge.Video.DirectShow
Imports Accord.Vision.Detection
Imports Accord.Vision.Detection.Cascades
Public Class CaptureByCamera
    Public isImageCapture As Boolean = False
    Dim camera As VideoCaptureDevice
    Public imagepath As String
    Private Sub CaptureByCamera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim camerass As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        camera = Login.camera
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf capture)
            camera.Start()

        '  drawRect.Start()
    End Sub
    Private Sub capture(sender As Object, evenArgs As NewFrameEventArgs)
        'Dim pic As New PictureBoxtry
        Try
            PictureBox1.Image = DirectCast(evenArgs.Frame.Clone, Bitmap)

        Catch ex As Exception

        End Try


        '    Dim pic As New PictureBox
        '    pic.Image = PictureBox1.Image
        '    Dim detector As HaarObjectDetector
        '    Dim cascade As New FaceHaarCascade
        '    detector = New HaarObjectDetector(cascade, 30)

        '    detector.SearchMode = ObjectDetectorSearchMode.Average
        '    detector.ScalingFactor = 1.5
        '    detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller
        '    detector.UseParallelProcessing = True
        '    detector.Suppression = 3

        '    Dim sw As Stopwatch = Stopwatch.StartNew
        '    Dim faceObjects As Rectangle() = detector.ProcessFrame(PictureBox1.Image)
        '    sw.Stop()

        '    Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        '    For Each face In faceObjects
        '        g.DrawRectangle(Pens.DeepSkyBlue, face)
        '        drawRect.Stop()
        '    Next
        '    g.Dispose()

        '    PictureBox1.Invalidate()
        'Catch ex As Exception

        'End Try



        ' PictureBox1.Image = pic.Image
        ' PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY)
    End Sub

    Private Sub btnCaptureImage_Click(sender As Object, e As EventArgs) Handles btnCaptureImage.Click
        Dim pic As New PictureBox
        pic.Image = PictureBox1.Image

        Dim destinationpath As String = Application.StartupPath & "\Temp\" 'here is the destination path of the image
        If Not My.Computer.FileSystem.DirectoryExists(destinationpath) = True Then
            My.Computer.FileSystem.CreateDirectory(destinationpath)
        End If

        Dim r As System.Random = New System.Random()
        Dim a As Integer
        a = r.Next(0, 100000)
        imagepath = Application.StartupPath & "\Temp\" & a & ".jpeg"
        pic.Image.Save(imagepath, Imaging.ImageFormat.Jpeg)

        isImageCapture = True


        CreateUserForm.UserImage.BackgroundImage = PictureBox1.Image
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()
        CreateUserForm.Show()
        camera.Stop()

    End Sub

    Private Sub btnChangeCamera_Click(sender As Object, e As EventArgs) Handles btnChangeCamera.Click
        drawRect.Start()
    End Sub

    Private Sub drawRect_Tick(sender As Object, e As EventArgs) Handles drawRect.Tick
        Dim detector As HaarObjectDetector
        Dim cascade As New FaceHaarCascade

        detector = New HaarObjectDetector(cascade, 30)

        ''Try New To detect nose
        'Dim nose As New Accord.Vision.Detection.Cascades.NoseHaarCascade
        'Dim detect As HaarObjectDetector
        'detect = New HaarObjectDetector(nose, 30)
        'detect.SearchMode = ObjectDetectorSearchMode.Average
        'detect.ScalingFactor = 1.5
        'detect.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller
        'detect.UseParallelProcessing = True
        'detect.Suppression = 1

        'Dim noseObject As Rectangle() = detect.ProcessFrame(PictureBox1.Image)


        'Dim g1 As Graphics = Graphics.FromImage(PictureBox1.Image)
        'For Each face In noseObject
        '    g1.DrawRectangle(Pens.Yellow, face)
        '    MessageBox.Show("Nose Detected")

        'Next
        '    End New


        'detecct face in picture box
        detector.SearchMode = ObjectDetectorSearchMode.Average
        detector.ScalingFactor = 1.5
        detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller
        detector.UseParallelProcessing = True
        detector.Suppression = 1.5


        Dim faceObjects As Rectangle() = detector.ProcessFrame(PictureBox1.Image)


        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        Dim cn As Integer = 0
        If faceObjects.Count > 1 Then
            RadLabel1.Show()
        Else
            RadLabel1.Hide()
        End If
        Dim facecount As Integer = 0

        For Each face In faceObjects
            g.DrawRectangle(Pens.White, face)

            facecount = facecount + 1


        Next
        lblFaceCount.Text = facecount
        g.Dispose()

        PictureBox1.Invalidate()


    End Sub
End Class