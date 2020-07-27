// DOC
int value = connection.ReadInt32("DB1.DBD 1");

// DOC
int[] values = connection.ReadInt32("DB1.DBD 1", 3);

// DOC
var speedVariable = new PlcInt32("DB1.DBD 1");
var speed = connection.ReadValue(speedVariable);

// DOC
var coordinatesVariable = new PlcInt32("DB1.DBD 1", 3);
var coordinates = connection.ReadValue(coordinatesVariable);
