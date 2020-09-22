Public Class View_Form


    Private Sub View_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRecordDataSet.Record' table. You can move, or remove it, as needed.
        Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        Menu_Form.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        HelpView.Show()

    End Sub

    Private Sub RecordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)

    End Sub

    Private Sub btnSearchbyGroup_Click(sender As Object, e As EventArgs) Handles btnSearchbyGroup.Click

        If cmbGroupSearch.Text = "ViewAll" Then
            Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)
        ElseIf cmbGroupSearch.Text.ToString() IsNot Nothing Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, cmbGroupSearch.Text)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPDF.Show()
        'PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.RecordDataGridView.Width, Me.RecordDataGridView.Height)
        RecordDataGridView.DrawToBitmap(bm, New Rectangle(0, 0, Me.RecordDataGridView.Width, Me.RecordDataGridView.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub
End Class