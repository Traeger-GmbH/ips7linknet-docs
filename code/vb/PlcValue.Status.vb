'DOC
Dim speedVariable = New PlcInt32("DB1.DBD 1")
connection.ReadValue(speedVariable)

If speedVariable.Status.Code = PlcStatusCode.NoError Then
    ' ...
End If
