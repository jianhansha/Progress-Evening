Public Class frmLogin
    Dim Login As Boolean = False
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If origin = 1 Then
            FileOpen(1, FileParent, OpenMode.Random, , , Len(oneParent))
            noparent = LOF(1) / Len(oneParent)
            For k = 1 To noparent
                FileGet(1, oneParent, k)
                If oneParent.username = txtName.Text And oneParent.password = txtPassword.Text Then
                    Login = True
                End If
            Next k
            FileClose(1)
        ElseIf origin = 2 Then
            FileOpen(1, FileTeacher, OpenMode.Random, , , Len(oneTeacher))
            noteacher = LOF(1) / Len(oneTeacher)
            For k = 1 To noteacher
                FileGet(1, oneTeacher, k)
                If oneTeacher.username = txtName.Text And oneTeacher.password = txtPassword.Text Then
                    Login = True
                End If
            Next k
            FileClose(1)
        ElseIf origin = 3 Then
            If txtName.Text = adminusername And txtPassword.Text = adminpassword Then
                Login = True
            End If
        End If

        If Login = True Then
            If origin = 1 Then
                Me.Close()
                frmSchedule.Show()
            ElseIf origin = 2 Then
                Me.Close()
                frmSchedule.Show()
            ElseIf origin = 3 Then
                Me.Close()
                frmAdmin.Show()
            End If
        ElseIf Login = False Then
                MsgBox("Log-In Unsuccessful")
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If origin = 1 Then
            lblTitle.Text = "Parent Login"
        ElseIf origin = 2 Then
            lblTitle.Text = "Teacher Login"
        ElseIf origin = 3 Then
            lblTitle.Text = "Admin Login"
        End If
    End Sub
End Class