'DOC
Dim a = PlcAddress.Parse("DB10.DBW 5")
Dim b = New PlcAddress(PlcOperand.DataBlock(10), PlcRawType.Word, 12)

'DOC
Dim a = PlcAddress.Parse("DB10.DBX 5.1")
Dim b = New PlcAddress(PlcOperand.DataBlock(10), PlcRawType.Bit, 5, 1)

'DOC
Dim a = PlcAddress.Parse("E8")
Dim b = New PlcAddress(PlcOperand.Input, PlcRawType.Byte, 8)

'DOC
Dim a = PlcAddress.Parse("M9.3")
Dim b = New PlcAddress(PlcOperand.Flag, PlcRawType.Bit, 9, 3)

'DOC
Dim address As PlcAddress = "DB3.DBB 10"
Dim address As PlcAddress = "MB 5"
Dim address As PlcAddress = "AW 2"
Dim address As PlcAddress = "QW 2"

'DOC
Dim address As PlcAddress = "DB3.DBB 10"
Console.WriteLine(address.ToString())                            ' output: DB3.DBB 10

Dim address As PlcAddress = "MB 5"
Console.WriteLine(address.ToString())                            ' output: MB 5

Dim address As PlcAddress = "AW 2"
Console.WriteLine(address.ToString())                            ' output: AW 2
Console.WriteLine(address.ToString(PlcOperandStandard.IEC))      ' output: QW 2
Console.WriteLine(address.ToString(PlcOperandStandard.Siemens))  ' output: AW 2

Dim address As PlcAddress = "QW 2"
Console.WriteLine(address.ToString())                            ' output: AW 2
Console.WriteLine(address.ToString(PlcOperandStandard.IEC))      ' output: QW 2
Console.WriteLine(address.ToString(PlcOperandStandard.Siemens))  ' output: AW 2
