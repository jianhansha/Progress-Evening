Public Class frmHome
    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        origin = 3
        frmLogin.Show()
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        origin = 2
        frmLogin.Show()
    End Sub

    Private Sub btnParent_Click(sender As Object, e As EventArgs) Handles btnParent.Click
        origin = 1
        frmLogin.Show()
    End Sub
End Class