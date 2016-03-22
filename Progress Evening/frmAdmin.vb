Public Class frmAdmin
    Dim appointset As Boolean
    Dim appointday(10) As Boolean
    Dim freespace(10) As Integer
    Dim posscount As Integer
    Dim parentchild(9999, 2) As Integer
    Dim needset As Integer
    Dim yes As Integer
    Dim 2

    Private Sub btnParent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParent.Click
        frmAddParent.Show()
    End Sub

    Private Sub btnChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChild.Click
        frmAddChild.Show()
    End Sub

    Private Sub btnTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeacher.Click
        frmAddTeacher.Show()
    End Sub

    Private Sub btnAppointments_Click(sender As Object, e As EventArgs) Handles btnAppointments.Click
        FileOpen(2, FileChild, OpenMode.Random, , , Len(oneChild))
        nochild = LOF(2) / Len(oneChild)
        For d = 1 To nochild
            FileGet(2, oneChild, d)
            parentchild(oneChild.ParentID, 1) = oneChild.ParentID
            parentchild(oneChild.ParentID, 2) = parentchild(oneChild.ParentID, 2) + 1

            FileOpen(3, FileAppointment, OpenMode.Random, , , Len(oneAppointment))
            noappointment = LOF(3) / Len(oneAppointment)
            For k = 1 To noappointment
                FileGet(3, oneAppointment, k)
                If oneAppointment.ChildID = oneChild.ChildID Then
                    parentchild(oneAppointment.ParentID, 2) = parentchild(oneAppointment.ParentID, 2) - 1
                End If
            Next k
            FileClose(3)

        Next d
        FileClose(2)

        For w = 1 To 999
            FileOpen(1, FileParent, OpenMode.Random, , , Len(oneParent))
            noparent = (LOF(1) / Len(oneParent))
            For r = 1 To noparent
                FileGet(1, oneParent, r)
                If oneParent.ParentID = parentchild(w, 1) Then

                    FileOpen(4, FileChild, OpenMode.Random, , , Len(oneChild))
                    nochild = LOF(4) / Len(oneChild)
                    For g = 1 To nochild
                        FileGet(4, oneChild, g)
                        If oneChild.ParentID = oneParent.ParentID Then

                        End If
                    Next g
                End If
            Next r
        Next w
        '    For k = 1 To 999
        '        needset = needset + parentchild(k, 2)
        '    Next k

        '    For d = 1 To 999
        '        If parentchild(d, 2) > 0 Then
        '            For y = 1 To parentchild(d, 2)
        '                Dim child(parentchild(d, 2), 2) As Integer

        '                FileOpen(5, FileChild, OpenMode.Random, , , Len(oneChild))
        '                nochild = LOF(5) / Len(oneChild)
        '                For q = 1 To nochild
        '                    FileGet(5, oneChild, q)
        '                    If oneChild.ParentID = parentchild(d, 1) Then
        '                        child(y, 1) = oneChild.ChildID
        '                        FileOpen(6, FileTeacher, OpenMode.Random, , , Len(oneTeacher))
        '                        noteacher = LOF(6) / Len(oneTeacher)
        '                        For u = 1 To noteacher
        '                            FileGet(6, oneTeacher, u)
        '                            If oneTeacher.classname = oneChild.classname Then
        '                                child(y, 2) = oneTeacher.TeacherID
        '                            End If
        '                        Next u
        '                        FileClose(6)
        '                    End If
        '                Next q
        '                FileClose(5)

        '                FileOpen(8, FileParent, OpenMode.Random, , , Len(oneParent))
        '                noparent = LOF(8) / Len(oneParent)
        '                For p = 1 To noparent
        '                    FileGet(8, oneParent, p)
        '                    If oneParent.ParentID = parentchild(d, 1) Then
        '                        FileOpen(1, FileAppointment, OpenMode.Random, , , Len(oneAppointment))
        '                        noappointments = LOF(1) / Len(oneAppointment)
        '                        posscount = 0
        '                        Array.Clear(freespace, 1, 9999)
        '                        Array.Clear(appointday, 1, 9999)
        '                        For k = 1 To noappointment
        '                            FileGet(1, oneAppointment, k)
        '                            If oneAppointment.day = oneParent.prefday1 Then
        '                                appointday(oneAppointment.time) = True
        '                            End If
        '                        Next k
        '                        For i = 1 To 10
        '                            If appointday(i) = False Then
        '                                posscount = posscount + 1
        '                                freespace(posscount) = i
        '                            End If
        '                        Next i
        '                        Dim diff(90, parentchild(d, 2)) As Integer
        '                        For x = 1 To posscount
        '                            For y = 1 To posscount
        '                                If x <> y Then
        '                                    If Math.Abs(freespace(y) - freespace(x)) > 1 Then
        '                                        yes = yes + 1
        '                                        diff(yes,)
        '                                    End If
        '                                End If
        '                            Next y
        '                        Next x

        '                            If posscount >= parentchild(d, 2) And  Then

        '                        End If
        '                        FileClose(1)

        '                        End If
        '                Next p
        '                FileClose(8)
        '            Next y
        '        End If
        '    Next d




    End Sub
End Class