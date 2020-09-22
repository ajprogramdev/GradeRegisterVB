<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Form))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnManageGrades = New System.Windows.Forms.Button()
        Me.btnManageStudent = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(668, 324)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 114)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnStudents
        '
        Me.btnStudents.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnStudents.BackgroundImage = CType(resources.GetObject("btnStudents.BackgroundImage"), System.Drawing.Image)
        Me.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnStudents.Location = New System.Drawing.Point(394, 44)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(177, 140)
        Me.btnStudents.TabIndex = 1
        Me.btnStudents.UseVisualStyleBackColor = False
        '
        'btnManageGrades
        '
        Me.btnManageGrades.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnManageGrades.BackgroundImage = CType(resources.GetObject("btnManageGrades.BackgroundImage"), System.Drawing.Image)
        Me.btnManageGrades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnManageGrades.Location = New System.Drawing.Point(174, 44)
        Me.btnManageGrades.Name = "btnManageGrades"
        Me.btnManageGrades.Size = New System.Drawing.Size(166, 140)
        Me.btnManageGrades.TabIndex = 2
        Me.btnManageGrades.UseVisualStyleBackColor = False
        '
        'btnManageStudent
        '
        Me.btnManageStudent.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnManageStudent.BackgroundImage = CType(resources.GetObject("btnManageStudent.BackgroundImage"), System.Drawing.Image)
        Me.btnManageStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnManageStudent.Location = New System.Drawing.Point(174, 202)
        Me.btnManageStudent.Name = "btnManageStudent"
        Me.btnManageStudent.Size = New System.Drawing.Size(166, 148)
        Me.btnManageStudent.TabIndex = 3
        Me.btnManageStudent.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnHelp.BackgroundImage = CType(resources.GetObject("btnHelp.BackgroundImage"), System.Drawing.Image)
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHelp.Location = New System.Drawing.Point(394, 202)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(177, 148)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'Menu_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnManageStudent)
        Me.Controls.Add(Me.btnManageGrades)
        Me.Controls.Add(Me.btnStudents)
        Me.Controls.Add(Me.btnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Menu_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnManageGrades As Button
    Friend WithEvents btnManageStudent As Button
    Friend WithEvents btnHelp As Button
End Class
