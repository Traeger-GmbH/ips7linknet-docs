// DOC
connection.WriteInt32("DB1.DBD 1", 123);

// DOC
connection.WriteInt32("DB1.DBD 1", 123, 456, 789);

// DOC
var speedVariable = new PlcInt32("DB1.DBD 1", 123);
connection.WriteValue(speedVariable);

speedVariable.Value = 1200;
connection.WriteValue(speedVariable);

// DOC
var coordinatesVariable = new PlcInt32Array("DB1.DBD 1", 123, 456, 789);
connection.WriteValue(coordinatesVariable);

coordinatesVariable.Value[0] = 10;
coordinatesVariable.Value[1] = 20;
coordinatesVariable.Value[2] = 30;
connection.WriteValue(coordinatesVariable);
