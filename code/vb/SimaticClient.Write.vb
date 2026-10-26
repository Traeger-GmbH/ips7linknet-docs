'DOC
client.WriteValue("DB1.DBD 0", 1200)

'DOC
client.WriteValue("DB2.DBD 0", New Integer() {10, 20, 30})

'DOC
client.WriteValues( _
        New KeyValuePair(Of String, Integer)("DB1.DBD 0", 1200), _
        New KeyValuePair(Of String, Integer)("DB1.DBD 4", 1500))

'DOC
Dim speedVariable = New PlcInt32("DB1.DBD 0", 1200)
client.WriteValue(speedVariable)

speedVariable.Value = 1500
client.WriteValue(speedVariable)

'DOC
Dim coordinatesVariable = New PlcInt32Array("DB2.DBD 0", 10, 20, 30)
client.WriteValue(coordinatesVariable)

coordinatesVariable.Value(0) = 15
client.WriteValue(coordinatesVariable)

'DOC
speedVariable.Value += 100
coordinatesVariable.Value = {10, 20, 30}
jobIsActiveVariable.Value = True
toolSetupVariable.Value = {False, True, True}
operatorNameVariable.Value = "Operator"

client.WriteValues( _
        speedVariable, _
        coordinatesVariable, _
        jobIsActiveVariable, _
        toolSetupVariable, _
        operatorNameVariable)
