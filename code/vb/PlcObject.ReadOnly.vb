'DOC
Public Class ProductionData
    Inherits PlcObject

    <PlcMember("DB100.DBD 0", CanWrite:=False)>
    Public Pieces As Integer

    <PlcMember("DB100.DBD 4")>
    Public Setpoint As Integer
End Class

'DOC
Dim data As ProductionData = connection.ReadObject(Of ProductionData)()
data.Setpoint = 1200

'Writes Setpoint only, because Pieces is marked with CanWrite = False.
connection.WriteObject(data)
