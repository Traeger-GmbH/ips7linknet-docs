// DOC
var speedVariable = new PlcInt32("DB1.DBD 1");
connection.ReadValue(speedVariable);

if (speedVariable.Status.Code == PlcStatusCode.NoError) {
    // ...
}
