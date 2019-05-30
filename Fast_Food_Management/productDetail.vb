Public Class productDetail
    Private Sub productDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        connect2()
        cnn.Open()

        Dim dt2 As New DataTable

        cmd.Connection = cnn
        cmd.CommandText = "select * from product"

        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
            grdviewProducts.DataSource = dt2
            With drpdwnProductName
                .DataSource = dt2
                .ValueMember = "name"
            End With
        Catch ex As Exception

        End Try



        grdviewProducts.BestFitColumns()


        'code for filling drop down list at load of form



        Try
            drpdwnProductName.SelectedIndex = 1
            drpdwnProductName.SelectedIndex = 0
        Catch ex As Exception
            Try
                drpdwnProductName.SelectedIndex = 0
            Catch ex1 As Exception
                MessageBox.Show("No Product Found")
            End Try
        End Try
        Try
            cnn.Close()
        Catch ex As Exception

            Try
                cnn.Close()
            Catch ex2 As Exception

            End Try

        End Try




    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

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
    Public Sub ReloadProduct()
        connect2()
        cnn.Open()

        Dim dt2 As New DataTable

        cmd.Connection = cnn
        cmd.CommandText = "select * from product"

        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
            grdviewProducts.DataSource = dt2
            With drpdwnProductName
                .DataSource = dt2
                .ValueMember = "name"
            End With
        Catch ex As Exception

        End Try



        grdviewProducts.BestFitColumns()


        'code for filling drop down list at load of form



        Try
            drpdwnProductName.SelectedIndex = 1
            drpdwnProductName.SelectedIndex = 0
        Catch ex As Exception
            Try
                drpdwnProductName.SelectedIndex = 0
            Catch ex1 As Exception
                MessageBox.Show("No Product Found")
            End Try
        End Try
        Try
            cnn.Close()
        Catch ex As Exception

            Try
                cnn.Close()
            Catch ex2 As Exception

            End Try

        End Try

    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click


        Dim name As String = drpdwnProductName.SelectedValue
        Try
            connection()
            rs.Open("delete from product where name='" & name & "'", cn)
            cn.Close()
            MainForm.drpdwnProductList.RemoveItem(name)
        Catch ex As Exception
            MessageBox.Show("Fail to Delete product Please try again")
        End Try

        connect2()
        cnn.Open()
        Dim dt3 As New DataTable

        cmd.Connection = cnn
        cmd.CommandText = "select * from product"
        da.SelectCommand = cmd
        Try
            da.Fill(dt3)
        Catch ex As Exception
            MessageBox.Show("If you open databse someware please close it Manualy" & Environment.NewLine & "Else Application not work Correctly")
        End Try

        'fill data grid view again
        Try
            grdviewProducts.DataSource = dt3
            ' MessageBox.Show("Grid view is filled")
            grdviewProducts.BestFitColumns()

            'fill drow down product name again
            With drpdwnProductName
                .DataSource = dt3
                .ValueMember = "name"
            End With
        Catch ex As Exception

        End Try



        cnn.Close()


    End Sub

    Private Sub drpdwnProductName_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles drpdwnProductName.SelectedIndexChanged
        Try
            connect2()

            cnn.Open()


            Dim dt2 As New DataTable
            cmd.Connection = cnn
            cmd.CommandText = "select * from product where name='" & drpdwnProductName.SelectedValue.ToString & "'"
            da.SelectCommand = cmd

            da.Fill(dt2)
            Dim row As DataRow


            Try
                row = dt2.Rows(0)
            Catch ex As Exception

            End Try


            Try
                txtprice.Text = row.Item("price")
            Catch ex As Exception
                txtprice.Text = "Not Provided"
            End Try
            cnn.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub WindowsUIButtonPanel3_Click(sender As Object, e As EventArgs) Handles WindowsUIButtonPanel3.Click
        PrintProductDetail.Show()

    End Sub

    Private Sub txtprice_OnValueChanged(sender As Object, e As EventArgs) Handles txtprice.OnValueChanged, txtPriceUpdate.OnValueChanged

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtPriceUpdate.Text = "" Then
        Else

            Dim name As String = drpdwnProductName.SelectedValue.ToString
            connection()
            Try

                rs.Open("UPDATE product SET price='" & txtPriceUpdate.Text & "' WHERE name='" & name & "'", cn)

            Catch ex As Exception
                MessageBox.Show("Fail to Update product Price Please try again")
            End Try
            cn.Close()
            connect2()
            cnn.Open()
            Dim dt3 As New DataTable

            cmd.Connection = cnn
            cmd.CommandText = "select * from product"
            da.SelectCommand = cmd
            Try
                da.Fill(dt3)
            Catch ex As Exception
                MessageBox.Show("If you open databse someware please close it Manualy" & Environment.NewLine & "Else Application not work Correctly")
            End Try

            'fill data grid view again
            Try
                grdviewProducts.DataSource = dt3
                grdviewProducts.BestFitColumns()


            Catch ex As Exception

            End Try
            Try
                cnn.Close()
            Catch ex As Exception

            End Try

        End If



    End Sub

    Private Sub txtPriceUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceUpdate.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class