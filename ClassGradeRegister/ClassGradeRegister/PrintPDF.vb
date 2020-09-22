Public Class PrintPDF
    Private Sub RecordBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RecordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)

    End Sub

    Private Sub PrintPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRecordDataSet.Record' table. You can move, or remove it, as needed.
        Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)

    End Sub


    'PrintDocument1 Sets up all the report structure.'
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim count As Integer = 0
        Dim headervar As String

        If rdGroup1.Checked Then
            headervar = rdGroup1.Text
        ElseIf rdGroup2.Checked Then
            headervar = rdGroup2.Text
        ElseIf rdGroup3.Checked Then
            headervar = rdGroup3.Text
        ElseIf rdGroup4.Checked Then
            headervar = rdGroup4.Text
        ElseIf rdGroup5.Checked Then
            headervar = rdGroup5.Text
        ElseIf rdGroup6.Checked Then
            headervar = rdGroup6.Text
        End If

        'To clear blue datagridview selected item'
        RecordDataGridView.ClearSelection()


        e.Graphics.DrawString(("" + headervar), New Font("Arial", 16), Brushes.Black, 95, 70)
        e.Graphics.DrawString(("Final Grades"), New Font("Arial", 16), Brushes.Black, 450, 70)
        e.Graphics.DrawString(("Report Date: " + DateAndTime.Now.ToString("d/M/yyyy")), New Font("Arial", 10), Brushes.Black, 750, 80)

        Dim height As Integer = RecordDataGridView.Height()

        RecordDataGridView.Height = RecordDataGridView.RowCount * RecordDataGridView.RowTemplate.Height * 2
        Dim bm As New Bitmap(Me.RecordDataGridView.Width, Me.RecordDataGridView.Height)
        RecordDataGridView.DrawToBitmap(bm, New Rectangle(0, 0, Me.RecordDataGridView.Width, Me.RecordDataGridView.Height))
        e.Graphics.DrawImage(bm, 100, 100)

        RecordDataGridView.Height = height

    End Sub


    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub



    'Button for creating and displaying preview of the PDF before printing.'
    Private Sub btnPreviewPdf_Click(sender As Object, e As EventArgs) Handles btnPreviewPdf.Click

        Dim count As Integer = 0

        If rdGroup1.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup1.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#1 Does not exist")
            End If

        ElseIf rdGroup2.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup2.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#2 Does not exist")
            End If

        ElseIf rdGroup3.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup3.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#3 Does not exist")
            End If

        ElseIf rdGroup4.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup4.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#4 Does not exist")
            End If

        ElseIf rdGroup5.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup5.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#5 Does not exist")
            End If

        ElseIf rdGroup6.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup6.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#6 Does not exist")
            End If

        Else
            MessageBox.Show("Please Select a Group")

        End If

        If count > 0 Then
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
            count = 0
        End If

    End Sub


    'Button For creating a PDF'
    Private Sub btnCreatePdf_Click(sender As Object, e As EventArgs) Handles btnCreatePdf.Click

        Dim count As Integer = 0

        If rdGroup1.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup1.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#1 Does not exist")
            End If

        ElseIf rdGroup2.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup2.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#2 Does not exist")
            End If

        ElseIf rdGroup3.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup3.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#3 Does not exist")
            End If

        ElseIf rdGroup4.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup4.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#4 Does not exist")
            End If

        ElseIf rdGroup5.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup5.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#5 Does not exist")
            End If

        ElseIf rdGroup6.Checked Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, rdGroup6.Text)
            If RecordDataGridView.RowCount > 0 Then
                count = 1
            Else
                MessageBox.Show("Group#6 Does not exist")
            End If

        Else
            MessageBox.Show("Please Select a Group")

        End If

        If count > 0 Then
            PrintDocument1.DefaultPageSettings.Landscape = True
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class