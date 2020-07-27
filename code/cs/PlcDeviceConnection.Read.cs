// DOC
int value = connection.ReadInt32("DB1.DBD 1");

// DOC
int[] values = connection.ReadInt32("DB1.DBD 1", 3);

// DOC
var speedVariable = new PlcInt32("DB1.DBD 1");
var speed = connection.ReadValue(speedVariable);

// DOC
var coordinatesVariable = new PlcInt32Array("DB1.DBD 1", 3);
var coordinates = connection.ReadValue(coordinatesVariable);

// DOC
connection.ReadValues(
        speedVariable,
        coordinatesVariable,
        jobIsActiveVariable,
        toolSetupVariable,
        operatorNameVariable);

Console.WriteLine($"Speed: {speedVariable.Value}");
Console.WriteLine($"Coordinates: {string.Join(",", coordinatesVariable.Value)}");
Console.WriteLine($"Job is Active: {jobIsActiveVariable.Value}");
Console.WriteLine($"Tool Setup: {string.Join(",", toolSetupVariable.Value)}");
Console.WriteLine($"Operator Name: {operatorNameVariable.Value}");


// DOC
MillJob job = connection.ReadObject<MillJob>();

Console.WriteLine("Input: {0}", job.Input);
Console.WriteLine("Number: {0}", job.Number);
Console.WriteLine("Output: {0}", job.Output);
Console.WriteLine("Rotation Speed: {0}", job.RotationSpeed);
Console.WriteLine("Total Diameter: {0}", job.ToolDiameter);
