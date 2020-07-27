// DOC
var speedVariable = new PlcInt32("DB1.DBD 1");
var coordinatesVariable = new PlcInt32Array("DB2.DBD 1", 3);
var jobIsActiveVariable = new PlcBoolean("DB3.DBX 1.0");
var toolSetupVariable = new PlcBooleanArray("DB4.DBX 1.0", 5);
var operatorNameVariable = new PlcString("DB5.DBB 1", 32);
