'DOC
Dim speedVariable = New PlcInt32("DB1.DBD 1")
Dim coordinatesVariable = New PlcInt32Array("DB2.DBD 1", 3)
Dim jobIsActiveVariable = New PlcBoolean("DB3.DBX 1.0")
Dim toolSetupVariable = New PlcBooleanArray("DB4.DBX 1.0", 5)
Dim operatorNameVariable = New PlcString("DB5.DBB 1", 32)
