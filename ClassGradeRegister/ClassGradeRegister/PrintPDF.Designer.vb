<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPDF
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintPDF))
        Me.RecordDataGridView = New System.Windows.Forms.DataGridView()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentRecordDataSet = New ClassGradeRegister.StudentRecordDataSet()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnCreatePdf = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.RecordTableAdapter = New ClassGradeRegister.StudentRecordDataSetTableAdapters.RecordTableAdapter()
        Me.TableAdapterManager = New ClassGradeRegister.StudentRecordDataSetTableAdapters.TableAdapterManager()
        Me.btnPreviewPdf = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdGroup5 = New System.Windows.Forms.RadioButton()
        Me.rdGroup6 = New System.Windows.Forms.RadioButton()
        Me.rdGroup4 = New System.Windows.Forms.RadioButton()
        Me.rdGroup3 = New System.Windows.Forms.RadioButton()
        Me.rdGroup2 = New System.Windows.Forms.RadioButton()
        Me.rdGroup1 = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecordDataGridView
        '
        Me.RecordDataGridView.AllowUserToAddRows = False
        Me.RecordDataGridView.AllowUserToDeleteRows = False
        Me.RecordDataGridView.AllowUserToResizeColumns = False
        Me.RecordDataGridView.AllowUserToResizeRows = False
        Me.RecordDataGridView.AutoGenerateColumns = False
        Me.RecordDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.RecordDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecordDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn44})
        Me.RecordDataGridView.DataSource = Me.RecordBindingSource
        Me.RecordDataGridView.Location = New System.Drawing.Point(33, 12)
        Me.RecordDataGridView.Name = "RecordDataGridView"
        Me.RecordDataGridView.RowHeadersVisible = False
        Me.RecordDataGridView.RowTemplate.Height = 24
        Me.RecordDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.RecordDataGridView.Size = New System.Drawing.Size(1180, 509)
        Me.RecordDataGridView.TabIndex = 1
        '
        'RecordBindingSource
        '
        Me.RecordBindingSource.DataMember = "Record"
        Me.RecordBindingSource.DataSource = Me.StudentRecordDataSet
        '
        'StudentRecordDataSet
        '
        Me.StudentRecordDataSet.DataSetName = "StudentRecordDataSet"
        Me.StudentRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintDocument1
        '
        '
        'btnCreatePdf
        '
        Me.btnCreatePdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreatePdf.Location = New System.Drawing.Point(93, 612)
        Me.btnCreatePdf.Name = "btnCreatePdf"
        Me.btnCreatePdf.Size = New System.Drawing.Size(239, 33)
        Me.btnCreatePdf.TabIndex = 2
        Me.btnCreatePdf.Text = "Create PDF"
        Me.btnCreatePdf.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
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
        'btnPreviewPdf
        '
        Me.btnPreviewPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewPdf.Location = New System.Drawing.Point(93, 558)
        Me.btnPreviewPdf.Name = "btnPreviewPdf"
        Me.btnPreviewPdf.Size = New System.Drawing.Size(239, 33)
        Me.btnPreviewPdf.TabIndex = 3
        Me.btnPreviewPdf.Text = "Preview PDF"
        Me.btnPreviewPdf.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdGroup5)
        Me.GroupBox1.Controls.Add(Me.rdGroup6)
        Me.GroupBox1.Controls.Add(Me.rdGroup4)
        Me.GroupBox1.Controls.Add(Me.rdGroup3)
        Me.GroupBox1.Controls.Add(Me.rdGroup2)
        Me.GroupBox1.Controls.Add(Me.rdGroup1)
        Me.GroupBox1.Location = New System.Drawing.Point(492, 545)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(502, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'rdGroup5
        '
        Me.rdGroup5.AutoSize = True
        Me.rdGroup5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGroup5.Location = New System.Drawing.Point(364, 20)
        Me.rdGroup5.Name = "rdGroup5"
        Me.rdGroup5.Size = New System.Drawing.Size(101, 24)
        Me.rdGroup5.TabIndex = 5
        Me.rdGroup5.TabStop = True
        Me.rdGroup5.Text = "Group#5"
        Me.rdGroup5.UseVisualStyleBackColor = True
        '
        'rdGroup6
        '
        Me.rdGroup6.AutoSize = True
        Me.rdGroup6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGroup6.Location = New System.Drawing.Point(364, 56)
        Me.rdGroup6.Name = "rdGroup6"
        Me.rdGroup6.Size = New System.Drawing.Size(101, 24)
        Me.rdGroup6.TabIndex = 4
        Me.rdGroup6.TabStop = True
        Me.rdGroup6.Text = "Group#6"
        Me.rdGroup6.UseVisualStyleBackColor = True
        '
        'rdGroup4
        '
        Me.rdGroup4.AutoSize = True
        Me.rdGroup4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGroup4.Location = New System.Drawing.Point(202, 56)
        Me.rdGroup4.Name = "rdGroup4"
        Me.rdGroup4.Size = New System.Drawing.Size(101, 24)
        Me.rdGroup4.TabIndex = 3
        Me.rdGroup4.TabStop = True
        Me.rdGroup4.Text = "Group#4"
        Me.rdGroup4.UseVisualStyleBackColor = True
        '
        'rdGroup3
        '
        Me.rdGroup3.AutoSize = True
        Me.rdGroup3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGroup3.Location = New System.Drawing.Point(202, 25)
        Me.rdGroup3.Name = "rdGroup3"
        Me.rdGroup3.Size = New System.Drawing.Size(101, 24)
        Me.rdGroup3.TabIndex = 2
        Me.rdGroup3.TabStop = True
        Me.rdGroup3.Text = "Group#3"
        Me.rdGroup3.UseVisualStyleBackColor = True
        '
        'rdGroup2
        '
        Me.rdGroup2.AutoSize = True
        Me.rdGroup2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGroup2.Location = New System.Drawing.Point(48, 56)
        Me.rdGroup2.Name = "rdGroup2"
        Me.rdGroup2.Size = New System.Drawing.Size(101, 24)
        Me.rdGroup2.TabIndex = 1
        Me.rdGroup2.TabStop = True
        Me.rdGroup2.Text = "Group#2"
        Me.rdGroup2.UseVisualStyleBackColor = True
        '
        'rdGroup1
        '
        Me.rdGroup1.AutoSize = True
        Me.rdGroup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdGroup1.Location = New System.Drawing.Point(48, 22)
        Me.rdGroup1.Name = "rdGroup1"
        Me.rdGroup1.Size = New System.Drawing.Size(101, 24)
        Me.rdGroup1.TabIndex = 0
        Me.rdGroup1.TabStop = True
        Me.rdGroup1.Text = "Group#1"
        Me.rdGroup1.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(1106, 546)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 118)
        Me.btnClose.TabIndex = 5
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "TOTALQUIZPOINTS"
        Me.DataGridViewTextBoxColumn42.HeaderText = "TotalQuizPoints"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Width = 110
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "TOTALQUIZMAXPOINTS"
        Me.DataGridViewTextBoxColumn46.HeaderText = "MaxPoints"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        Me.DataGridViewTextBoxColumn46.Width = 85
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "TOTALQUIZES"
        Me.DataGridViewTextBoxColumn45.HeaderText = "%"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Width = 35
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "TOTALEXAMPOINTS"
        Me.DataGridViewTextBoxColumn43.HeaderText = "TotalExamPoints"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 116
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "TOTALEXAMMAXPOINTS"
        Me.DataGridViewTextBoxColumn48.HeaderText = "MaxPoints"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        Me.DataGridViewTextBoxColumn48.Width = 85
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "TOTALEXAMS"
        Me.DataGridViewTextBoxColumn47.HeaderText = "%"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Width = 35
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "TOTALPROYECTPOINTS"
        Me.DataGridViewTextBoxColumn49.HeaderText = "TotalProyectPoints"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Width = 130
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "TOTALPROYECTMAXPOINTS"
        Me.DataGridViewTextBoxColumn50.HeaderText = "MaxPoints"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        Me.DataGridViewTextBoxColumn50.Width = 85
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "TOTALPROYECTS"
        Me.DataGridViewTextBoxColumn44.HeaderText = "%"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Width = 35
        '
        'PrintPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 676)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPreviewPdf)
        Me.Controls.Add(Me.btnCreatePdf)
        Me.Controls.Add(Me.RecordDataGridView)
        Me.Name = "PrintPDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrintPDF"
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentRecordDataSet As StudentRecordDataSet
    Friend WithEvents RecordBindingSource As BindingSource
    Friend WithEvents RecordTableAdapter As StudentRecordDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents TableAdapterManager As StudentRecordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordDataGridView As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnCreatePdf As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnPreviewPdf As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdGroup5 As RadioButton
    Friend WithEvents rdGroup6 As RadioButton
    Friend WithEvents rdGroup4 As RadioButton
    Friend WithEvents rdGroup3 As RadioButton
    Friend WithEvents rdGroup2 As RadioButton
    Friend WithEvents rdGroup1 As RadioButton
    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
End Class
