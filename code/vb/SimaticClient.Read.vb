'DOC
Dim speed As Integer = client.ReadValue(Of Integer)("DB1.DBD 0")

'DOC
Dim coordinates As Integer() = client.ReadValue(Of Integer)("DB2.DBD 0", count:=3)

'DOC
Dim values As Integer() = client.ReadValues(Of Integer)( _
        "DB1.DBD 0", _
        "DB1.DBD 4", _
        "DB1.DBD 8")

'DOC
Dim speedVariable = New PlcInt32("DB1.DBD 0")
Dim speed As Integer = client.ReadValue(speedVariable)

'DOC
Dim coordinatesVariable = New PlcInt32Array("DB2.DBD 0", length:=3)
Dim coordinates As Integer() = client.ReadValue(coordinatesVariable)

'DOC
Dim speedVariable = New PlcInt32("DB1.DBD 0")
Dim coordinatesVariable = New PlcInt32Array("DB2.DBD 0", length:=3)
Dim jobIsActiveVariable = New PlcBoolean("DB3.DBX 0.0")
Dim toolSetupVariable = New PlcBooleanArray("DB4.DBX 0.0", length:=3)
Dim operatorNameVariable = New PlcString("DB5.DBB 0", length:=32)

'DOC
client.ReadValues( _
        speedVariable, _
        coordinatesVariable, _
        jobIsActiveVariable, _
        toolSetupVariable, _
        operatorNameVariable)

Console.WriteLine("Speed: {0}", speedVariable.Value)
Console.WriteLine("Coordinates: {0}", String.Join(", ", coordinatesVariable.Value))
Console.WriteLine("Job is active: {0}", jobIsActiveVariable.Value)
Console.WriteLine("Tool setup: {0}", String.Join(", ", toolSetupVariable.Value))
Console.WriteLine("Operator: {0}", operatorNameVariable.Value)
