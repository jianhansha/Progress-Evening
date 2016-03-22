<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddChild
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblParent = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.lblChild = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.cmbParent = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(24, 226)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 34)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(284, 226)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(112, 35)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblParent
        '
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(20, 185)
        Me.lblParent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(89, 29)
        Me.lblParent.TabIndex = 18
        Me.lblParent.Text = "Parent:"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(21, 145)
        Me.lblClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(149, 29)
        Me.lblClass.TabIndex = 17
        Me.lblClass.Text = "Class / Year:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(21, 105)
        Me.lblSurname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(134, 29)
        Me.lblSurname.TabIndex = 14
        Me.lblSurname.Text = "Last Name:"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(20, 66)
        Me.lblForename.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(137, 29)
        Me.lblForename.TabIndex = 13
        Me.lblForename.Text = "First Name:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(189, 106)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(205, 26)
        Me.txtSurname.TabIndex = 12
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(189, 66)
        Me.txtForename.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(205, 26)
        Me.txtForename.TabIndex = 11
        '
        'lblChild
        '
        Me.lblChild.AutoSize = True
        Me.lblChild.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChild.Location = New System.Drawing.Point(18, 14)
        Me.lblChild.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChild.Name = "lblChild"
        Me.lblChild.Size = New System.Drawing.Size(205, 37)
        Me.lblChild.TabIndex = 21
        Me.lblChild.Text = "Child Details:"
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"Reception", "Year 1", "Year 2", "Year 3", "Year 4", "Year 5", "Year 6"})
        Me.cmbClass.Location = New System.Drawing.Point(189, 146)
        Me.cmbClass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(205, 28)
        Me.cmbClass.TabIndex = 22
        '
        'cmbParent
        '
        Me.cmbParent.FormattingEnabled = True
        Me.cmbParent.Location = New System.Drawing.Point(189, 186)
        Me.cmbParent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbParent.Name = "cmbParent"
        Me.cmbParent.Size = New System.Drawing.Size(205, 28)
        Me.cmbParent.TabIndex = 23
        '
        'frmAddChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 277)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddChild"
        Me.Text = "Add Child"
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
