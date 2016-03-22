Module ProjectModule
    Structure Parent
        Public ParentID As Integer
        <VBFixedString(20)> Public firstname As String
        <VBFixedString(30)> Public surname As String
        <VBFixedString(11)> Public phone As String
        <VBFixedString(30)> Public email As String
    End Structure
    Structure Child
        Public ChildID As Integer
        <VBFixedString(20)> Public firstname As String
        <VBFixedString(30)> Public surname As String
        <VBFixedString(10)> Public classname As String
        Public ParentID As Integer
    End Structure
    Structure Teacher
        Public TeacherID As Integer
        <VBFixedString(20)> Public firstname As String
        <VBFixedString(30)> Public surname As String
        <VBFixedString(10)> Public classname As String
    End Structure
    Structure Appointment
        <VBFixedString(10)> Public day As String
        <VBFixedString(10)> Public time As String
        Public TeacherID As Integer
        Public ParentID As Integer
    End Structure
    Public noparent As Integer
    Public nochild As Integer
    Public noteacher As Integer
    Public noappointment As Integer
    Public oneParent As Parent
    Public oneChild As Child
    Public oneTeacher As Teacher
    Public oneAppointment As Appointment
    Public FileParent As String = "parent.txt"
    Public FileChild As String = "child.txt"
    Public FileTeacher As String = "teacher.txt"
    Public FileAppointment As String = "Appointment.txt"
End Module
