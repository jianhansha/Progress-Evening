Module ProjectModule

    'structure of a parent
    Structure Parent
        Public ParentID As Integer
        <VBFixedString(30)> Public username As String
        <VBFixedString(20)> Public password As String
        <VBFixedString(20)> Public firstname As String
        <VBFixedString(30)> Public surname As String
        <VBFixedString(11)> Public phone As String
        <VBFixedString(30)> Public email As String
        Public prefday1 As Integer
        Public prefday2 As Integer
        Public prefday3 As Integer
    End Structure

    'structure of a child
    Structure Child
        Public ChildID As Integer
        <VBFixedString(20)> Public firstname As String
        <VBFixedString(30)> Public surname As String
        <VBFixedString(10)> Public classname As String
        Public ParentID As Integer
    End Structure

    'structure of a teacher
    Structure Teacher
        Public TeacherID As Integer
        <VBFixedString(30)> Public username As String
        <VBFixedString(20)> Public password As String
        <VBFixedString(20)> Public firstname As String
        <VBFixedString(30)> Public surname As String
        <VBFixedString(10)> Public classname As String
    End Structure

    'structure of an appointment
    Structure Appointment
        Public day As Integer
        Public time As Integer
        Public TeacherID As Integer
        Public ParentID As Integer
        Public ChildID As Integer
    End Structure

    Public noparent As Integer 'number of parents in the file
    Public nochild As Integer 'number of children in the file
    Public noteacher As Integer 'number of teachers in the file
    Public noappointment As Integer 'number of appointments in the file

    Public origin As Integer 'to determine which user has logged in

    'admin login details
    Public adminusername As String = "admin"
    Public adminpassword As String = "pass"

    'declaring the structures
    Public oneParent As Parent
    Public oneChild As Child
    Public oneTeacher As Teacher
    Public oneAppointment As Appointment

    'declaring the files and their names
    Public FileParent As String = "parent.txt"
    Public FileChild As String = "child.txt"
    Public FileTeacher As String = "teacher.txt"
    Public FileAppointment As String = "Appointment.txt"

End Module
