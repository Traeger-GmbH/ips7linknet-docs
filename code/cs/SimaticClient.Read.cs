// DOC
int speed = client.ReadValue<int>("DB1.DBD 0");

// DOC
int[] coordinates = client.ReadValue<int>("DB2.DBD 0", count: 3);

// DOC
int[] values = client.ReadValues<int>(
        "DB1.DBD 0",
        "DB1.DBD 4",
        "DB1.DBD 8");

// DOC
var speedVariable = new PlcInt32("DB1.DBD 0");
int speed = client.ReadValue(speedVariable);

// DOC
var coordinatesVariable = new PlcInt32Array("DB2.DBD 0", length: 3);
int[] coordinates = client.ReadValue(coordinatesVariable);

// DOC
var speedVariable = new PlcInt32("DB1.DBD 0");
var coordinatesVariable = new PlcInt32Array("DB2.DBD 0", length: 3);
var jobIsActiveVariable = new PlcBoolean("DB3.DBX 0.0");
var toolSetupVariable = new PlcBooleanArray("DB4.DBX 0.0", length: 3);
var operatorNameVariable = new PlcString("DB5.DBB 0", length: 32);

// DOC
client.ReadValues(
        speedVariable,
        coordinatesVariable,
        jobIsActiveVariable,
        toolSetupVariable,
        operatorNameVariable);
 
Console.WriteLine("Speed: {0}", speedVariable.Value);
Console.WriteLine("Coordinates: {0}", string.Join(", ", coordinatesVariable.Value));
Console.WriteLine("Job is active: {0}", jobIsActiveVariable.Value);
Console.WriteLine("Tool setup: {0}", string.Join(", ", toolSetupVariable.Value));
Console.WriteLine("Operator: {0}", operatorNameVariable.Value);

// DOC
var counterVariable = new PlcInt32("DB10.DBD 0");
 
// Reads DB10.DBD 0, DB11.DBD 0 and DB12.DBD 0.
for (int station = 0; station < 3; station++) {
    var stationCounter = (PlcInt32)counterVariable.Relocate(operandNumber: station);
    int counter = client.ReadValue(stationCounter);
 
    Console.WriteLine("{0}: {1}", stationCounter.Type.Address, counter);
}

// DOC
PlcInt32[] values = Enumerable.Range(0, 100)
        .Select(index => new PlcInt32("DB10.DBD " + (index * 4)))
        .ToArray();
 
// The SDK packs the values into as few telegrams as the PDU size allows.
client.ReadValues(values);
