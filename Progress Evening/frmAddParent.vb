Public Class frmAddParent
    Dim day(3) As Integer 'declare variable which contains which

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'check if any of the fields are empty
        If txtForename.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtSurname.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtPhone.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf cmbTuesday.SelectedItem.Tostring = "" Then
            MsgBox("Please fill in all fields")
        ElseIf cmbWednesday.SelectedItem.ToString = "" Then
            MsgBox("Please fill in all fields")
        ElseIf cmbThursday.SelectedItem.ToString = "" Then
            MsgBox("Please fill in all fields")
        Else
            FileOpen(1, FileParent, OpenMode.Random, , , Len(oneParent))
            noparent = LOF(1) / Len(oneParent)
            day(Integer.Parse(cmbTuesday.Text)) = 1
            day(Integer.Parse(cmbWednesday.Text)) = 2
            day(Integer.Parse(cmbThursday.Text)) = 3
            oneParent.prefday1 = day(1)
            oneParent.prefday2 = day(2)
            oneParent.prefday3 = day(3)
            oneParent.username = txtUsername.Text
            oneParent.password = txtPassword.Text
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
        For k = 1 To 3
            cmbTuesday.Items.Add(k)
            cmbWednesday.Items.Add(k)
            cmbThursday.Items.Add(k)
        Next k
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub cmbTuesday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTuesday.SelectedIndexChanged
        cmbThursday.Items.Remove(cmbTuesday.SelectedItem)
        cmbWednesday.Items.Remove(cmbTuesday.SelectedItem)
    End Sub

    Private Sub cmbWednesday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWednesday.SelectedIndexChanged
        cmbThursday.Items.Remove(cmbWednesday.SelectedItem)
        cmbTuesday.Items.Remove(cmbWednesday.SelectedItem)
    End Sub

    Private Sub cmbThursday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThursday.SelectedIndexChanged
        cmbTuesday.Items.Remove(cmbThursday.SelectedItem)
        cmbWednesday.Items.Remove(cmbThursday.SelectedItem)
    End Sub
End Class
