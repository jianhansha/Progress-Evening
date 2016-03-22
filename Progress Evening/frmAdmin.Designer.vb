<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.btnParent = New System.Windows.Forms.Button()
        Me.btnChild = New System.Windows.Forms.Button()
        Me.btnTeacher = New System.Windows.Forms.Button()
        Me.btnAppointments = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnParent
        '
        Me.btnParent.Location = New System.Drawing.Point(18, 18)
        Me.btnParent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnParent.Name = "btnParent"
        Me.btnParent.Size = New System.Drawing.Size(171, 72)
        Me.btnParent.TabIndex = 0
        Me.btnParent.Text = "Add Parent"
        Me.btnParent.UseVisualStyleBackColor = True
        '
        'btnChild
        '
        Me.btnChild.Location = New System.Drawing.Point(18, 100)
        Me.btnChild.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnChild.Name = "btnChild"
        Me.btnChild.Size = New System.Drawing.Size(171, 80)
        Me.btnChild.TabIndex = 1
        Me.btnChild.Text = "Add Child"
        Me.btnChild.UseVisualStyleBackColor = True
        '
        'btnTeacher
        '
        Me.btnTeacher.Location = New System.Drawing.Point(198, 18)
        Me.btnTeacher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(171, 72)
        Me.btnTeacher.TabIndex = 2
        Me.btnTeacher.Text = "Add Teacher"
        Me.btnTeacher.UseVisualStyleBackColor = True
        '
        'btnAppointments
        '
        Me.btnAppointments.Location = New System.Drawing.Point(196, 100)
        Me.btnAppointments.Name = "btnAppointments"
        Me.btnAppointments.Size = New System.Drawing.Size(173, 80)
        Me.btnAppointments.TabIndex = 3
        Me.btnAppointments.Text = "Set Appointments"
        Me.btnAppointments.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 195)
        Me.Controls.Add(Me.btnAppointments)
        Me.Controls.Add(Me.btnTeacher)
        Me.Controls.Add(Me.btnChild)
        Me.Controls.Add(Me.btnParent)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAdmin"
        Me.Text = "Admin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnParent As System.Windows.Forms.Button
    Friend WithEvents btnChild As System.Windows.Forms.Button
    Friend WithEvents btnTeacher As System.Windows.Forms.Button
    Friend WithEvents btnAppointments As Button
End Class
