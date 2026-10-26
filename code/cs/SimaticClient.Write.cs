// DOC
client.WriteValue("DB1.DBD 0", 1200);

// DOC
client.WriteValue("DB2.DBD 0", new[] { 10, 20, 30 });

// DOC
client.WriteValues(
        new KeyValuePair<string, int>("DB1.DBD 0", 1200),
        new KeyValuePair<string, int>("DB1.DBD 4", 1500));

// DOC
var speedVariable = new PlcInt32("DB1.DBD 0", 1200);
client.WriteValue(speedVariable);
 
speedVariable.Value = 1500;
client.WriteValue(speedVariable);

// DOC
var coordinatesVariable = new PlcInt32Array("DB2.DBD 0", 10, 20, 30);
client.WriteValue(coordinatesVariable);
 
coordinatesVariable.Value[0] = 15;
client.WriteValue(coordinatesVariable);

// DOC
speedVariable.Value += 100;
coordinatesVariable.Value = new[] { 10, 20, 30 };
jobIsActiveVariable.Value = true;
toolSetupVariable.Value = new[] { false, true, true };
operatorNameVariable.Value = "Operator";
 
client.WriteValues(
        speedVariable,
        coordinatesVariable,
        jobIsActiveVariable,
        toolSetupVariable,
        operatorNameVariable);
