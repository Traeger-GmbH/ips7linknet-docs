// DOC
var a = PlcAddress.Parse("DB10.DBW 5");
var b = new PlcAddress(PlcOperand.DataBlock(10), PlcRawType.Word, 12);

// DOC
var a = PlcAddress.Parse("DB10.DBX 5.1");
var b = new PlcAddress(PlcOperand.DataBlock(10), PlcRawType.Bit, 5, 1);

// DOC
var a = PlcAddress.Parse("E8");
var b = new PlcAddress(PlcOperand.Input, PlcRawType.Byte, 8);

// DOC
var a = PlcAddress.Parse("M9.3");
var b = new PlcAddress(PlcOperand.Flag, PlcRawType.Bit, 9, 3);

// DOC
PlcAddress address = "DB3.DBB 10";
PlcAddress address = "MB 5";
PlcAddress address = "AW 2";
PlcAddress address = "QW 2";

// DOC
PlcAddress address = "DB3.DBB 10";
Console.WriteLine(address.ToString());                            // output: DB3.DBB 10

PlcAddress address = "MB 5";
Console.WriteLine(address.ToString());                            // output: MB 5

PlcAddress address = "AW 2";
Console.WriteLine(address.ToString());                            // output: AW 2
Console.WriteLine(address.ToString(PlcOperandStandard.IEC));      // output: QW 2
Console.WriteLine(address.ToString(PlcOperandStandard.Siemens));  // output: AW 2

PlcAddress address = "QW 2";
Console.WriteLine(address.ToString()); // output: AW 2
Console.WriteLine(address.ToString(PlcOperandStandard.IEC));      // output: QW 2
Console.WriteLine(address.ToString(PlcOperandStandard.Siemens));  // output: AW 2
