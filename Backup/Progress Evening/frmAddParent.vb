Public Class frmAddParent

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtForename.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtSurname.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtPhone.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please fill in all fields")
        Else
            FileOpen(1, FileParent, OpenMode.Random, , , Len(oneParent))
            noparent = LOF(1) / Len(oneParent)
            oneParent.firstname = txtForename.Text
            oneParent.surname = txtSurname.Text
            oneParent.phone = txtPhone.Text
            oneParent.email = txtEmail.Text
            oneParent.ParentID = noparent + 1
            FilePut(1, oneParent, noparent + 1)
            FileClose(1)
            MsgBox("Parent added!")
        End If
    End Sub

    Private Sub frmParent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtForename.Focus()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
