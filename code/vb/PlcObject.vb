'DOC
Public Class MillJob
    Inherits PlcObject
    <PlcMember("DB1.DBD 20")>
    Public Input As Integer

    <PlcMember("DB1.DBB 1", Length:=16)>
    Public Number As String

    <PlcMember("DB1.DBD 25")>
    Public Output As Integer

    <PlcMember("DB1.DBD 30")>
    Public RotationSpeed As Integer

    <PlcMember("DB1.DBW 40")>
    Public ToolDiameter As Single
End Class

'DOC
Public Class MachineData
    Inherits PlcObject
    <PlcMember("DB1.DBX 100.0", Length:=7)>
    Private toolConfigurations As Boolean()

    Public Sub New()
        MyBase.New()
    End Sub

    <PlcMember("DB1.DBB 120")>
    Public Property EstimatedFinishDate As DateTime

    <PlcMember("DB1.DBB 1", Length:=16)>
    Public Property JobNumber As String

    <PlcMember("DB1.DBD 100")>
    Public Property Speed As Integer

    <PlcMember("DB1.DBW 50")>
    Public Property Temperature As Single
    
    <PlcMember("DB1.DBX 100.0")>
    Public Property UseCuttingTool As Boolean

    Public Function IsToolConfigured(ByVal toolIndex As Integer) As Boolean
        Return Me.toolConfigurations(toolIndex)
    End Function
End Class
