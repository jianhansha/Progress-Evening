Public Class frmSchedule
    Dim currentchild As String
    Dim currentparent As String
    Dim currentteacher As String
    Dim currentlabel As String
    Private Sub frmSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        origin = 1
        If origin = 1 Then
            For h = 0 To 10
                FileOpen(1, FileAppointment, OpenMode.Random, , , Len(oneAppointment))
                noappointment = LOF(1) / Len(oneAppointment)
                For k = 1 To noappointment
                    FileGet(1, oneAppointment, k)
                    For i = 1 To 3
                        If oneAppointment.day = i And oneAppointment.time = h Then
                            currentlabel = "lblD" & i & "T" & h

                            FileOpen(2, FileChild, OpenMode.Random, , , Len(oneChild))
                            nochild = LOF(2) / Len(oneChild)
                            For d = 1 To nochild
                                FileGet(2, oneChild, d)
                                If oneChild.ParentID = oneAppointment.ParentID Then
                                    currentchild = oneChild.firstname & oneChild.surname
                                End If
                            Next d
                            FileClose(2)

                            FileOpen(3, FileTeacher, OpenMode.Random, , , Len(oneTeacher))
                            noteacher = LOF(3) / Len(oneTeacher)
                            For f = 1 To noteacher
                                FileGet(3, oneTeacher, f)
                                If oneTeacher.TeacherID = oneAppointment.TeacherID Then
                                    currentteacher = oneTeacher.firstname & oneTeacher.surname
                                End If
                            Next f
                            FileClose(3)

                            Me.Controls(currentlabel).Text = UCase(currentchild) & vbNewLine & currentteacher
                        End If
                    Next i
                Next k
                    FileClose(1)
            Next h
        ElseIf origin = 2 Then
            For h = 0 To 10
                FileOpen(1, FileAppointment, OpenMode.Random, , , Len(oneAppointment))
                noappointment = LOF(1) / Len(oneAppointment)
                For k = 1 To noappointment
                    FileGet(1, oneAppointment, k)
                    For i = 1 To 3
                        If oneAppointment.day = i And oneAppointment.time = h Then
                            currentlabel = "lblD" & i & "T" & h

                            FileOpen(2, FileChild, OpenMode.Random, , , Len(oneChild))
                            nochild = LOF(2) / Len(oneChild)
                            For d = 1 To nochild
                                FileGet(2, oneChild, d)
                                If oneChild.ChildID = oneAppointment.ChildID Then
                                    currentchild = oneChild.firstname & oneChild.surname
                                End If
                            Next d
                            FileClose(2)

                            FileOpen(3, FileParent, OpenMode.Random, , , Len(oneParent))
                            noparent = LOF(3) / Len(oneParent)
                            For f = 1 To noparent
                                FileGet(3, oneParent, f)
                                If oneParent.ParentID = oneAppointment.ParentID Then
                                    currentparent = oneParent.firstname & oneParent.surname
                                End If
                            Next f
                            FileClose(3)

                            Me.Controls(currentlabel).Text = UCase(currentchild) & vbNewLine & currentparent
                        End If
                    Next i
                Next k
                FileClose(1)
            Next h
        End If
    End Sub
End Class