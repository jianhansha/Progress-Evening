Public Class frmAdmin

    Private Sub btnParent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParent.Click
        frmAddParent.Show()
    End Sub

    Private Sub btnChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChild.Click
        frmChild.Show()
    End Sub

    Private Sub btnTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeacher.Click
        frmTeacher.Show()
    End Sub
End Class