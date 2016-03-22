<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.btnAdmin = New System.Windows.Forms.Button
        Me.btnParent = New System.Windows.Forms.Button
        Me.btnTeacher = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(12, 12)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(110, 48)
        Me.btnAdmin.TabIndex = 0
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnParent
        '
        Me.btnParent.Location = New System.Drawing.Point(12, 66)
        Me.btnParent.Name = "btnParent"
        Me.btnParent.Size = New System.Drawing.Size(226, 48)
        Me.btnParent.TabIndex = 1
        Me.btnParent.Text = "Parent"
        Me.btnParent.UseVisualStyleBackColor = True
        '
        'btnTeacher
        '
        Me.btnTeacher.Location = New System.Drawing.Point(128, 12)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(110, 48)
        Me.btnTeacher.TabIndex = 2
        Me.btnTeacher.Text = "Teacher"
        Me.btnTeacher.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 128)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnParent)
        Me.Controls.Add(Me.btnAdmin)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents btnParent As System.Windows.Forms.Button
    Friend WithEvents btnTeacher As System.Windows.Forms.Button
End Class
