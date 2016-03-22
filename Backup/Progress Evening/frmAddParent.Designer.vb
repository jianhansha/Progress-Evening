<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddParent
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
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.lblSurname = New System.Windows.Forms.Label
        Me.lblForename = New System.Windows.Forms.Label
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.lblParent = New System.Windows.Forms.Label
        Me.txtForename = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(19, 149)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(70, 22)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(192, 149)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(17, 122)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(112, 18)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "E-mail Address:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(17, 96)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(112, 18)
        Me.lblPhone.TabIndex = 18
        Me.lblPhone.Text = "Phone Number:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(129, 123)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(138, 20)
        Me.txtEmail.TabIndex = 17
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(129, 97)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(138, 20)
        Me.txtPhone.TabIndex = 16
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(17, 70)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(84, 18)
        Me.lblSurname.TabIndex = 15
        Me.lblSurname.Text = "Last Name:"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(16, 45)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(85, 18)
        Me.lblForename.TabIndex = 14
        Me.lblForename.Text = "First Name:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(129, 71)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(138, 20)
        Me.txtSurname.TabIndex = 13
        '
        'lblParent
        '
        Me.lblParent.AutoSize = True
        Me.lblParent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParent.Location = New System.Drawing.Point(12, 9)
        Me.lblParent.Name = "lblParent"
        Me.lblParent.Size = New System.Drawing.Size(153, 25)
        Me.lblParent.TabIndex = 12
        Me.lblParent.Text = "Parent Details:"
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(129, 45)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(138, 20)
        Me.txtForename.TabIndex = 11
        '
        'frmParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 179)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblParent)
        Me.Controls.Add(Me.txtForename)
        Me.Name = "frmParent"
        Me.Text = "frmPar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblParent As System.Windows.Forms.Label
    Friend WithEvents txtForename As System.Windows.Forms.TextBox
End Class
