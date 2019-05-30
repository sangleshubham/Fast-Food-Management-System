Public Class UserInfo
    Friend username As String = ""
    Friend pas As String = ""
    Friend selind As Integer = 0
    Public Sub reload_user()
        connect2()
        cnn.Open()

        With cmd
            .Connection = cnn
            .CommandText = "SELECT * from userinfo"
        End With
        Dim dt2 As New DataTable
        da.SelectCommand = cmd
        da.Fill(dt2)
        cnn.Close()

        With cmb
            .DataSource = dt2
            '.DisplayMember = "orderno"
            .ValueMember = "name"
        End With
    End Sub
    Private Sub UserInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtaddress.Enabled = False
        txtadharno.Enabled = False
        txtemail.Enabled = False
        txtmobno.Enabled = False
        txtname.Enabled = False
        txtSalary.Enabled = False
        txtJoin.Enabled = False



        Refresh()

        'For Each row In dt.Rows
        'MessageBox.Show(row.Item("name"))
        'Next

        connect2()
        cnn.Open()

        With cmd
            .Connection = cnn
            .CommandText = "SELECT * from userinfo"
        End With
        da.SelectCommand = cmd
        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show("Please close if database is open")
        End Try
        cnn.Close()
        With cmb
            .DataSource = dt
            .ValueMember = "name"
        End With

        Try
            cmb.SelectedIndex = 1
            cmb.SelectedIndex = 0
        Catch ex As Exception
            Try
                cmb.SelectedIndex = 0
            Catch ex1 As Exception
                MessageBox.Show("No user Available")
            End Try
        End Try

    End Sub

    Private Sub cmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb.SelectedIndexChanged
        connect2()

        cnn.Open()

        selind = cmb.SelectedIndex


        Dim dt2 As New DataTable
        cmd.Connection = cnn
        cmd.CommandText = "select * from userinfo where name='" & cmb.SelectedValue.ToString & "'"
        da.SelectCommand = cmd

        da.Fill(dt2)
        Dim row As DataRow


        Try
            row = dt2.Rows(0)
        Catch ex As Exception

        End Try


        Try
            txtname.Text = row.Item("name")
        Catch ex As Exception
            txtname.Text = "Not Provided"
        End Try

        Try
            txtaddress.Text = row.Item("address")
        Catch ex As Exception
            txtaddress.Text = "Not Provided"
        End Try

        Try
            txtmobno.Text = row.Item("mobno")
        Catch ex As Exception
            txtmobno.Text = "Not Provided"
        End Try
        Try
            txtemail.Text = row.Item("Email")
        Catch ex As Exception
            txtemail.Text = "Not Provided"
        End Try
        Try
            txtadharno.Text = row.Item("aadhar")
        Catch ex As Exception
            txtadharno.Text = "Not Provided"
        End Try

        Try
            txtSalary.Text = row.Item("salary")
        Catch ex3 As Exception
            txtSalary.Text = "Not Provided"
        End Try

        Try
            txtJoin.Text = row.Item("joindate")
        Catch ex4 As Exception
            txtJoin.Text = "Not Provided"
        End Try
        Try
            Dim imgpath As String = row.Item("imagepath")
            UserImage.BackgroundImage = System.Drawing.Image.FromFile(imgpath)
        Catch ex As Exception
            Try
                Dim imgpath As String = Application.StartupPath & "\userimg\Default.jpg"
                UserImage.BackgroundImage = System.Drawing.Image.FromFile(imgpath)
            Catch ex2 As Exception
                UserImage.BackgroundImage = Nothing

            End Try

        End Try
        Try
            username = row.Item("username")
            pas = row.Item("password")
        Catch ex As Exception

        End Try

        cnn.Close()


    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        txtaddress.Text = ""
        txtadharno.Text = ""
        txtemail.Text = ""
        txtJoin.Text = ""
        txtmobno.Text = ""

        txtname.Text = ""
        txtSalary.Text = ""

        UserImage.BackgroundImage = Nothing
        If Login.isadmin = True Then
            DashboardAdmin.Show()
            Hide()
        Else
            Me.Hide()
            Dashboard.Show()
        End If
        Try
            cnn.Close()

        Catch ex As Exception

        End Try
        Try
            cn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtmobno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmobno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
        If Asc(e.KeyChar) <> 8 Then
            If txtmobno.Text.Length > 9 Then
                MessageBox.Show("Mobile must be less than 10 digit's")
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtadharno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtadharno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress, txtJoin.KeyPress
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

    Private Sub txtname_OnValueChanged(sender As Object, e As EventArgs) Handles txtname.OnValueChanged, txtJoin.OnValueChanged

    End Sub

    Private Sub txtmobno_OnValueChanged(sender As Object, e As EventArgs) Handles txtmobno.OnValueChanged

    End Sub

    Private Sub btnCreateuser_Click(sender As Object, e As EventArgs) Handles btnCreateuser.Click

        If cmb.SelectedValue = Nothing Then
            MessageBox.Show("Please select user name")
        Else
            OnlyUserRecord.Show()
            Hide()
            OnlyUserRecord.ChartRefresh()
        End If



    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If MessageBox.Show("You realy like to delete this user ?", "Delete User", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            connection()
            rs.Open("DELETE * FROM userinfo WHERE username='" & username & "' AND password='" & pas & "'", cn) 'delete quiry
            cn.Close()
            txtaddress.Text = ""
            txtadharno.Text = ""
            txtemail.Text = ""
            txtJoin.Text = ""
            txtmobno.Text = ""

            txtname.Text = ""
            txtSalary.Text = ""
            UserImage.BackgroundImage = Nothing
            'combobox repeating its item again
            'code to reload combobox user name

            connect2()
            cnn.Open()

            With cmd
                .Connection = cnn
                .CommandText = "SELECT * from userinfo"
            End With
            Dim dt2 As New DataTable
            da.SelectCommand = cmd
            da.Fill(dt2)
            cnn.Close()

            With cmb
                .DataSource = dt2
                '.DisplayMember = "orderno"
                .ValueMember = "name"
            End With
            Try
                cmb.SelectedIndex = 1
                cmb.SelectedIndex = 0
            Catch ex As Exception
                Try
                    cmb.SelectedIndex = 0
                Catch ex2 As Exception

                End Try

            End Try
            cnn.Close()


            'cmb.Items.RemoveAt(selind)
        Else

        End If


    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click

        connect2()
        cnn.Open()
        Dim supplierinfodatatable As New DataTable
        With cmd
            .Connection = cnn
            .CommandText = "SELECT name As [User Name],mobno As [Mobile No],aadhar As [Aadhar No],salary As [Salary],joindate As [Join Date] from userinfo"
        End With
        da.SelectCommand = cmd
        Try
            da.Fill(supplierinfodatatable)
        Catch ex As Exception
            MessageBox.Show("No User To Print")

        End Try
        grdUserInfo.DataSource = supplierinfodatatable
        cnn.Close()

        PrintUserInfo.Show()

    End Sub
End Class