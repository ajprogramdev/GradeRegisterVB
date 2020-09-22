<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Form
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
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCOURSE = New System.Windows.Forms.TextBox()
        Me.RecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentRecordDataSet = New ClassGradeRegister.StudentRecordDataSet()
        Me.txtNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.RecordDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbGroupSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.RecordTableAdapter = New ClassGradeRegister.StudentRecordDataSetTableAdapters.RecordTableAdapter()
        Me.TableAdapterManager = New ClassGradeRegister.StudentRecordDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        StudentIDLabel.Location = New System.Drawing.Point(23, 95)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(93, 20)
        StudentIDLabel.TabIndex = 8
        StudentIDLabel.Text = "Student ID:"
        '
        'txtCOURSE
        '
        Me.txtCOURSE.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "Course", True))
        Me.txtCOURSE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtCOURSE.Location = New System.Drawing.Point(131, 129)
        Me.txtCOURSE.Name = "txtCOURSE"
        Me.txtCOURSE.Size = New System.Drawing.Size(153, 26)
        Me.txtCOURSE.TabIndex = 2
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
        'txtNAME
        '
        Me.txtNAME.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "Name", True))
        Me.txtNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNAME.Location = New System.Drawing.Point(131, 49)
        Me.txtNAME.Name = "txtNAME"
        Me.txtNAME.Size = New System.Drawing.Size(212, 26)
        Me.txtNAME.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(59, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(48, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Course:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(59, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Group:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGray
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSave.Location = New System.Drawing.Point(232, 364)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 41)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save All"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAdd.Location = New System.Drawing.Point(78, 364)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(114, 41)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDelete.Location = New System.Drawing.Point(152, 423)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 41)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(988, 532)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(170, 48)
        Me.btnMenu.TabIndex = 12
        Me.btnMenu.Text = "Back to Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1083, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 39)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "Help"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMessage.ForeColor = System.Drawing.Color.Lime
        Me.lblMessage.Location = New System.Drawing.Point(133, 18)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 20)
        Me.lblMessage.TabIndex = 10
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.StudentIDTextBox.Location = New System.Drawing.Point(131, 92)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(176, 26)
        Me.StudentIDTextBox.TabIndex = 9
        '
        'cmbGroup
        '
        Me.cmbGroup.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "Group", True))
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Items.AddRange(New Object() {"Group#1", "Group#2", "Group#3", "Group#4", "Group#5", "Group#6"})
        Me.cmbGroup.Location = New System.Drawing.Point(131, 170)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(121, 28)
        Me.cmbGroup.TabIndex = 8
        '
        'RecordDataGridView
        '
        Me.RecordDataGridView.AllowUserToAddRows = False
        Me.RecordDataGridView.AllowUserToResizeColumns = False
        Me.RecordDataGridView.AllowUserToResizeRows = False
        Me.RecordDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecordDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.RecordDataGridView.DataSource = Me.RecordBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RecordDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.RecordDataGridView.Location = New System.Drawing.Point(415, 101)
        Me.RecordDataGridView.Name = "RecordDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RecordDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.RecordDataGridView.RowHeadersVisible = False
        Me.RecordDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.RecordDataGridView.RowTemplate.Height = 24
        Me.RecordDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RecordDataGridView.Size = New System.Drawing.Size(691, 412)
        Me.RecordDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 42
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 172
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Course"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Group"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Group"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'cmbGroupSearch
        '
        Me.cmbGroupSearch.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RecordBindingSource, "Group", True))
        Me.cmbGroupSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmbGroupSearch.FormattingEnabled = True
        Me.cmbGroupSearch.Items.AddRange(New Object() {"Group#1", "Group#2", "Group#3", "Group#4", "Group#5", "Group#6", "ViewAll"})
        Me.cmbGroupSearch.Location = New System.Drawing.Point(521, 46)
        Me.cmbGroupSearch.Name = "cmbGroupSearch"
        Me.cmbGroupSearch.Size = New System.Drawing.Size(138, 33)
        Me.cmbGroupSearch.TabIndex = 18
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnSearch.Location = New System.Drawing.Point(674, 41)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(204, 41)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Search By Group"
        Me.btnSearch.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.lblMessage)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(StudentIDLabel)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.StudentIDTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbGroup)
        Me.Panel1.Controls.Add(Me.txtNAME)
        Me.Panel1.Controls.Add(Me.txtCOURSE)
        Me.Panel1.Location = New System.Drawing.Point(24, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 251)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(93, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Manage Students"
        '
        'Manage_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 609)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbGroupSearch)
        Me.Controls.Add(Me.RecordDataGridView)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "Manage_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Students"
        CType(Me.RecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecordDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCOURSE As TextBox
    Friend WithEvents txtNAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents StudentRecordDataSet As StudentRecordDataSet
    Friend WithEvents RecordBindingSource As BindingSource
    Friend WithEvents RecordTableAdapter As StudentRecordDataSetTableAdapters.RecordTableAdapter
    Friend WithEvents TableAdapterManager As StudentRecordDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecordDataGridView As DataGridView
    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents cmbGroupSearch As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
