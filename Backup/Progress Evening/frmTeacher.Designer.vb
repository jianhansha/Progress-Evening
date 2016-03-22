<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeacher
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
        Me.cmbClass = New System.Windows.Forms.ComboBox
        Me.lblTeacher = New System.Windows.Forms.Label
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lblClass = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.lblForename = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.lstChild = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"Reception", "Year 1", "Year 2", "Year 3", "Year 4", "Year 5", "Year 6"})
        Me.cmbClass.Location = New System.Drawing.Point(126, 95)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(138, 21)
        Me.cmbClass.TabIndex = 33
        '
        'lblTeacher
        '
        Me.lblTeacher.AutoSize = True
        Me.lblTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacher.Location = New System.Drawing.Point(12, 9)
        Me.lblTeacher.Name = "lblTeacher"
        Me.lblTeacher.Size = New System.Drawing.Size(169, 25)
        Me.lblTeacher.TabIndex = 32
        Me.lblTeacher.Text = "Teacher Details:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(16, 122)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(70, 22)
        Me.btnBack.TabIndex = 31
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(189, 122)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(14, 94)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(92, 18)
        Me.lblClass.TabIndex = 28
        Me.lblClass.Text = "Class / Year:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(14, 68)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(84, 18)
        Me.lblSurname.TabIndex = 27
        Me.lblSurname.Text = "Last Name:"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(13, 43)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(85, 18)
        Me.lblForename.TabIndex = 26
        Me.lblForename.Text = "First Name:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(126, 69)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(138, 20)
        Me.txtSurname.TabIndex = 25
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(126, 43)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(138, 20)
        Me.txtForename.TabIndex = 24
        '
        'lstChild
        '
        Me.lstChild.FormattingEnabled = True
        Me.lstChild.Location = New System.Drawing.Point(270, 9)
        Me.lstChild.Name = "lstChild"
        Me.lstChild.Size = New System.Drawing.Size(252, 134)
        Me.lstChild.TabIndex = 34
        '
        'frmTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 152)
        Me.Controls.Add(Me.lstChild)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.lblTeacher)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Name = "frmTeacher"
        Me.Text = "frmTeacher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents lblTeacher As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents lstChild As System.Windows.Forms.ListBox
End Class
