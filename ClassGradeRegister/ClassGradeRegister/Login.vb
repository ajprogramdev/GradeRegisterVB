Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRecordDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.StudentRecordDataSet.Login)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Me.LoginTableAdapter.FillByUserANDPw(Me.StudentRecordDataSet.Login, txtusername.Text, txtpassword.Text)
        If LoginDataGridView.RowCount > 0 Then
            Menu_Form.Show()
            Me.Hide()
            txtusername.Clear()
            txtpassword.Clear()
            MessageBox.Show("Login Successful")
        Else
            MessageBox.Show("Username or password does not exist")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class