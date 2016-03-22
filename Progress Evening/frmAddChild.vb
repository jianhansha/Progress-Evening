Public Class frmAddChild

    Private Sub frmChild_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'populate the parent combo box with parents in the Parents file
        Dim first As String
        Dim second As String
        FileOpen(1, FileParent, OpenMode.Random, , , Len(oneParent))
        noparent = LOF(1) / Len(oneParent)
        For k = 1 To noparent
            FileGet(1, oneParent, k)
            first = oneParent.firstname.Trim
            second = oneParent.surname.Trim
            cmbParent.Items.Add(first + " " + second)
        Next
        FileClose(1)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'Check if any fields are empty
        If txtForename.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf txtSurname.Text = "" Then
            MsgBox("Please fill in all fields")
        ElseIf cmbClass.SelectedItem.ToString = "" Then
            MsgBox("Please fill in all fields")
        ElseIf cmbParent.SelectedItem.ToString = "" Then
            MsgBox("Please fill in all fields")
        Else
            'Determine the parent ID of selected item from Parent Combo Box
            FileOpen(1, FileParent, OpenMode.Random, , , Len(oneParent))
            noparent = LOF(1) / Len(oneParent)
            For k = 1 To noparent
                FileGet(1, oneParent, k)
                If (oneParent.firstname.Trim + " " + oneParent.surname.Trim) = cmbParent.SelectedItem Then
                    'Add the fields associated with a child to the file (New Child)
                    FileOpen(2, FileChild, OpenMode.Random, , , Len(oneChild))
                    nochild = LOF(2) / Len(oneChild)
                    oneChild.firstname = txtForename.Text
                    oneChild.surname = txtSurname.Text
                    oneChild.classname = cmbClass.SelectedItem.Trim
                    oneChild.ParentID = oneParent.ParentID
                    oneChild.ChildID = nochild + 1
                    FilePut(2, oneChild, nochild + 1)
                    FileClose(2)
                    MsgBox("Child added!")

                End If
            Next
            FileClose(1)
        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Close the current form
        Me.Close()
    End Sub
End Class