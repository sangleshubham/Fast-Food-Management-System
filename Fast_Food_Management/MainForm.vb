Public Class MainForm
    Public nm As String
    Public Sub reloadthemainfor()
        connect2()
        cnn.Open()
        Dim dt3 As New DataTable
        cmd.Connection = cnn
        cmd.CommandText = "select name,price from product'"

        da.SelectCommand = cmd
        Try
            da.Fill(dt3)
            Dim row As DataRow
            For Each row In dt3.Rows
                drpdwnProductList.AddItem(row.Item("name"))
            Next

        Catch ex As Exception

        End Try
        'code for get order no from databse
        cnn.Close()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdCash.Select()
        txtTotalPrice.Enabled = False
        txtperunitprice.Enabled = False
        txtOrderNo.Enabled = False
        lblmess.Hide()
        datepkrOrderDate.Value = My.Computer.Clock.LocalTime
        datepkrOrderDate.Enabled = False



        'code for get items from data table product
        connect2()
        cnn.Open()
        Dim dt2 As New DataTable
        cmd.Connection = cnn
        cmd.CommandText = "select name,price from product'"

        da.SelectCommand = cmd
        Try
            da.Fill(dt2)
            Dim row As DataRow
            For Each row In dt2.Rows
                drpdwnProductList.AddItem(row.Item("name"))
            Next

        Catch ex As Exception

        End Try
        'code for get order no from databse
        cnn.Close()
        connect2()
        cnn.Open()
        cmd.Connection = cnn
        cmd.CommandText = "select orderno from productdata"
        da.SelectCommand = cmd

        da.Fill(dt2)

        Dim a As Integer = dt2.Rows.Count - 1 'this will get maximum count
        Dim b As Integer
        Try
            b = (dt2.Rows(a).Item("orderno")) + 1 'this will get count's order no
        Catch ex As Exception
            b = 1
        End Try

        txtOrderNo.Text = b
        cnn.Close()

        connect2()
        cnn.Open()

        Dim dt3 As New DataTable
        cmd.Connection = cnn
        cmd.CommandText = "select * from userinfo where username='" & Login.loginname & "'"
        da.SelectCommand = cmd

        da.Fill(dt3)
        Try
            nm = dt3.Rows(0).Item("name")
            lblUserName.Text = "User Login : " & dt3.Rows(0).Item("name").ToString.ToUpper
        Catch ex As Exception
            MessageBox.Show("User name is not specified")
            lblUserName.Text = "No Name"
        End Try

        Try
            picUser.BackgroundImage = System.Drawing.Image.FromFile(dt3.Rows(0).Item("imagepath"))
        Catch ex As Exception
            MessageBox.Show("Image of the user is not found")
            Try
                Dim path As String = Application.StartupPath & "\userimg\Default.jpg"
                picUser.BackgroundImage = System.Drawing.Image.FromFile(path)
            Catch ex2 As Exception

            End Try

        End Try

        cnn.Close()
        drpdwnProductList.selectedIndex = 0
        Timer1.Start()

    End Sub
    Private Sub GetUserName()

    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

        Add_Item.Show()
        Add_Item.txtproname.Focus()

    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        'quiry for database
        If txtquantity.Text = "" Then
            lblmess.Text = "Enter quantity of " & drpdwnProductList.selectedValue
            tmrerr.Start()
            lblmess.Show()
            txtquantity.Focus()
        Else
            Dim pay As String = ""
            If rdCash.IsChecked = True Then
                pay = rdCash.Text.ToString
            Else
                pay = rdPaytm.Text.ToString
                Hide()
                PayTMPay.Show()

            End If
            Try
                connection()
                Dim mon As String = datepkrOrderDate.Value.Month
                Dim year As String = datepkrOrderDate.Value.Year
                Dim cldate As String = mon & "-" & year
                rs.Open("INSERT INTO productdata (itemname,quantity,totalprice,orderdate,username,mondate,payment) values('" & drpdwnProductList.selectedValue.ToString & "','" & txtquantity.Text & "','" & txtTotalPrice.Text & "','" & datepkrOrderDate.Value & "','" & nm & "','" & cldate.ToString & "','" & pay & "')", cn)
                txtOrderNo.Text = txtOrderNo.Text + 1
                rs.Open("INSERT INTO dailyrecord values('" & txtOrderNo.Text & "','" & drpdwnProductList.selectedValue & "','" & txtquantity.Text & "','" & txtTotalPrice.Text & "','" & datepkrOrderDate.Value.ToShortDateString & "','" & datepkrOrderDate.Value.ToShortTimeString & "','" & datepkrOrderDate.Value & "','" & pay & "')", cn)



                lblmess.Text = "Successful"
                txtquantity.Text = ""
                tmrerr.Start()
                lblmess.Show()
                cn.Close()
            Catch ex As Exception
                lblmess.Text = "Fail to order"
                tmrerr.Start()
                lblmess.Show()
            End Try

        End If
        rdCash.Select()


    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
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

    Private Sub drpdwnProductList_onItemSelected(sender As Object, e As EventArgs) Handles drpdwnProductList.onItemSelected
        If drpdwnProductList.selectedValue = "Vadapav" Then
            txtperunitprice.Text = 10
            txtquantity.Text = ""
            txtquantity.Focus()
        ElseIf drpdwnProductList.selectedValue = "Pani-Pauch" Then
            txtperunitprice.Text = 2
            txtquantity.Text = ""
            txtquantity.Focus()
        ElseIf drpdwnProductList.selectedValue = "Bottel" Then
            txtperunitprice.Text = 15
            txtquantity.Text = ""
            txtquantity.Focus()
        Else

            connect2()
            cnn.Open()
            cmd.Connection = cnn
            cmd.CommandText = "select price from product where name ='" & drpdwnProductList.selectedValue & "'"

            da.SelectCommand = cmd
            Dim dt2 As New DataTable
            Try
                da.Fill(dt2)
            Catch ex As Exception
                MessageBox.Show("No such product found")
            End Try

            txtperunitprice.Text = dt2.Rows(0).Item("price")
            txtquantity.Text = ""
            txtquantity.Focus()

            cnn.Close()

        End If
    End Sub

    Private Sub txtquantity_OnValueChanged(sender As Object, e As EventArgs) Handles txtquantity.OnValueChanged

        If txtquantity.Text = "" Then
            txtTotalPrice.Text = ""
        Else
            Try
                Dim cal As Integer = CInt(txtperunitprice.Text) * CInt(txtquantity.Text)
                txtTotalPrice.Text = cal
            Catch ex As Exception

            End Try


        End If
    End Sub

    Private Sub tmrerr_Tick(sender As Object, e As EventArgs) Handles tmrerr.Tick
        lblmess.Hide()
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

    Private Sub picUser_Click(sender As Object, e As EventArgs) Handles picUser.Click

    End Sub

    Private Sub txtquantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtquantity.KeyDown

    End Sub
End Class