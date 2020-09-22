Public Class Grade_Form

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        Select Case MsgBox("Would you like to SaveAll and updateGrades (Just in case)", MsgBoxStyle.YesNo, "Back to Menu")
            Case MsgBoxResult.Yes
                'To save'
                Me.Validate()
                Me.RecordBindingSource1.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)
                'Set totalQuiz,max and get the Percentage grade.'
                RecordTableAdapter.UpdateSetTOTALQUIZPOINTS()
                RecordTableAdapter.UpdateSetTOTALQUIZMAXPOINTS()
                RecordTableAdapter.UpdateSetTOTALQUIZES()
                'Set totalExam,max and get the Percentage grade.'
                RecordTableAdapter.UpdateSetTOTALEXAMPOINTS()
                RecordTableAdapter.UpdateSetTOTALEXAMMAXPOINTS()
                RecordTableAdapter.UpdateSetTOTALEXAMS()
                'Set totalProyect,max and get the Percentage grade.'
                RecordTableAdapter.UpdateSetTOTALPROYECTPOINTS()
                RecordTableAdapter.UpdateSetTOTALPROYECTMAXPOINTS()
                RecordTableAdapter.UpdateSetTOTALPROYECTS()
                Menu_Form.Show()
                Me.Close()
                MessageBox.Show("Data saved and Grades updated")

            Case MsgBoxResult.No
                Menu_Form.Show()
                Me.Close()
        End Select


    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        HelpGrades.Show()

    End Sub


    'Load all the records when the program starts.'
    Private Sub Grade_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)
    End Sub

    'Saving button'
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.RecordBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)
        MessageBox.Show("Data Saved")
    End Sub

    'Search groud button, also saves,just incase.'
    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click

        'Save just in case.'
        Me.Validate()
        Me.RecordBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentRecordDataSet)

        If cmbGroupSearch.Text = "ViewAll" Then
            Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)
        ElseIf cmbGroupSearch.Text.ToString() IsNot Nothing Then
            Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, cmbGroupSearch.Text)
        End If



    End Sub

    'Set max grades'
    Private Sub btnSetMax_Click(sender As Object, e As EventArgs) Handles btnSetMax.Click

        Try

            Dim cmbGroup As String = cmbGroupSearch.Text

            Select Case MsgBox("By pressing yes you will set all the max values for the group selected in the combobox." +
            "Are you sure you want to Set Max Values to: " + cmbGroupSearch.Text, MsgBoxStyle.YesNo, "Set Max Grade Value")
                Case MsgBoxResult.Yes

                    'Set MaxGrades and Dates'
                    'MaxQuiz'
                    If String.IsNullOrEmpty(Quiz_1MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateQuerySetQuiz1Max(Quiz_1MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Quiz_2MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateQuerySetQuiz2Max(Quiz_2MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Quiz_3MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateQuerySetQuiz3Max(Quiz_3MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Quiz_4MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateQuerySetQuiz4Max(Quiz_4MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Quiz_5MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateQuerySetQuiz5Max(Quiz_5MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Quiz_6MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateQuerySetQuiz6Max(Quiz_6MaxTextBox.Text, cmbGroup)
                    End If

                    'QuizDates'
                    If String.IsNullOrEmpty(DateQuiz_1DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateQuiz1(DateQuiz_1DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateQuiz_2DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateQuiz2(DateQuiz_2DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateQuiz_3DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateQuiz3(DateQuiz_3DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateQuiz_4DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateQuiz4(DateQuiz_4DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateQuiz_5DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateQuiz5(DateQuiz_5DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateQuiz_6DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateQuiz6(DateQuiz_6DateTimePicker.Text, cmbGroup)
                    End If

                    'ExamMax'

                    If String.IsNullOrEmpty(Exam_1MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateSetExam1Max(Exam_1MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Exam_2MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateSetExam2Max(Exam_2MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Exam_3MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateSetExam3Max(Exam_3MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Exam_4MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateSetExam4Max(Exam_4MaxTextBox.Text, cmbGroup)
                    End If

                    'ExamDates'
                    If String.IsNullOrEmpty(DateExam_1DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateExam1(DateExam_1DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateExam_2DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateExam2(DateExam_2DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateExam_3DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateExam3(DateExam_3DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateExam_4DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetDateExam4(DateExam_4DateTimePicker.Text, cmbGroup)
                    End If

                    'ProyectMax'

                    If String.IsNullOrEmpty(Proyect_1MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateSetProy1Max(Proyect_1MaxTextBox.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(Proyect_2MaxTextBox.Text) = False Then
                        RecordTableAdapter.UpdateSetProy2Max(Proyect_2MaxTextBox.Text, cmbGroup)
                    End If

                    'ProyectDates'
                    If String.IsNullOrEmpty(DateProyect_1DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetProyDate1(DateProyect_1DateTimePicker.Text, cmbGroup)
                    End If
                    If String.IsNullOrEmpty(DateProyect_2DateTimePicker.Text) = False Then
                        RecordTableAdapter.UpdateSetProyDate2(DateProyect_2DateTimePicker.Text, cmbGroup)
                    End If

                    'Refresh Gridview'
                    Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)
                    Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, cmbGroup)
                Case MsgBoxResult.No
            End Select

        Catch ex As Exception
            MessageBox.Show("Error while saving, make sure the max values are typed correctly.")
            End Try

    End Sub

    Private Sub btnSetGrades_Click(sender As Object, e As EventArgs) Handles btnSetGrades.Click
        Dim cmbGroup As String = cmbGroupSearch.Text

        'Set totalQuiz,max and get the Percentage grade.'
        RecordTableAdapter.UpdateSetTOTALQUIZPOINTS()
        RecordTableAdapter.UpdateSetTOTALQUIZMAXPOINTS()
        RecordTableAdapter.UpdateSetTOTALQUIZES()

        'Set totalExam,max and get the Percentage grade.'
        RecordTableAdapter.UpdateSetTOTALEXAMPOINTS()
        RecordTableAdapter.UpdateSetTOTALEXAMMAXPOINTS()
        RecordTableAdapter.UpdateSetTOTALEXAMS()

        'Set totalProyect,max and get the Percentage grade.'
        RecordTableAdapter.UpdateSetTOTALPROYECTPOINTS()
        RecordTableAdapter.UpdateSetTOTALPROYECTMAXPOINTS()
        RecordTableAdapter.UpdateSetTOTALPROYECTS()

        'Refresh Gridview'
        Me.RecordTableAdapter.Fill(Me.StudentRecordDataSet.Record)
        Me.RecordTableAdapter.FillBySearchGroupGrade(Me.StudentRecordDataSet.Record, cmbGroup)
    End Sub


End Class