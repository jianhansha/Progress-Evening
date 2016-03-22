<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddTeacher
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
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.lblTeacher = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstChild = New System.Windows.Forms.ListBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"Reception", "Year 1", "Year 2", "Year 3", "Year 4", "Year 5", "Year 6"})
        Me.cmbClass.Location = New System.Drawing.Point(186, 212)
        Me.cmbClass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(205, 28)
        Me.cmbClass.TabIndex = 33
        '
        'lblTeacher
        '
        Me.lblTeacher.AutoSize = True
        Me.lblTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeacher.Location = New System.Drawing.Point(18, 14)
        Me.lblTeacher.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTeacher.Name = "lblTeacher"
        Me.lblTeacher.Size = New System.Drawing.Size(249, 37)
        Me.lblTeacher.TabIndex = 32
        Me.lblTeacher.Text = "Teacher Details:"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(25, 283)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 34)
        Me.btnBack.TabIndex = 31
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(279, 283)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 35)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstChild
        '
        Me.lstChild.FormattingEnabled = True
        Me.lstChild.ItemHeight = 20
        Me.lstChild.Location = New System.Drawing.Point(405, 14)
        Me.lstChild.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstChild.Name = "lstChild"
        Me.lstChild.Size = New System.Drawing.Size(376, 304)
        Me.lstChild.TabIndex = 34
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(20, 208)
        Me.lblClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(137, 29)
        Me.lblClass.TabIndex = 39
        Me.lblClass.Text = "Class/Year:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(20, 172)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(126, 29)
        Me.lblPassword.TabIndex = 47
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(20, 136)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(130, 29)
        Me.lblUsername.TabIndex = 46
        Me.lblUsername.Text = "Username:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(186, 176)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(205, 26)
        Me.txtPassword.TabIndex = 45
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(186, 140)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(205, 26)
        Me.txtUsername.TabIndex = 44
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(20, 100)
        Me.lblSurname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(134, 29)
        Me.lblSurname.TabIndex = 43
        Me.lblSurname.Text = "Last Name:"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(20, 64)
        Me.lblForename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(137, 29)
        Me.lblForename.TabIndex = 42
        Me.lblForename.Text = "First Name:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(186, 104)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(205, 26)
        Me.txtSurname.TabIndex = 41
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(186, 68)
        Me.txtForename.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(205, 26)
        Me.txtForename.TabIndex = 40
        '
        'frmAddTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 339)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lstChild)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.lblTeacher)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddTeacher"
        Me.Text = "Add Teacher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents lblTeacher As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstChild As System.Windows.Forms.ListBox
    Friend WithEvents lblClass As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblForename As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtForename As TextBox
End Class
