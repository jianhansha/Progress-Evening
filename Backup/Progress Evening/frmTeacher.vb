Public Class frmTeacher

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtForename.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtSurname.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf cmbClass.SelectedItem = "" Then
            MsgBox("Please fill in all fields")
        Else
            FileOpen(2, FileTeacher, OpenMode.Random, , , Len(oneTeacher))
            noteacher = LOF(1) / Len(oneTeacher)
            oneTeacher.firstname = txtForename.Text
            oneTeacher.surname = txtSurname.Text
            oneTeacher.TeacherID = noteacher + 1
            FilePut(2, oneTeacher, noteacher + 1)
            FileClose(2)
            MsgBox("Teacher added!")
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClass.SelectedIndexChanged
        lstChild.Items.Clear()
        FileOpen(1, FileChild, OpenMode.Random, , , Len(oneChild))
        nochild = LOF(1) / Len(oneChild)
        For k = 1 To nochild
            FileGet(1, oneChild, k)
            If oneChild.classname.Trim = cmbClass.SelectedItem.Trim Then
                lstChild.Items.Add(oneChild.firstname.Trim + " " + oneChild.surname.Trim)
            End If
        Next
        FileClose(1)
    End Sub
End Class