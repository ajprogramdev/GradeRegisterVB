Public Class Menu_Form
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnManageGrades_Click(sender As Object, e As EventArgs) Handles btnManageGrades.Click
        Grade_Form.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Form.Show()
        Me.Hide()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help_Form.Show()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        View_Form.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Select Case MsgBox("Are you sure you want to Exit? ", MsgBoxStyle.YesNo, "Exit")
            Case MsgBoxResult.Yes
                Login.Show()
                Me.Close()
            Case MsgBoxResult.No

        End Select

    End Sub
End Class
