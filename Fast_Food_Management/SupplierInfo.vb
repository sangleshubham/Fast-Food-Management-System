Public Class SupplierInfo
    Friend userna As String
    Friend pa As String

    Private Sub SupplierInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'code for fill drop down box of the Supper Name

        connect2()
        cnn.Open()
        Dim dt2 As New DataTable
        With cmd
            .Connection = cnn
            .CommandText = "SELECT name from supplierdata"
        End With
        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
        Catch ex As Exception



            MessageBox.Show("Please Close if you opened databse in user mode")

        End Try
        cnn.Close()
        Try
            With cmbSupplierName
                .DataSource = dt2
                .ValueMember = "name"
            End With
        Catch ex As Exception

        End Try


        Try
            cmbSupplierName.SelectedIndex = 1
            cmbSupplierName.SelectedIndex = 0
        Catch ex As Exception
            Try
                cmbSupplierName.SelectedIndex = 0
            Catch ex1 As Exception

            End Try
        End Try


    End Sub
    Public Sub reload()

        Dim dt2 As New DataTable
        connect2()
        cnn.Open()

        With cmd
            .Connection = cnn
            .CommandText = "SELECT name from supplierdata"
        End With
        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
        Catch ex As Exception



            MessageBox.Show("Please Close if you opened databse in user mode")

        End Try
        cnn.Close()
        Try
            With cmbSupplierName
                .DataSource = dt2
                .ValueMember = "name"
            End With
        Catch ex As Exception

        End Try


        Try
            cmbSupplierName.SelectedIndex = 1
            cmbSupplierName.SelectedIndex = 0
        Catch ex As Exception
            Try
                cmbSupplierName.SelectedIndex = 0
            Catch ex1 As Exception
                MessageBox.Show("No Supplier Available")
            End Try
        End Try

    End Sub

    Private Sub cmbSupplierName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplierName.SelectedIndexChanged
        connect2()

        cnn.Open()




        Dim dt2 As New DataTable
        cmd.Connection = cnn
        cmd.CommandText = "select * from supplierdata where name='" & cmbSupplierName.SelectedValue.ToString & "'"
        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
        Catch ex As Exception

        End Try

        Dim row As DataRow


        Try
            row = dt2.Rows(0)
        Catch ex As Exception

        End Try

        Try
            txtPrice.Text = row.Item("price")
        Catch ex As Exception
            txtProductName.Text = "Not Provided"
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
            txtmobno.Text = row.Item("phoneno")
        Catch ex As Exception
            txtmobno.Text = "Not Provided"
        End Try

        Try
            txtProductName.Text = row.Item("productname")
        Catch ex As Exception
            txtProductName.Text = "Not Provided"
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
            userna = row.Item("name")
            pa = row.Item("productname")
        Catch ex As Exception

        End Try

        cnn.Close()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
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

    Private Sub btnDeleteSupplier_Click(sender As Object, e As EventArgs) Handles btnDeleteSupplier.Click
        If MessageBox.Show("You realy like to delete this user ?", "Delete User", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            connection()
            rs.Open("DELETE * FROM supplierdata WHERE name='" & userna & "' AND productname='" & pa & "'", cn) 'delete quiry
            cn.Close()
            txtProductName.Text = ""
            txtname.Text = ""
            txtmobno.Text = ""
            txtaddress.Text = ""
            txtPrice.Text = ""
            UserImage.BackgroundImage = Nothing
            connect2()
            cnn.Open()

            With cmd
                .Connection = cnn
                .CommandText = "SELECT * from supplierdata"
            End With
            Dim dt2 As New DataTable
            da.SelectCommand = cmd
            Try
                da.Fill(dt2)
            Catch ex As Exception
                MessageBox.Show("No Supplier Found")
            End Try
            cnn.Close()

            With cmbSupplierName
                .DataSource = dt2
                .ValueMember = "name"
            End With
        Else

        End If

    End Sub

    Private Sub btnProductBySupplier_Click(sender As Object, e As EventArgs) Handles btnProductBySupplier.Click
        If cmbSupplierName.SelectedValue = Nothing Then
            MessageBox.Show("Please select supplier name")
        Else
            Me.Hide()
            ProductSuppliesBySpecificSupplier.Show()
            ProductSuppliesBySpecificSupplier.ChartRefresh()
        End If


    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        connect2()
        cnn.Open()
        Dim supplierinfodatatable As New DataTable
        With cmd
            .Connection = cnn
            'name as [Supplier Name],productname as [Product Name],price as [Price],phoneno as [Phone No],adddress as [Address]
            .CommandText = "SELECT name As [Supplier Name],productname As [Product Name],price As [Price],phoneno As [Phone No] from supplierdata"
        End With
        da.SelectCommand = cmd
        Try
            da.Fill(supplierinfodatatable)
        Catch ex As Exception
            MessageBox.Show("No User To Print")
        End Try
        grdSupplierRecord.DataSource = supplierinfodatatable
        cnn.Close()
        PrintSupplierInfo.Show()

    End Sub
End Class