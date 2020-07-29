'DOC
connection.WriteInt32("DB1.DBD 1", 123)

'DOC
connection.WriteInt32("DB1.DBD 1", 123, 456, 789)

'DOC
Dim speedVariable = New PlcInt32("DB1.DBD 1", 123)
connection.WriteValue(speedVariable)

speedVariable.Value = 1200
connection.WriteValue(speedVariable)

'DOC
Dim coordinatesVariable = New PlcInt32Array("DB1.DBD 1", 123, 456, 789)
connection.WriteValue(coordinatesVariable)

coordinatesVariable.Value(0) = 10
coordinatesVariable.Value(1) = 20
coordinatesVariable.Value(2) = 30
connection.WriteValue(coordinatesVariable)

'DOC
speedVariable.Value += 100
coordinatesVariable.Value = {10, 20, 30}
jobIsActiveVariable.Value = True
toolSetupVariable.Value = {False, True, True}
operatorNameVariable.Value = Environment.UserName

connection.WriteValues( _
        speedVariable, _
        coordinatesVariable, _
        jobIsActiveVariable, _
        toolSetupVariable, _
        operatorNameVariable)


'DOC
Dim job As MillJob = New MillJob()
job.Input = 1
job.Number = "MJ:100012"
job.RotationSpeed = 3500
job.ToolDiameter = 12.8F
job.Output = 3

connection.WriteObject(job)
