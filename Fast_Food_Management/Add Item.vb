Public Class Add_Item
    Private Sub btnaddproduct_Click(sender As Object, e As EventArgs) Handles btnaddproduct.Click
        'database connection Quiry
        If txtproname.Text = "" Then
            MessageBox.Show("Enter Any Item Name")
        ElseIf txtPrice.Text = ""
            MessageBox.Show("Enter price")
        Else
            Try
                connection()

                rs.Open("INSERT INTO product values('" & txtproname.Text & "' ,'" & txtPrice.Text & "')", cn)
                MainForm.drpdwnProductList.AddItem(txtproname.Text)
                cn.Close()
                If MessageBox.Show("Successful, Would you like to add anther product", "succsful", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Else
                    Me.Hide()
                    txtproname.Text = ""
                    txtPrice.Text = ""
                    txtproname.Focus()


                End If
            Catch ex As Exception
                MessageBox.Show("This product is already available")
            End Try


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

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()

        txtproname.Text = ""
        txtPrice.Text = ""
        txtproname.Focus()
        Try
            cnn.Close()

        Catch ex As Exception

        End Try
        Try
            cn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class