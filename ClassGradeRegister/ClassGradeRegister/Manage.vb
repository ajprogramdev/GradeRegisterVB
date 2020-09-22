Public Class Manage_Form
    'Exit button'
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        Select Case MsgBox("Would you like to save everything (just in case) before exit? ", MsgBoxStyle.YesNo, "Exit")
            Case MsgBoxResult.Yes
                MessageBox.Show("All data saved.")
                Me.Validate()
                Me.RecordBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)
            Case MsgBoxResult.No
        End Select

        Menu_Form.Show()
        Me.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        HelpManage.Show()

    End Sub

    Private Sub RecordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)

    End Sub

    Private Sub Manage_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRecordDataSet.Record' table. You can move, or remove it, as needed.
        Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Select Case MsgBox("Are you sure you want to delete this record? ", MsgBoxStyle.YesNo, "Delete")
            Case MsgBoxResult.Yes
                Me.RecordBindingSource.RemoveCurrent()
                MessageBox.Show("record deleted")
                lblMessage.ResetText()
            Case MsgBoxResult.No
                lblMessage.ResetText()
        End Select

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Me.Validate()
            Me.RecordBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)
            lblMessage.Text = "Data Saved"
        Catch ex As Exception

            Select Case MsgBox("An Empty row or Unfinished row, cant be saved. Would you like to delete this row and SaveAll?", MsgBoxStyle.YesNo, "Empty row,unfinished row error")
                Case MsgBoxResult.Yes
                    Me.RecordBindingSource.RemoveCurrent()
                    Me.Validate()
                    Me.RecordBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)
                    MessageBox.Show("Saved.")
                    lblMessage.ResetText()
                Case MsgBoxResult.No
            End Select
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Me.RecordBindingSource.AddNew()
            lblMessage.Text = "Adding new Student..."
        Catch ex As Exception

            Select Case MsgBox("Last record form was left unfinished, would you like to delete it and add a new record?", MsgBoxStyle.YesNo, "Unfinished record error")
                Case MsgBoxResult.Yes
                    Me.RecordBindingSource.RemoveCurrent()
                    Me.RecordBindingSource.AddNew()
                    lblMessage.Text = "Adding new Student..."
                Case MsgBoxResult.No
            End Select

        End Try

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If cmbGroupSearch.Text = "ViewAll" Then
            Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)
        ElseIf cmbGroupSearch.Text.ToString() IsNot Nothing Then
            Me.RecordTableAdapter.FillBySearchGroupAdd(Me.StudentRecordDataSet.Record, cmbGroupSearch.Text)
        End If

    End Sub
End Class