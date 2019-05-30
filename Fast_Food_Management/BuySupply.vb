Public Class BuySupply
    Private Sub BuySupply_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTotalPrice.Enabled = False
        txtperunitprice.Enabled = False
        txtOrderNo.Enabled = False
        lblmess.Hide()

        Try
            datepkrOrderDate.Value = My.Computer.Clock.LocalTime

        Catch ex As Exception

        End Try

        'code for get items from data table product

        connect2()
        cnn.Open()
        Dim dt2 As New DataTable
        cmd.Connection = cnn
        cmd.CommandText = "select name,productname from supplierdata"

        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
            Dim row As DataRow

            For Each row In dt2.Rows
                drpSupplierList.AddItem(row.Item("name"))
            Next

        Catch ex As Exception

        End Try
        cnn.Close()

        'code for get order no from databse


        connect2()
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandText = "select * from itemsupplied"
        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
        Catch ex As Exception

        End Try
        Dim a As Integer = dt2.Rows.Count - 1 'this will get maximum count
        Try
            txtOrderNo.Text = dt2.Rows(a).Item("orderno").ToString
        Catch ex As Exception
            txtOrderNo.Text = 1
        End Try

        ' If a < 1 Then
        'txtOrderNo.Text = 1
        '  Else
        ' txtOrderNo.Text = (dt2.Rows(a).Item("orderno")) + 1
        '  End If







        cnn.Close()

        Try
            drpSupplierList.selectedIndex = 0
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        'quiry for database
        If txtquantity.Text = "" Then
            Try
                lblmess.Text = "Enter quantity of " & txtProductName.Text
            Catch ex As Exception

            End Try

            tmrerr.Start()
            lblmess.Show()
            txtquantity.Focus()
        Else

            Try
                connection()
                ' MessageBox.Show(txtOrderNo.Text)
                rs.Open("INSERT INTO itemsupplied values('" & txtProductName.Text & "','" & drpSupplierList.selectedValue.ToString & "','" & CInt(txtquantity.Text) & "','" & txtperunitprice.Text & "','" & CInt(txtTotalPrice.Text) & "','" & datepkrOrderDate.Value & "','" & datepkrOrderDate.Value.ToShortDateString & "','" & datepkrOrderDate.Value.ToShortTimeString & "','" & CInt(txtOrderNo.Text) & "')", cn)
                txtOrderNo.Text = CInt(txtOrderNo.Text) + 1
                txtquantity.Text = ""
                tmrerr.Start()
                lblmess.Text = "Successful"
                lblmess.Show()
                cn.Close()
            Catch ex As Exception
                lblmess.Text = "Fail to order"
                tmrerr.Start()
                lblmess.Show()
            End Try

        End If
    End Sub

    Private Sub tmrerr_Tick(sender As Object, e As EventArgs) Handles tmrerr.Tick
        lblmess.Hide()
    End Sub

    Private Sub drpdwnSupplierList_onItemSelected(sender As Object, e As EventArgs) Handles drpSupplierList.onItemSelected
        connect2()
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandText = "select productname,price from supplierdata where name='" & drpSupplierList.selectedValue & "'"
        da.SelectCommand = cmd
        Dim dt2 As New DataTable
        Try
            da.Fill(dt2)
        Catch ex As Exception
            MessageBox.Show("No such Supplier found")
        End Try

        txtperunitprice.Text = dt2.Rows(0).Item("price")
        txtProductName.Text = dt2.Rows(0).Item("productname")
        txtquantity.Text = ""

        txtquantity.Focus()

        cnn.Close()

    End Sub

    Private Sub txtquantity_OnValueChanged(sender As Object, e As EventArgs) Handles txtquantity.OnValueChanged
        If txtquantity.Text = "" Then
            txtTotalPrice.Text = ""
        ElseIf Not txtperunitprice.Text = ""

            Try
                Dim cal As Integer = CInt(txtperunitprice.Text) * CInt(txtquantity.Text)
                txtTotalPrice.Text = cal
            Catch ex As Exception

            End Try


        End If

    End Sub

    Private Sub txtquantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtquantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datepkrOrderDate.Value = My.Computer.Clock.LocalTime

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Hide()
        Dashboard.Show()
        Try
            cnn.Close()

        Catch ex As Exception

        End Try
        Try
            cn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class