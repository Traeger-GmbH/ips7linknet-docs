'DOC
Dim value As Integer = connection.ReadInt32("DB1.DBD 1")

'DOC
Dim values As Integer() = connection.ReadInt32("DB1.DBD 1", 3)

'DOC
Dim speedVariable = New PlcInt32("DB1.DBD 1")
Dim speed = connection.ReadValue(speedVariable)

'DOC
Dim coordinatesVariable = New PlcInt32Array("DB1.DBD 1", 3)
Dim coordinates = connection.ReadValue(coordinatesVariable)

'DOC
connection.ReadValues( _
        speedVariable, _
        coordinatesVariable, _
        jobIsActiveVariable, _
        toolSetupVariable, _
        operatorNameVariable)

Console.WriteLine($"Speed: {speedVariable.Value}")
Console.WriteLine($"Coordinates: {String.Join(",", coordinatesVariable.Value)}")
Console.WriteLine($"Job is Active: {jobIsActiveVariable.Value}")
Console.WriteLine($"Tool Setup: {String.Join(",", toolSetupVariable.Value)}")
Console.WriteLine($"Operator Name: {operatorNameVariable.Value}")


'DOC
Dim job As MillJob = connection.ReadObject(Of MillJob)()
Console.WriteLine("Input: {0}", job.Input)
Console.WriteLine("Number: {0}", job.Number)
Console.WriteLine("Output: {0}", job.Output)
Console.WriteLine("Rotation Speed: {0}", job.RotationSpeed)
Console.WriteLine("Total Diameter: {0}", job.ToolDiameter)
