<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChild
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
        Me.btnBack = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lblParent = New System.Windows.Forms.Label
        Me.lblClass = New System.Windows.Forms.Label
        Me.lblSurname = New System.Windows.Forms.Label
        Me.lblForename = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.lblChild = New System.Windows.Forms.Label
        Me.cmbClass = New System.Windows.Forms.ComboBox
        Me.cmbParent = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(16, 147)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(70, 22)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(189, 147)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblParent
        '
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(13, 120)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(55, 18)
        Me.lblParent.TabIndex = 18
        Me.lblParent.Text = "Parent:"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(14, 94)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(92, 18)
        Me.lblClass.TabIndex = 17
        Me.lblClass.Text = "Class / Year:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(14, 68)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(84, 18)
        Me.lblSurname.TabIndex = 14
        Me.lblSurname.Text = "Last Name:"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(13, 43)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(85, 18)
        Me.lblForename.TabIndex = 13
        Me.lblForename.Text = "First Name:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(126, 69)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(138, 20)
        Me.txtSurname.TabIndex = 12
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(126, 43)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(138, 20)
        Me.txtForename.TabIndex = 11
        '
        'lblChild
        '
        Me.lblChild.AutoSize = True
        Me.lblChild.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChild.Location = New System.Drawing.Point(12, 9)
        Me.lblChild.Name = "lblChild"
        Me.lblChild.Size = New System.Drawing.Size(139, 25)
        Me.lblChild.TabIndex = 21
        Me.lblChild.Text = "Child Details:"
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"Reception", "Year 1", "Year 2", "Year 3", "Year 4", "Year 5", "Year 6"})
        Me.cmbClass.Location = New System.Drawing.Point(126, 95)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(138, 21)
        Me.cmbClass.TabIndex = 22
        '
        'cmbParent
        '
        Me.cmbParent.FormattingEnabled = True
        Me.cmbParent.Location = New System.Drawing.Point(126, 121)
        Me.cmbParent.Name = "cmbParent"
        Me.cmbParent.Size = New System.Drawing.Size(138, 21)
        Me.cmbParent.TabIndex = 23
        '
        'frmChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 180)
        Me.Controls.Add(Me.cmbParent)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.lblChild)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblParent)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Name = "frmChild"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
    Friend WithEvents lblChild As System.Windows.Forms.Label
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents cmbParent As System.Windows.Forms.ComboBox
End Class
