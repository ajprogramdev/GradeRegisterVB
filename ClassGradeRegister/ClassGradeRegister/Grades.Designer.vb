<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grade_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Quiz_1Label As System.Windows.Forms.Label
        Dim Quiz_2Label As System.Windows.Forms.Label
        Dim Quiz_3Label As System.Windows.Forms.Label
        Dim Quiz_4Label As System.Windows.Forms.Label
        Dim Quiz_5Label As System.Windows.Forms.Label
        Dim Quiz_6Label As System.Windows.Forms.Label
        Dim Exam_1Label As System.Windows.Forms.Label
        Dim Exam_2Label As System.Windows.Forms.Label
        Dim Exam_3Label As System.Windows.Forms.Label
        Dim Exam_4Label As System.Windows.Forms.Label
        Dim Proyect_1Label As System.Windows.Forms.Label
        Dim Proyect_2Label As System.Windows.Forms.Label
        Dim Quiz_1MaxLabel As System.Windows.Forms.Label
        Dim DateQuiz_1Label As System.Windows.Forms.Label
        Dim Quiz_2MaxLabel As System.Windows.Forms.Label
        Dim DateQuiz_2Label As System.Windows.Forms.Label
        Dim DateQuiz_3Label As System.Windows.Forms.Label
        Dim Quiz_3MaxLabel As System.Windows.Forms.Label
        Dim Quiz_4MaxLabel As System.Windows.Forms.Label
        Dim Quiz_5MaxLabel As System.Windows.Forms.Label
        Dim DateQuiz_4Label As System.Windows.Forms.Label
        Dim Quiz_6MaxLabel As System.Windows.Forms.Label
        Dim DateQuiz_5Label As System.Windows.Forms.Label
        Dim DateQuiz_6Label As System.Windows.Forms.Label
        Dim Exam_1MaxLabel As System.Windows.Forms.Label
        Dim DateExam_1Label As System.Windows.Forms.Label
        Dim Exam_2MaxLabel As System.Windows.Forms.Label
        Dim DateExam_2Label As System.Windows.Forms.Label
        Dim Exam_3MaxLabel As System.Windows.Forms.Label
        Dim Exam_4MaxLabel As System.Windows.Forms.Label
        Dim DateExam_4Label As System.Windows.Forms.Label
        Dim DateExam_3Label As System.Windows.Forms.Label
        Dim Proyect_1MaxLabel As System.Windows.Forms.Label
        Dim Proyect_2MaxLabel As System.Windows.Forms.Label
        Dim DateProyect_2Label As System.Windows.Forms.Label
        Dim DateProyect_1Label As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.Quiz_1TextBox = New System.Windows.Forms.TextBox()
        Me.RecordBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentRecordDataSet = New ClassGradeRegister.StudentRecordDataSet()
        Me.Quiz_2TextBox = New System.Windows.Forms.TextBox()
        Me.Quiz_3TextBox = New System.Windows.Forms.TextBox()
        Me.Quiz_4TextBox = New System.Windows.Forms.TextBox()
        Me.Quiz_5TextBox = New System.Windows.Forms.TextBox()
        Me.Quiz_6TextBox = New System.Windows.Forms.TextBox()
        Me.Exam_1TextBox = New System.Windows.Forms.TextBox()
        Me.Exam_2TextBox = New System.Windows.Forms.TextBox()
        Me.Exam_3TextBox = New System.Windows.Forms.TextBox()
        Me.Exam_4TextBox = New System.Windows.Forms.TextBox()
        Me.Proyect_1TextBox = New System.Windows.Forms.TextBox()
        Me.Proyect_2TextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Quiz_1MaxTextBox = New System.Windows.Forms.TextBox()
        Me.DateQuiz_1DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Quiz_2MaxTextBox = New System.Windows.Forms.TextBox()
        Me.DateQuiz_2DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateQuiz_3DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Quiz_3MaxTextBox = New System.Windows.Forms.TextBox()
        Me.Quiz_4MaxTextBox = New System.Windows.Forms.TextBox()
        Me.Quiz_5MaxTextBox = New System.Windows.Forms.TextBox()
        Me.DateQuiz_4DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Quiz_6MaxTextBox = New System.Windows.Forms.TextBox()
        Me.DateQuiz_5DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateQuiz_6DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Exam_1MaxTextBox = New System.Windows.Forms.TextBox()
        Me.DateExam_1DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Exam_2MaxTextBox = New System.Windows.Forms.TextBox()
        Me.DateExam_2DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Exam_3MaxTextBox = New System.Windows.Forms.TextBox()
        Me.Exam_4MaxTextBox = New System.Windows.Forms.TextBox()
        Me.DateExam_4DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateExam_3DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Proyect_1MaxTextBox = New System.Windows.Forms.TextBox()
        Me.Proyect_2MaxTextBox = New System.Windows.Forms.TextBox()
        Me.DateProyect_2DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateProyect_1DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.cmbGroupSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSetMax = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TOTALPROYECTMAXPOINTSLabel1 = New System.Windows.Forms.Label()
        Me.TOTALPROYECTPOINTSLabel1 = New System.Windows.Forms.Label()
        Me.TOTALEXAMMAXPOINTSLabel1 = New System.Windows.Forms.Label()
        Me.TOTALEXAMPOINTSLabel1 = New System.Windows.Forms.Label()
        Me.TOTALPROYECTSLabel1 = New System.Windows.Forms.Label()
        Me.TOTALEXAMSLabel1 = New System.Windows.Forms.Label()
        Me.TOTALQUIZMAXPOINTSLabel1 = New System.Windows.Forms.Label()
        Me.TOTALQUIZPOINTSLabel1 = New System.Windows.Forms.Label()
        Me.TOTALQUIZESLabel1 = New System.Windows.Forms.Label()
        Me.btnSetGrades = New System.Windows.Forms.Button()
        Me.RecordTableAdapter = New ClassGradeRegister.StudentRecordDataSetTableAdapters.RecordTableAdapter()
        Me.TableAdapterManager = New ClassGradeRegister.StudentRecordDataSetTableAdapters.TableAdapterManager()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Quiz_1Label = New System.Windows.Forms.Label()
        Quiz_2Label = New System.Windows.Forms.Label()
        Quiz_3Label = New System.Windows.Forms.Label()
        Quiz_4Label = New System.Windows.Forms.Label()
        Quiz_5Label = New System.Windows.Forms.Label()
        Quiz_6Label = New System.Windows.Forms.Label()
        Exam_1Label = New System.Windows.Forms.Label()
        Exam_2Label = New System.Windows.Forms.Label()
        Exam_3Label = New System.Windows.Forms.Label()
        Exam_4Label = New System.Windows.Forms.Label()
        Proyect_1Label = New System.Windows.Forms.Label()
        Proyect_2Label = New System.Windows.Forms.Label()
        Quiz_1MaxLabel = New System.Windows.Forms.Label()
        DateQuiz_1Label = New System.Windows.Forms.Label()
        Quiz_2MaxLabel = New System.Windows.Forms.Label()
        DateQuiz_2Label = New System.Windows.Forms.Label()
        DateQuiz_3Label = New System.Windows.Forms.Label()
        Quiz_3MaxLabel = New System.Windows.Forms.Label()
        Quiz_4MaxLabel = New System.Windows.Forms.Label()
        Quiz_5MaxLabel = New System.Windows.Forms.Label()
        DateQuiz_4Label = New System.Windows.Forms.Label()
        Quiz_6MaxLabel = New System.Windows.Forms.Label()
        DateQuiz_5Label = New System.Windows.Forms.Label()
        DateQuiz_6Label = New System.Windows.Forms.Label()
        Exam_1MaxLabel = New System.Windows.Forms.Label()
        DateExam_1Label = New System.Windows.Forms.Label()
        Exam_2MaxLabel = New System.Windows.Forms.Label()
        DateExam_2Label = New System.Windows.Forms.Label()
        Exam_3MaxLabel = New System.Windows.Forms.Label()
        Exam_4MaxLabel = New System.Windows.Forms.Label()
        DateExam_4Label = New System.Windows.Forms.Label()
        DateExam_3Label = New System.Windows.Forms.Label()
        Proyect_1MaxLabel = New System.Windows.Forms.Label()
        Proyect_2MaxLabel = New System.Windows.Forms.Label()
        DateProyect_2Label = New System.Windows.Forms.Label()
        DateProyect_1Label = New System.Windows.Forms.Label()
        CType(Me.RecordBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Quiz_1Label
        '
        Quiz_1Label.AutoSize = True
        Quiz_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_1Label.Location = New System.Drawing.Point(27, 37)
        Quiz_1Label.Name = "Quiz_1Label"
        Quiz_1Label.Size = New System.Drawing.Size(81, 25)
        Quiz_1Label.TabIndex = 18
        Quiz_1Label.Text = "Quiz#1:"
        '
        'Quiz_2Label
        '
        Quiz_2Label.AutoSize = True
        Quiz_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_2Label.Location = New System.Drawing.Point(27, 77)
        Quiz_2Label.Name = "Quiz_2Label"
        Quiz_2Label.Size = New System.Drawing.Size(81, 25)
        Quiz_2Label.TabIndex = 19
        Quiz_2Label.Text = "Quiz#2:"
        '
        'Quiz_3Label
        '
        Quiz_3Label.AutoSize = True
        Quiz_3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_3Label.Location = New System.Drawing.Point(27, 115)
        Quiz_3Label.Name = "Quiz_3Label"
        Quiz_3Label.Size = New System.Drawing.Size(81, 25)
        Quiz_3Label.TabIndex = 20
        Quiz_3Label.Text = "Quiz#3:"
        '
        'Quiz_4Label
        '
        Quiz_4Label.AutoSize = True
        Quiz_4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_4Label.Location = New System.Drawing.Point(27, 153)
        Quiz_4Label.Name = "Quiz_4Label"
        Quiz_4Label.Size = New System.Drawing.Size(81, 25)
        Quiz_4Label.TabIndex = 21
        Quiz_4Label.Text = "Quiz#4:"
        '
        'Quiz_5Label
        '
        Quiz_5Label.AutoSize = True
        Quiz_5Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_5Label.Location = New System.Drawing.Point(27, 191)
        Quiz_5Label.Name = "Quiz_5Label"
        Quiz_5Label.Size = New System.Drawing.Size(81, 25)
        Quiz_5Label.TabIndex = 22
        Quiz_5Label.Text = "Quiz#5:"
        '
        'Quiz_6Label
        '
        Quiz_6Label.AutoSize = True
        Quiz_6Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_6Label.Location = New System.Drawing.Point(27, 233)
        Quiz_6Label.Name = "Quiz_6Label"
        Quiz_6Label.Size = New System.Drawing.Size(81, 25)
        Quiz_6Label.TabIndex = 23
        Quiz_6Label.Text = "Quiz#6:"
        '
        'Exam_1Label
        '
        Exam_1Label.AutoSize = True
        Exam_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_1Label.Location = New System.Drawing.Point(190, 38)
        Exam_1Label.Name = "Exam_1Label"
        Exam_1Label.Size = New System.Drawing.Size(90, 25)
        Exam_1Label.TabIndex = 24
        Exam_1Label.Text = "Exam#1:"
        '
        'Exam_2Label
        '
        Exam_2Label.AutoSize = True
        Exam_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_2Label.Location = New System.Drawing.Point(190, 75)
        Exam_2Label.Name = "Exam_2Label"
        Exam_2Label.Size = New System.Drawing.Size(90, 25)
        Exam_2Label.TabIndex = 25
        Exam_2Label.Text = "Exam#2:"
        '
        'Exam_3Label
        '
        Exam_3Label.AutoSize = True
        Exam_3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_3Label.Location = New System.Drawing.Point(190, 115)
        Exam_3Label.Name = "Exam_3Label"
        Exam_3Label.Size = New System.Drawing.Size(90, 25)
        Exam_3Label.TabIndex = 26
        Exam_3Label.Text = "Exam#3:"
        '
        'Exam_4Label
        '
        Exam_4Label.AutoSize = True
        Exam_4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_4Label.Location = New System.Drawing.Point(190, 157)
        Exam_4Label.Name = "Exam_4Label"
        Exam_4Label.Size = New System.Drawing.Size(90, 25)
        Exam_4Label.TabIndex = 27
        Exam_4Label.Text = "Exam#4:"
        '
        'Proyect_1Label
        '
        Proyect_1Label.AutoSize = True
        Proyect_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Proyect_1Label.Location = New System.Drawing.Point(364, 37)
        Proyect_1Label.Name = "Proyect_1Label"
        Proyect_1Label.Size = New System.Drawing.Size(106, 25)
        Proyect_1Label.TabIndex = 28
        Proyect_1Label.Text = "Proyect#1:"
        '
        'Proyect_2Label
        '
        Proyect_2Label.AutoSize = True
        Proyect_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Proyect_2Label.Location = New System.Drawing.Point(364, 80)
        Proyect_2Label.Name = "Proyect_2Label"
        Proyect_2Label.Size = New System.Drawing.Size(106, 25)
        Proyect_2Label.TabIndex = 29
        Proyect_2Label.Text = "Proyect#2:"
        '
        'Quiz_1MaxLabel
        '
        Quiz_1MaxLabel.AutoSize = True
        Quiz_1MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_1MaxLabel.Location = New System.Drawing.Point(26, 23)
        Quiz_1MaxLabel.Name = "Quiz_1MaxLabel"
        Quiz_1MaxLabel.Size = New System.Drawing.Size(138, 29)
        Quiz_1MaxLabel.TabIndex = 31
        Quiz_1MaxLabel.Text = "Quiz#1Max:"
        '
        'DateQuiz_1Label
        '
        DateQuiz_1Label.AutoSize = True
        DateQuiz_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateQuiz_1Label.Location = New System.Drawing.Point(228, 23)
        DateQuiz_1Label.Name = "DateQuiz_1Label"
        DateQuiz_1Label.Size = New System.Drawing.Size(69, 29)
        DateQuiz_1Label.TabIndex = 32
        DateQuiz_1Label.Text = "Date:"
        '
        'Quiz_2MaxLabel
        '
        Quiz_2MaxLabel.AutoSize = True
        Quiz_2MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_2MaxLabel.Location = New System.Drawing.Point(26, 61)
        Quiz_2MaxLabel.Name = "Quiz_2MaxLabel"
        Quiz_2MaxLabel.Size = New System.Drawing.Size(138, 29)
        Quiz_2MaxLabel.TabIndex = 33
        Quiz_2MaxLabel.Text = "Quiz#2Max:"
        '
        'DateQuiz_2Label
        '
        DateQuiz_2Label.AutoSize = True
        DateQuiz_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateQuiz_2Label.Location = New System.Drawing.Point(228, 63)
        DateQuiz_2Label.Name = "DateQuiz_2Label"
        DateQuiz_2Label.Size = New System.Drawing.Size(69, 29)
        DateQuiz_2Label.TabIndex = 34
        DateQuiz_2Label.Text = "Date:"
        '
        'DateQuiz_3Label
        '
        DateQuiz_3Label.AutoSize = True
        DateQuiz_3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateQuiz_3Label.Location = New System.Drawing.Point(228, 100)
        DateQuiz_3Label.Name = "DateQuiz_3Label"
        DateQuiz_3Label.Size = New System.Drawing.Size(69, 29)
        DateQuiz_3Label.TabIndex = 35
        DateQuiz_3Label.Text = "Date:"
        '
        'Quiz_3MaxLabel
        '
        Quiz_3MaxLabel.AutoSize = True
        Quiz_3MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_3MaxLabel.Location = New System.Drawing.Point(26, 98)
        Quiz_3MaxLabel.Name = "Quiz_3MaxLabel"
        Quiz_3MaxLabel.Size = New System.Drawing.Size(138, 29)
        Quiz_3MaxLabel.TabIndex = 36
        Quiz_3MaxLabel.Text = "Quiz#3Max:"
        '
        'Quiz_4MaxLabel
        '
        Quiz_4MaxLabel.AutoSize = True
        Quiz_4MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_4MaxLabel.Location = New System.Drawing.Point(26, 139)
        Quiz_4MaxLabel.Name = "Quiz_4MaxLabel"
        Quiz_4MaxLabel.Size = New System.Drawing.Size(138, 29)
        Quiz_4MaxLabel.TabIndex = 38
        Quiz_4MaxLabel.Text = "Quiz#4Max:"
        '
        'Quiz_5MaxLabel
        '
        Quiz_5MaxLabel.AutoSize = True
        Quiz_5MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_5MaxLabel.Location = New System.Drawing.Point(26, 178)
        Quiz_5MaxLabel.Name = "Quiz_5MaxLabel"
        Quiz_5MaxLabel.Size = New System.Drawing.Size(138, 29)
        Quiz_5MaxLabel.TabIndex = 39
        Quiz_5MaxLabel.Text = "Quiz#5Max:"
        '
        'DateQuiz_4Label
        '
        DateQuiz_4Label.AutoSize = True
        DateQuiz_4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateQuiz_4Label.Location = New System.Drawing.Point(228, 141)
        DateQuiz_4Label.Name = "DateQuiz_4Label"
        DateQuiz_4Label.Size = New System.Drawing.Size(69, 29)
        DateQuiz_4Label.TabIndex = 40
        DateQuiz_4Label.Text = "Date:"
        '
        'Quiz_6MaxLabel
        '
        Quiz_6MaxLabel.AutoSize = True
        Quiz_6MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Quiz_6MaxLabel.Location = New System.Drawing.Point(26, 220)
        Quiz_6MaxLabel.Name = "Quiz_6MaxLabel"
        Quiz_6MaxLabel.Size = New System.Drawing.Size(138, 29)
        Quiz_6MaxLabel.TabIndex = 41
        Quiz_6MaxLabel.Text = "Quiz#6Max:"
        '
        'DateQuiz_5Label
        '
        DateQuiz_5Label.AutoSize = True
        DateQuiz_5Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateQuiz_5Label.Location = New System.Drawing.Point(228, 180)
        DateQuiz_5Label.Name = "DateQuiz_5Label"
        DateQuiz_5Label.Size = New System.Drawing.Size(69, 29)
        DateQuiz_5Label.TabIndex = 42
        DateQuiz_5Label.Text = "Date:"
        '
        'DateQuiz_6Label
        '
        DateQuiz_6Label.AutoSize = True
        DateQuiz_6Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateQuiz_6Label.Location = New System.Drawing.Point(228, 222)
        DateQuiz_6Label.Name = "DateQuiz_6Label"
        DateQuiz_6Label.Size = New System.Drawing.Size(69, 29)
        DateQuiz_6Label.TabIndex = 43
        DateQuiz_6Label.Text = "Date:"
        '
        'Exam_1MaxLabel
        '
        Exam_1MaxLabel.AutoSize = True
        Exam_1MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_1MaxLabel.Location = New System.Drawing.Point(492, 21)
        Exam_1MaxLabel.Name = "Exam_1MaxLabel"
        Exam_1MaxLabel.Size = New System.Drawing.Size(149, 29)
        Exam_1MaxLabel.TabIndex = 44
        Exam_1MaxLabel.Text = "Exam#1Max:"
        '
        'DateExam_1Label
        '
        DateExam_1Label.AutoSize = True
        DateExam_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateExam_1Label.Location = New System.Drawing.Point(723, 16)
        DateExam_1Label.Name = "DateExam_1Label"
        DateExam_1Label.Size = New System.Drawing.Size(69, 29)
        DateExam_1Label.TabIndex = 45
        DateExam_1Label.Text = "Date:"
        '
        'Exam_2MaxLabel
        '
        Exam_2MaxLabel.AutoSize = True
        Exam_2MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_2MaxLabel.Location = New System.Drawing.Point(492, 59)
        Exam_2MaxLabel.Name = "Exam_2MaxLabel"
        Exam_2MaxLabel.Size = New System.Drawing.Size(149, 29)
        Exam_2MaxLabel.TabIndex = 46
        Exam_2MaxLabel.Text = "Exam#2Max:"
        '
        'DateExam_2Label
        '
        DateExam_2Label.AutoSize = True
        DateExam_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateExam_2Label.Location = New System.Drawing.Point(723, 59)
        DateExam_2Label.Name = "DateExam_2Label"
        DateExam_2Label.Size = New System.Drawing.Size(69, 29)
        DateExam_2Label.TabIndex = 47
        DateExam_2Label.Text = "Date:"
        '
        'Exam_3MaxLabel
        '
        Exam_3MaxLabel.AutoSize = True
        Exam_3MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_3MaxLabel.Location = New System.Drawing.Point(492, 102)
        Exam_3MaxLabel.Name = "Exam_3MaxLabel"
        Exam_3MaxLabel.Size = New System.Drawing.Size(149, 29)
        Exam_3MaxLabel.TabIndex = 48
        Exam_3MaxLabel.Text = "Exam#3Max:"
        '
        'Exam_4MaxLabel
        '
        Exam_4MaxLabel.AutoSize = True
        Exam_4MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam_4MaxLabel.Location = New System.Drawing.Point(492, 145)
        Exam_4MaxLabel.Name = "Exam_4MaxLabel"
        Exam_4MaxLabel.Size = New System.Drawing.Size(149, 29)
        Exam_4MaxLabel.TabIndex = 49
        Exam_4MaxLabel.Text = "Exam#4Max:"
        '
        'DateExam_4Label
        '
        DateExam_4Label.AutoSize = True
        DateExam_4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateExam_4Label.Location = New System.Drawing.Point(723, 140)
        DateExam_4Label.Name = "DateExam_4Label"
        DateExam_4Label.Size = New System.Drawing.Size(69, 29)
        DateExam_4Label.TabIndex = 50
        DateExam_4Label.Text = "Date:"
        '
        'DateExam_3Label
        '
        DateExam_3Label.AutoSize = True
        DateExam_3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateExam_3Label.Location = New System.Drawing.Point(723, 100)
        DateExam_3Label.Name = "DateExam_3Label"
        DateExam_3Label.Size = New System.Drawing.Size(69, 29)
        DateExam_3Label.TabIndex = 51
        DateExam_3Label.Text = "Date:"
        '
        'Proyect_1MaxLabel
        '
        Proyect_1MaxLabel.AutoSize = True
        Proyect_1MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Proyect_1MaxLabel.Location = New System.Drawing.Point(474, 183)
        Proyect_1MaxLabel.Name = "Proyect_1MaxLabel"
        Proyect_1MaxLabel.Size = New System.Drawing.Size(170, 29)
        Proyect_1MaxLabel.TabIndex = 53
        Proyect_1MaxLabel.Text = "Proyect#1Max:"
        '
        'Proyect_2MaxLabel
        '
        Proyect_2MaxLabel.AutoSize = True
        Proyect_2MaxLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Proyect_2MaxLabel.Location = New System.Drawing.Point(474, 222)
        Proyect_2MaxLabel.Name = "Proyect_2MaxLabel"
        Proyect_2MaxLabel.Size = New System.Drawing.Size(170, 29)
        Proyect_2MaxLabel.TabIndex = 54
        Proyect_2MaxLabel.Text = "Proyect#2Max:"
        '
        'DateProyect_2Label
        '
        DateProyect_2Label.AutoSize = True
        DateProyect_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateProyect_2Label.Location = New System.Drawing.Point(723, 224)
        DateProyect_2Label.Name = "DateProyect_2Label"
        DateProyect_2Label.Size = New System.Drawing.Size(69, 29)
        DateProyect_2Label.TabIndex = 55
        DateProyect_2Label.Text = "Date:"
        '
        'DateProyect_1Label
        '
        DateProyect_1Label.AutoSize = True
        DateProyect_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateProyect_1Label.Location = New System.Drawing.Point(723, 183)
        DateProyect_1Label.Name = "DateProyect_1Label"
        DateProyect_1Label.Size = New System.Drawing.Size(69, 29)
        DateProyect_1Label.TabIndex = 56
        DateProyect_1Label.Text = "Date:"
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(1348, 762)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(172, 47)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Back to Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(1371, 37)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(75, 37)
        Me.btnHelp.TabIndex = 2
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'Quiz_1TextBox
        '
        Me.Quiz_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#1", True))
        Me.Quiz_1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_1TextBox.Location = New System.Drawing.Point(114, 37)
        Me.Quiz_1TextBox.Name = "Quiz_1TextBox"
        Me.Quiz_1TextBox.Size = New System.Drawing.Size(43, 30)
        Me.Quiz_1TextBox.TabIndex = 19
        '
        'RecordBindingSource1
        '
        Me.RecordBindingSource1.DataMember = "Record"
        Me.RecordBindingSource1.DataSource = Me.StudentRecordDataSet
        '
        'StudentRecordDataSet
        '
        Me.StudentRecordDataSet.DataSetName = "StudentRecordDataSet"
        Me.StudentRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Quiz_2TextBox
        '
        Me.Quiz_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#2", True))
        Me.Quiz_2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_2TextBox.Location = New System.Drawing.Point(113, 77)
        Me.Quiz_2TextBox.Name = "Quiz_2TextBox"
        Me.Quiz_2TextBox.Size = New System.Drawing.Size(43, 30)
        Me.Quiz_2TextBox.TabIndex = 20
        '
        'Quiz_3TextBox
        '
        Me.Quiz_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#3", True))
        Me.Quiz_3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_3TextBox.Location = New System.Drawing.Point(113, 115)
        Me.Quiz_3TextBox.Name = "Quiz_3TextBox"
        Me.Quiz_3TextBox.Size = New System.Drawing.Size(43, 30)
        Me.Quiz_3TextBox.TabIndex = 21
        '
        'Quiz_4TextBox
        '
        Me.Quiz_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#4", True))
        Me.Quiz_4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_4TextBox.Location = New System.Drawing.Point(114, 153)
        Me.Quiz_4TextBox.Name = "Quiz_4TextBox"
        Me.Quiz_4TextBox.Size = New System.Drawing.Size(43, 30)
        Me.Quiz_4TextBox.TabIndex = 22
        '
        'Quiz_5TextBox
        '
        Me.Quiz_5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#5", True))
        Me.Quiz_5TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_5TextBox.Location = New System.Drawing.Point(113, 191)
        Me.Quiz_5TextBox.Name = "Quiz_5TextBox"
        Me.Quiz_5TextBox.Size = New System.Drawing.Size(43, 30)
        Me.Quiz_5TextBox.TabIndex = 23
        '
        'Quiz_6TextBox
        '
        Me.Quiz_6TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#6", True))
        Me.Quiz_6TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_6TextBox.Location = New System.Drawing.Point(113, 233)
        Me.Quiz_6TextBox.Name = "Quiz_6TextBox"
        Me.Quiz_6TextBox.Size = New System.Drawing.Size(43, 30)
        Me.Quiz_6TextBox.TabIndex = 24
        '
        'Exam_1TextBox
        '
        Me.Exam_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Exam#1", True))
        Me.Exam_1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_1TextBox.Location = New System.Drawing.Point(286, 38)
        Me.Exam_1TextBox.Name = "Exam_1TextBox"
        Me.Exam_1TextBox.Size = New System.Drawing.Size(41, 30)
        Me.Exam_1TextBox.TabIndex = 25
        '
        'Exam_2TextBox
        '
        Me.Exam_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Exam#2", True))
        Me.Exam_2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_2TextBox.Location = New System.Drawing.Point(286, 75)
        Me.Exam_2TextBox.Name = "Exam_2TextBox"
        Me.Exam_2TextBox.Size = New System.Drawing.Size(41, 30)
        Me.Exam_2TextBox.TabIndex = 26
        '
        'Exam_3TextBox
        '
        Me.Exam_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Exam#3", True))
        Me.Exam_3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_3TextBox.Location = New System.Drawing.Point(286, 115)
        Me.Exam_3TextBox.Name = "Exam_3TextBox"
        Me.Exam_3TextBox.Size = New System.Drawing.Size(41, 30)
        Me.Exam_3TextBox.TabIndex = 27
        '
        'Exam_4TextBox
        '
        Me.Exam_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Exam#4", True))
        Me.Exam_4TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_4TextBox.Location = New System.Drawing.Point(286, 157)
        Me.Exam_4TextBox.Name = "Exam_4TextBox"
        Me.Exam_4TextBox.Size = New System.Drawing.Size(41, 30)
        Me.Exam_4TextBox.TabIndex = 28
        '
        'Proyect_1TextBox
        '
        Me.Proyect_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Proyect#1", True))
        Me.Proyect_1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proyect_1TextBox.Location = New System.Drawing.Point(476, 34)
        Me.Proyect_1TextBox.Name = "Proyect_1TextBox"
        Me.Proyect_1TextBox.Size = New System.Drawing.Size(42, 30)
        Me.Proyect_1TextBox.TabIndex = 29
        '
        'Proyect_2TextBox
        '
        Me.Proyect_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Proyect#2", True))
        Me.Proyect_2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proyect_2TextBox.Location = New System.Drawing.Point(476, 77)
        Me.Proyect_2TextBox.Name = "Proyect_2TextBox"
        Me.Proyect_2TextBox.Size = New System.Drawing.Size(42, 30)
        Me.Proyect_2TextBox.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.Quiz_3TextBox)
        Me.GroupBox1.Controls.Add(Proyect_2Label)
        Me.GroupBox1.Controls.Add(Me.Quiz_1TextBox)
        Me.GroupBox1.Controls.Add(Me.Proyect_2TextBox)
        Me.GroupBox1.Controls.Add(Quiz_1Label)
        Me.GroupBox1.Controls.Add(Proyect_1Label)
        Me.GroupBox1.Controls.Add(Me.Quiz_2TextBox)
        Me.GroupBox1.Controls.Add(Me.Proyect_1TextBox)
        Me.GroupBox1.Controls.Add(Quiz_2Label)
        Me.GroupBox1.Controls.Add(Exam_4Label)
        Me.GroupBox1.Controls.Add(Quiz_3Label)
        Me.GroupBox1.Controls.Add(Me.Exam_4TextBox)
        Me.GroupBox1.Controls.Add(Me.Quiz_4TextBox)
        Me.GroupBox1.Controls.Add(Exam_3Label)
        Me.GroupBox1.Controls.Add(Quiz_4Label)
        Me.GroupBox1.Controls.Add(Me.Exam_3TextBox)
        Me.GroupBox1.Controls.Add(Me.Quiz_5TextBox)
        Me.GroupBox1.Controls.Add(Exam_2Label)
        Me.GroupBox1.Controls.Add(Quiz_5Label)
        Me.GroupBox1.Controls.Add(Me.Exam_2TextBox)
        Me.GroupBox1.Controls.Add(Me.Quiz_6TextBox)
        Me.GroupBox1.Controls.Add(Exam_1Label)
        Me.GroupBox1.Controls.Add(Quiz_6Label)
        Me.GroupBox1.Controls.Add(Me.Exam_1TextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(531, 294)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'Quiz_1MaxTextBox
        '
        Me.Quiz_1MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#1Max", True))
        Me.Quiz_1MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_1MaxTextBox.Location = New System.Drawing.Point(180, 20)
        Me.Quiz_1MaxTextBox.Name = "Quiz_1MaxTextBox"
        Me.Quiz_1MaxTextBox.Size = New System.Drawing.Size(42, 34)
        Me.Quiz_1MaxTextBox.TabIndex = 32
        '
        'DateQuiz_1DateTimePicker
        '
        Me.DateQuiz_1DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_1DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateQuiz#1", True))
        Me.DateQuiz_1DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateQuiz_1DateTimePicker.Location = New System.Drawing.Point(297, 20)
        Me.DateQuiz_1DateTimePicker.Name = "DateQuiz_1DateTimePicker"
        Me.DateQuiz_1DateTimePicker.Size = New System.Drawing.Size(171, 34)
        Me.DateQuiz_1DateTimePicker.TabIndex = 33
        '
        'Quiz_2MaxTextBox
        '
        Me.Quiz_2MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#2Max", True))
        Me.Quiz_2MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_2MaxTextBox.Location = New System.Drawing.Point(180, 58)
        Me.Quiz_2MaxTextBox.Name = "Quiz_2MaxTextBox"
        Me.Quiz_2MaxTextBox.Size = New System.Drawing.Size(42, 34)
        Me.Quiz_2MaxTextBox.TabIndex = 34
        '
        'DateQuiz_2DateTimePicker
        '
        Me.DateQuiz_2DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_2DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateQuiz#2", True))
        Me.DateQuiz_2DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateQuiz_2DateTimePicker.Location = New System.Drawing.Point(297, 58)
        Me.DateQuiz_2DateTimePicker.Name = "DateQuiz_2DateTimePicker"
        Me.DateQuiz_2DateTimePicker.Size = New System.Drawing.Size(171, 34)
        Me.DateQuiz_2DateTimePicker.TabIndex = 35
        '
        'DateQuiz_3DateTimePicker
        '
        Me.DateQuiz_3DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_3DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateQuiz#3", True))
        Me.DateQuiz_3DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_3DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateQuiz_3DateTimePicker.Location = New System.Drawing.Point(297, 98)
        Me.DateQuiz_3DateTimePicker.Name = "DateQuiz_3DateTimePicker"
        Me.DateQuiz_3DateTimePicker.Size = New System.Drawing.Size(171, 34)
        Me.DateQuiz_3DateTimePicker.TabIndex = 36
        '
        'Quiz_3MaxTextBox
        '
        Me.Quiz_3MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#3Max", True))
        Me.Quiz_3MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_3MaxTextBox.Location = New System.Drawing.Point(180, 95)
        Me.Quiz_3MaxTextBox.Name = "Quiz_3MaxTextBox"
        Me.Quiz_3MaxTextBox.Size = New System.Drawing.Size(42, 34)
        Me.Quiz_3MaxTextBox.TabIndex = 37
        '
        'Quiz_4MaxTextBox
        '
        Me.Quiz_4MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#4Max", True))
        Me.Quiz_4MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_4MaxTextBox.Location = New System.Drawing.Point(180, 136)
        Me.Quiz_4MaxTextBox.Name = "Quiz_4MaxTextBox"
        Me.Quiz_4MaxTextBox.Size = New System.Drawing.Size(42, 34)
        Me.Quiz_4MaxTextBox.TabIndex = 39
        '
        'Quiz_5MaxTextBox
        '
        Me.Quiz_5MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#5Max", True))
        Me.Quiz_5MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_5MaxTextBox.Location = New System.Drawing.Point(180, 175)
        Me.Quiz_5MaxTextBox.Name = "Quiz_5MaxTextBox"
        Me.Quiz_5MaxTextBox.Size = New System.Drawing.Size(42, 34)
        Me.Quiz_5MaxTextBox.TabIndex = 40
        '
        'DateQuiz_4DateTimePicker
        '
        Me.DateQuiz_4DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_4DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateQuiz#4", True))
        Me.DateQuiz_4DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_4DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateQuiz_4DateTimePicker.Location = New System.Drawing.Point(297, 136)
        Me.DateQuiz_4DateTimePicker.Name = "DateQuiz_4DateTimePicker"
        Me.DateQuiz_4DateTimePicker.Size = New System.Drawing.Size(171, 34)
        Me.DateQuiz_4DateTimePicker.TabIndex = 41
        '
        'Quiz_6MaxTextBox
        '
        Me.Quiz_6MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Quiz#6Max", True))
        Me.Quiz_6MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quiz_6MaxTextBox.Location = New System.Drawing.Point(180, 217)
        Me.Quiz_6MaxTextBox.Name = "Quiz_6MaxTextBox"
        Me.Quiz_6MaxTextBox.Size = New System.Drawing.Size(42, 34)
        Me.Quiz_6MaxTextBox.TabIndex = 42
        '
        'DateQuiz_5DateTimePicker
        '
        Me.DateQuiz_5DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_5DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateQuiz#5", True))
        Me.DateQuiz_5DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_5DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateQuiz_5DateTimePicker.Location = New System.Drawing.Point(297, 175)
        Me.DateQuiz_5DateTimePicker.Name = "DateQuiz_5DateTimePicker"
        Me.DateQuiz_5DateTimePicker.Size = New System.Drawing.Size(171, 34)
        Me.DateQuiz_5DateTimePicker.TabIndex = 43
        '
        'DateQuiz_6DateTimePicker
        '
        Me.DateQuiz_6DateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_6DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateQuiz#6", True))
        Me.DateQuiz_6DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateQuiz_6DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateQuiz_6DateTimePicker.Location = New System.Drawing.Point(297, 217)
        Me.DateQuiz_6DateTimePicker.Name = "DateQuiz_6DateTimePicker"
        Me.DateQuiz_6DateTimePicker.Size = New System.Drawing.Size(171, 34)
        Me.DateQuiz_6DateTimePicker.TabIndex = 44
        '
        'Exam_1MaxTextBox
        '
        Me.Exam_1MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Exam#1Max", True))
        Me.Exam_1MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_1MaxTextBox.Location = New System.Drawing.Point(660, 19)
        Me.Exam_1MaxTextBox.Name = "Exam_1MaxTextBox"
        Me.Exam_1MaxTextBox.Size = New System.Drawing.Size(53, 34)
        Me.Exam_1MaxTextBox.TabIndex = 45
        '
        'DateExam_1DateTimePicker
        '
        Me.DateExam_1DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateExam#1", True))
        Me.DateExam_1DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExam_1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateExam_1DateTimePicker.Location = New System.Drawing.Point(798, 16)
        Me.DateExam_1DateTimePicker.Name = "DateExam_1DateTimePicker"
        Me.DateExam_1DateTimePicker.Size = New System.Drawing.Size(170, 34)
        Me.DateExam_1DateTimePicker.TabIndex = 46
        '
        'Exam_2MaxTextBox
        '
        Me.Exam_2MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Exam#2Max", True))
        Me.Exam_2MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_2MaxTextBox.Location = New System.Drawing.Point(660, 60)
        Me.Exam_2MaxTextBox.Name = "Exam_2MaxTextBox"
        Me.Exam_2MaxTextBox.Size = New System.Drawing.Size(53, 34)
        Me.Exam_2MaxTextBox.TabIndex = 47
        '
        'DateExam_2DateTimePicker
        '
        Me.DateExam_2DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateExam#2", True))
        Me.DateExam_2DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExam_2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateExam_2DateTimePicker.Location = New System.Drawing.Point(798, 59)
        Me.DateExam_2DateTimePicker.Name = "DateExam_2DateTimePicker"
        Me.DateExam_2DateTimePicker.Size = New System.Drawing.Size(170, 34)
        Me.DateExam_2DateTimePicker.TabIndex = 48
        '
        'Exam_3MaxTextBox
        '
        Me.Exam_3MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Exam#3Max", True))
        Me.Exam_3MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_3MaxTextBox.Location = New System.Drawing.Point(660, 100)
        Me.Exam_3MaxTextBox.Name = "Exam_3MaxTextBox"
        Me.Exam_3MaxTextBox.Size = New System.Drawing.Size(53, 34)
        Me.Exam_3MaxTextBox.TabIndex = 49
        '
        'Exam_4MaxTextBox
        '
        Me.Exam_4MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Exam#4Max", True))
        Me.Exam_4MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam_4MaxTextBox.Location = New System.Drawing.Point(660, 138)
        Me.Exam_4MaxTextBox.Name = "Exam_4MaxTextBox"
        Me.Exam_4MaxTextBox.Size = New System.Drawing.Size(53, 34)
        Me.Exam_4MaxTextBox.TabIndex = 50
        '
        'DateExam_4DateTimePicker
        '
        Me.DateExam_4DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "DateExam#4", True))
        Me.DateExam_4DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExam_4DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateExam_4DateTimePicker.Location = New System.Drawing.Point(798, 140)
        Me.DateExam_4DateTimePicker.Name = "DateExam_4DateTimePicker"
        Me.DateExam_4DateTimePicker.Size = New System.Drawing.Size(170, 34)
        Me.DateExam_4DateTimePicker.TabIndex = 51
        '
        'DateExam_3DateTimePicker
        '
        Me.DateExam_3DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateExam#3", True))
        Me.DateExam_3DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExam_3DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateExam_3DateTimePicker.Location = New System.Drawing.Point(798, 100)
        Me.DateExam_3DateTimePicker.Name = "DateExam_3DateTimePicker"
        Me.DateExam_3DateTimePicker.Size = New System.Drawing.Size(170, 34)
        Me.DateExam_3DateTimePicker.TabIndex = 52
        '
        'RecordBindingSource
        '
        Me.RecordBindingSource.DataMember = "Record"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Course"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Group"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Group"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quiz#1"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quiz#1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Quiz#1Max"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Quiz#1Max"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DateQuiz#1"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DateQuiz#1"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Quiz#2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Quiz#2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Quiz#2Max"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Quiz#2Max"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "DateQuiz#2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "DateQuiz#2"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Quiz#3"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Quiz#3"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Quiz#3Max"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Quiz#3Max"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "DateQuiz#3"
        Me.DataGridViewTextBoxColumn14.HeaderText = "DateQuiz#3"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Quiz#4"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Quiz#4"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Quiz#4Max"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Quiz#4Max"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "DateQuiz#4"
        Me.DataGridViewTextBoxColumn17.HeaderText = "DateQuiz#4"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Quiz#5"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Quiz#5"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Quiz#5Max"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Quiz#5Max"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "DateQuiz#5"
        Me.DataGridViewTextBoxColumn20.HeaderText = "DateQuiz#5"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Quiz#6"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Quiz#6"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Quiz#6Max"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Quiz#6Max"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "DateQuiz#6"
        Me.DataGridViewTextBoxColumn23.HeaderText = "DateQuiz#6"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Exam#1"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Exam#1"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Exam#1Max"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Exam#1Max"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "DateExam#1"
        Me.DataGridViewTextBoxColumn26.HeaderText = "DateExam#1"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Exam#2"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Exam#2"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Exam#2Max"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Exam#2Max"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "DateExam#2"
        Me.DataGridViewTextBoxColumn29.HeaderText = "DateExam#2"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Exam#3"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Exam#3"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Exam#3Max"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Exam#3Max"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "DateExam#3"
        Me.DataGridViewTextBoxColumn32.HeaderText = "DateExam#3"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Exam#4"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Exam#4"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Exam#4Max"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Exam#4Max"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "DateExam#4"
        Me.DataGridViewTextBoxColumn35.HeaderText = "DateExam#4"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Proyect#1"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Proyect#1"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Proyect#1Max"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Proyect#1Max"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "DateProyect#1"
        Me.DataGridViewTextBoxColumn38.HeaderText = "DateProyect#1"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Proyect#2"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Proyect#2"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "Proyect#2Max"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Proyect#2Max"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "DateProyect#2"
        Me.DataGridViewTextBoxColumn41.HeaderText = "DateProyect#2"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "TOTALQUIZES"
        Me.DataGridViewTextBoxColumn42.HeaderText = "TOTALQUIZES"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "TOTALEXAMS"
        Me.DataGridViewTextBoxColumn43.HeaderText = "TOTALEXAMS"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "TOTALPROYECTS"
        Me.DataGridViewTextBoxColumn44.HeaderText = "TOTALPROYECTS"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'RecordDataGridView
        '
        Me.RecordDataGridView.AllowUserToAddRows = False
        Me.RecordDataGridView.AllowUserToResizeColumns = False
        Me.RecordDataGridView.AllowUserToResizeRows = False
        Me.RecordDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecordDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.RecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.GroupDataGridViewTextBoxColumn})
        Me.RecordDataGridView.DataSource = Me.RecordBindingSource1
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecordDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.RecordDataGridView.Location = New System.Drawing.Point(36, 70)
        Me.RecordDataGridView.Name = "RecordDataGridView"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecordDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.RecordDataGridView.RowHeadersVisible = False
        Me.RecordDataGridView.RowTemplate.Height = 24
        Me.RecordDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RecordDataGridView.Size = New System.Drawing.Size(392, 444)
        Me.RecordDataGridView.TabIndex = 52
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 42
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 172
        '
        'GroupDataGridViewTextBoxColumn
        '
        Me.GroupDataGridViewTextBoxColumn.DataPropertyName = "Group"
        Me.GroupDataGridViewTextBoxColumn.HeaderText = "Group"
        Me.GroupDataGridViewTextBoxColumn.Name = "GroupDataGridViewTextBoxColumn"
        Me.GroupDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(17, 33)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 46)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "Save All"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Proyect_1MaxTextBox
        '
        Me.Proyect_1MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Proyect#1Max", True))
        Me.Proyect_1MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proyect_1MaxTextBox.Location = New System.Drawing.Point(660, 180)
        Me.Proyect_1MaxTextBox.Name = "Proyect_1MaxTextBox"
        Me.Proyect_1MaxTextBox.Size = New System.Drawing.Size(53, 34)
        Me.Proyect_1MaxTextBox.TabIndex = 54
        '
        'Proyect_2MaxTextBox
        '
        Me.Proyect_2MaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "Proyect#2Max", True))
        Me.Proyect_2MaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proyect_2MaxTextBox.Location = New System.Drawing.Point(660, 219)
        Me.Proyect_2MaxTextBox.Name = "Proyect_2MaxTextBox"
        Me.Proyect_2MaxTextBox.Size = New System.Drawing.Size(53, 34)
        Me.Proyect_2MaxTextBox.TabIndex = 55
        '
        'DateProyect_2DateTimePicker
        '
        Me.DateProyect_2DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateProyect#2", True))
        Me.DateProyect_2DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateProyect_2DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateProyect_2DateTimePicker.Location = New System.Drawing.Point(798, 222)
        Me.DateProyect_2DateTimePicker.Name = "DateProyect_2DateTimePicker"
        Me.DateProyect_2DateTimePicker.Size = New System.Drawing.Size(170, 34)
        Me.DateProyect_2DateTimePicker.TabIndex = 56
        '
        'DateProyect_1DateTimePicker
        '
        Me.DateProyect_1DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RecordBindingSource1, "DateProyect#1", True))
        Me.DateProyect_1DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateProyect_1DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateProyect_1DateTimePicker.Location = New System.Drawing.Point(798, 180)
        Me.DateProyect_1DateTimePicker.Name = "DateProyect_1DateTimePicker"
        Me.DateProyect_1DateTimePicker.Size = New System.Drawing.Size(170, 34)
        Me.DateProyect_1DateTimePicker.TabIndex = 57
        '
        'cmbGroupSearch
        '
        Me.cmbGroupSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroupSearch.FormattingEnabled = True
        Me.cmbGroupSearch.Items.AddRange(New Object() {"ViewAll", "Group#1", "Group#2", "Group#3", "Group#4", "Group#5", "Group#6"})
        Me.cmbGroupSearch.Location = New System.Drawing.Point(185, 38)
        Me.cmbGroupSearch.Name = "cmbGroupSearch"
        Me.cmbGroupSearch.Size = New System.Drawing.Size(130, 37)
        Me.cmbGroupSearch.TabIndex = 59
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(330, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(195, 45)
        Me.btnSearch.TabIndex = 60
        Me.btnSearch.Text = "Search by Group"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSetMax
        '
        Me.btnSetMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetMax.Location = New System.Drawing.Point(834, 530)
        Me.btnSetMax.Name = "btnSetMax"
        Me.btnSetMax.Size = New System.Drawing.Size(198, 47)
        Me.btnSetMax.TabIndex = 61
        Me.btnSetMax.Text = "Set Max Values"
        Me.btnSetMax.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox2.Controls.Add(Quiz_1MaxLabel)
        Me.GroupBox2.Controls.Add(DateProyect_1Label)
        Me.GroupBox2.Controls.Add(Me.Quiz_1MaxTextBox)
        Me.GroupBox2.Controls.Add(Me.DateProyect_1DateTimePicker)
        Me.GroupBox2.Controls.Add(Me.DateQuiz_1DateTimePicker)
        Me.GroupBox2.Controls.Add(DateProyect_2Label)
        Me.GroupBox2.Controls.Add(DateQuiz_1Label)
        Me.GroupBox2.Controls.Add(Me.DateProyect_2DateTimePicker)
        Me.GroupBox2.Controls.Add(Me.Quiz_2MaxTextBox)
        Me.GroupBox2.Controls.Add(Proyect_2MaxLabel)
        Me.GroupBox2.Controls.Add(Quiz_2MaxLabel)
        Me.GroupBox2.Controls.Add(Me.Proyect_2MaxTextBox)
        Me.GroupBox2.Controls.Add(Me.DateQuiz_2DateTimePicker)
        Me.GroupBox2.Controls.Add(Proyect_1MaxLabel)
        Me.GroupBox2.Controls.Add(DateQuiz_2Label)
        Me.GroupBox2.Controls.Add(Me.Proyect_1MaxTextBox)
        Me.GroupBox2.Controls.Add(Me.DateQuiz_3DateTimePicker)
        Me.GroupBox2.Controls.Add(DateQuiz_3Label)
        Me.GroupBox2.Controls.Add(Me.Quiz_3MaxTextBox)
        Me.GroupBox2.Controls.Add(DateExam_3Label)
        Me.GroupBox2.Controls.Add(Quiz_3MaxLabel)
        Me.GroupBox2.Controls.Add(Me.DateExam_3DateTimePicker)
        Me.GroupBox2.Controls.Add(Me.Quiz_4MaxTextBox)
        Me.GroupBox2.Controls.Add(DateExam_4Label)
        Me.GroupBox2.Controls.Add(Quiz_4MaxLabel)
        Me.GroupBox2.Controls.Add(Me.DateExam_4DateTimePicker)
        Me.GroupBox2.Controls.Add(Me.Quiz_5MaxTextBox)
        Me.GroupBox2.Controls.Add(Exam_4MaxLabel)
        Me.GroupBox2.Controls.Add(Quiz_5MaxLabel)
        Me.GroupBox2.Controls.Add(Me.Exam_4MaxTextBox)
        Me.GroupBox2.Controls.Add(Me.DateQuiz_4DateTimePicker)
        Me.GroupBox2.Controls.Add(Exam_3MaxLabel)
        Me.GroupBox2.Controls.Add(DateQuiz_4Label)
        Me.GroupBox2.Controls.Add(Me.Exam_3MaxTextBox)
        Me.GroupBox2.Controls.Add(Me.Quiz_6MaxTextBox)
        Me.GroupBox2.Controls.Add(DateExam_2Label)
        Me.GroupBox2.Controls.Add(Quiz_6MaxLabel)
        Me.GroupBox2.Controls.Add(Me.DateExam_2DateTimePicker)
        Me.GroupBox2.Controls.Add(Me.DateQuiz_5DateTimePicker)
        Me.GroupBox2.Controls.Add(Exam_2MaxLabel)
        Me.GroupBox2.Controls.Add(DateQuiz_5Label)
        Me.GroupBox2.Controls.Add(Me.Exam_2MaxTextBox)
        Me.GroupBox2.Controls.Add(Me.DateQuiz_6DateTimePicker)
        Me.GroupBox2.Controls.Add(DateExam_1Label)
        Me.GroupBox2.Controls.Add(DateQuiz_6Label)
        Me.GroupBox2.Controls.Add(Me.DateExam_1DateTimePicker)
        Me.GroupBox2.Controls.Add(Me.Exam_1MaxTextBox)
        Me.GroupBox2.Controls.Add(Exam_1MaxLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 567)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1017, 266)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(33, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Average Quiz score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(37, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 25)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Average Exam score:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(44, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 25)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Average Proyect score:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(41, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 25)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Total points possible:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(41, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 25)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Total points scored:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(56, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 25)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Total points possible:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(59, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 25)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Total points scored:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(69, 426)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 25)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Total points scored:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(59, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 25)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Total points possible:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel1.Controls.Add(Me.TOTALPROYECTMAXPOINTSLabel1)
        Me.Panel1.Controls.Add(Me.TOTALPROYECTPOINTSLabel1)
        Me.Panel1.Controls.Add(Me.TOTALEXAMMAXPOINTSLabel1)
        Me.Panel1.Controls.Add(Me.TOTALEXAMPOINTSLabel1)
        Me.Panel1.Controls.Add(Me.TOTALPROYECTSLabel1)
        Me.Panel1.Controls.Add(Me.TOTALEXAMSLabel1)
        Me.Panel1.Controls.Add(Me.TOTALQUIZMAXPOINTSLabel1)
        Me.Panel1.Controls.Add(Me.TOTALQUIZPOINTSLabel1)
        Me.Panel1.Controls.Add(Me.TOTALQUIZESLabel1)
        Me.Panel1.Controls.Add(Me.btnSetGrades)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(1181, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 551)
        Me.Panel1.TabIndex = 71
        '
        'TOTALPROYECTMAXPOINTSLabel1
        '
        Me.TOTALPROYECTMAXPOINTSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALPROYECTMAXPOINTS", True))
        Me.TOTALPROYECTMAXPOINTSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALPROYECTMAXPOINTSLabel1.Location = New System.Drawing.Point(261, 391)
        Me.TOTALPROYECTMAXPOINTSLabel1.Name = "TOTALPROYECTMAXPOINTSLabel1"
        Me.TOTALPROYECTMAXPOINTSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALPROYECTMAXPOINTSLabel1.TabIndex = 72
        '
        'TOTALPROYECTPOINTSLabel1
        '
        Me.TOTALPROYECTPOINTSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALPROYECTPOINTS", True))
        Me.TOTALPROYECTPOINTSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALPROYECTPOINTSLabel1.Location = New System.Drawing.Point(258, 426)
        Me.TOTALPROYECTPOINTSLabel1.Name = "TOTALPROYECTPOINTSLabel1"
        Me.TOTALPROYECTPOINTSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALPROYECTPOINTSLabel1.TabIndex = 72
        '
        'TOTALEXAMMAXPOINTSLabel1
        '
        Me.TOTALEXAMMAXPOINTSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALEXAMMAXPOINTS", True))
        Me.TOTALEXAMMAXPOINTSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALEXAMMAXPOINTSLabel1.Location = New System.Drawing.Point(258, 223)
        Me.TOTALEXAMMAXPOINTSLabel1.Name = "TOTALEXAMMAXPOINTSLabel1"
        Me.TOTALEXAMMAXPOINTSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALEXAMMAXPOINTSLabel1.TabIndex = 72
        '
        'TOTALEXAMPOINTSLabel1
        '
        Me.TOTALEXAMPOINTSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALEXAMPOINTS", True))
        Me.TOTALEXAMPOINTSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALEXAMPOINTSLabel1.Location = New System.Drawing.Point(248, 258)
        Me.TOTALEXAMPOINTSLabel1.Name = "TOTALEXAMPOINTSLabel1"
        Me.TOTALEXAMPOINTSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALEXAMPOINTSLabel1.TabIndex = 74
        '
        'TOTALPROYECTSLabel1
        '
        Me.TOTALPROYECTSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALPROYECTS", True))
        Me.TOTALPROYECTSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALPROYECTSLabel1.Location = New System.Drawing.Point(266, 351)
        Me.TOTALPROYECTSLabel1.Name = "TOTALPROYECTSLabel1"
        Me.TOTALPROYECTSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALPROYECTSLabel1.TabIndex = 72
        '
        'TOTALEXAMSLabel1
        '
        Me.TOTALEXAMSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALEXAMS", True))
        Me.TOTALEXAMSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALEXAMSLabel1.Location = New System.Drawing.Point(243, 184)
        Me.TOTALEXAMSLabel1.Name = "TOTALEXAMSLabel1"
        Me.TOTALEXAMSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALEXAMSLabel1.TabIndex = 72
        '
        'TOTALQUIZMAXPOINTSLabel1
        '
        Me.TOTALQUIZMAXPOINTSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALQUIZMAXPOINTS", True))
        Me.TOTALQUIZMAXPOINTSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALQUIZMAXPOINTSLabel1.Location = New System.Drawing.Point(243, 85)
        Me.TOTALQUIZMAXPOINTSLabel1.Name = "TOTALQUIZMAXPOINTSLabel1"
        Me.TOTALQUIZMAXPOINTSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALQUIZMAXPOINTSLabel1.TabIndex = 72
        '
        'TOTALQUIZPOINTSLabel1
        '
        Me.TOTALQUIZPOINTSLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALQUIZPOINTS", True))
        Me.TOTALQUIZPOINTSLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALQUIZPOINTSLabel1.Location = New System.Drawing.Point(243, 121)
        Me.TOTALQUIZPOINTSLabel1.Name = "TOTALQUIZPOINTSLabel1"
        Me.TOTALQUIZPOINTSLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALQUIZPOINTSLabel1.TabIndex = 73
        '
        'TOTALQUIZESLabel1
        '
        Me.TOTALQUIZESLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource1, "TOTALQUIZES", True))
        Me.TOTALQUIZESLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALQUIZESLabel1.Location = New System.Drawing.Point(230, 48)
        Me.TOTALQUIZESLabel1.Name = "TOTALQUIZESLabel1"
        Me.TOTALQUIZESLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TOTALQUIZESLabel1.TabIndex = 72
        '
        'btnSetGrades
        '
        Me.btnSetGrades.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetGrades.Location = New System.Drawing.Point(97, 471)
        Me.btnSetGrades.Name = "btnSetGrades"
        Me.btnSetGrades.Size = New System.Drawing.Size(140, 46)
        Me.btnSetGrades.TabIndex = 71
        Me.btnSetGrades.Text = "ViewGrades"
        Me.btnSetGrades.UseVisualStyleBackColor = True
        '
        'RecordTableAdapter
        '
        Me.RecordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.RecordTableAdapter = Me.RecordTableAdapter
        Me.TableAdapterManager.UpdateOrder = ClassGradeRegister.StudentRecordDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(165, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 29)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Students"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(125, 530)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(271, 29)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Set Max Grade Values"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(548, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(313, 29)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Set Student Grade Values"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.cmbGroupSearch)
        Me.Panel2.Location = New System.Drawing.Point(464, 387)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(553, 112)
        Me.Panel2.TabIndex = 75
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1176, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(331, 29)
        Me.Label13.TabIndex = 76
        Me.Label13.Text = "Average Grades and Totals"
        '
        'Grade_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1568, 870)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSetMax)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RecordDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Grade_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grades"
        CType(Me.RecordBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMenu As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents Quiz_1TextBox As TextBox
    Friend WithEvents Quiz_2TextBox As TextBox
    Friend WithEvents Quiz_3TextBox As TextBox
    Friend WithEvents Quiz_4TextBox As TextBox
    Friend WithEvents Quiz_5TextBox As TextBox
    Friend WithEvents Quiz_6TextBox As TextBox
    Friend WithEvents Exam_1TextBox As TextBox
    Friend WithEvents Exam_2TextBox As TextBox
    Friend WithEvents Exam_3TextBox As TextBox
    Friend WithEvents Exam_4TextBox As TextBox
    Friend WithEvents Proyect_1TextBox As TextBox
    Friend WithEvents Proyect_2TextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Quiz_1MaxTextBox As TextBox
    Friend WithEvents DateQuiz_1DateTimePicker As DateTimePicker
    Friend WithEvents Quiz_2MaxTextBox As TextBox
    Friend WithEvents DateQuiz_2DateTimePicker As DateTimePicker
    Friend WithEvents DateQuiz_3DateTimePicker As DateTimePicker
    Friend WithEvents Quiz_3MaxTextBox As TextBox
    Friend WithEvents Quiz_4MaxTextBox As TextBox
    Friend WithEvents Quiz_5MaxTextBox As TextBox
    Friend WithEvents DateQuiz_4DateTimePicker As DateTimePicker
    Friend WithEvents Quiz_6MaxTextBox As TextBox
    Friend WithEvents DateQuiz_5DateTimePicker As DateTimePicker
    Friend WithEvents DateQuiz_6DateTimePicker As DateTimePicker
    Friend WithEvents Exam_1MaxTextBox As TextBox
    Friend WithEvents DateExam_1DateTimePicker As DateTimePicker
    Friend WithEvents Exam_2MaxTextBox As TextBox
    Friend WithEvents DateExam_2DateTimePicker As DateTimePicker
    Friend WithEvents Exam_3MaxTextBox As TextBox
    Friend WithEvents Exam_4MaxTextBox As TextBox
    Friend WithEvents DateExam_4DateTimePicker As DateTimePicker
    Friend WithEvents DateExam_3DateTimePicker As DateTimePicker
    Friend WithEvents RecordBindingSource As BindingSource
    Friend WithEvents StudentRecordDataSet As StudentRecordDataSet
    Friend WithEvents RecordTableAdapter As StudentRecordDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents TableAdapterManager As StudentRecordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents RecordDataGridView As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Proyect_1MaxTextBox As TextBox
    Friend WithEvents Proyect_2MaxTextBox As TextBox
    Friend WithEvents DateProyect_2DateTimePicker As DateTimePicker
    Friend WithEvents DateProyect_1DateTimePicker As DateTimePicker
    Friend WithEvents cmbGroupSearch As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSetMax As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSetGrades As Button
    Friend WithEvents TOTALQUIZESLabel1 As Label
    Friend WithEvents TOTALQUIZPOINTSLabel1 As Label
    Friend WithEvents TOTALQUIZMAXPOINTSLabel1 As Label
    Friend WithEvents TOTALPROYECTMAXPOINTSLabel1 As Label
    Friend WithEvents TOTALPROYECTPOINTSLabel1 As Label
    Friend WithEvents TOTALEXAMMAXPOINTSLabel1 As Label
    Friend WithEvents TOTALEXAMPOINTSLabel1 As Label
    Friend WithEvents TOTALPROYECTSLabel1 As Label
    Friend WithEvents TOTALEXAMSLabel1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label13 As Label
End Class
