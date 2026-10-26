'DOC
Dim device = New SimaticDevice("192.168.0.80", type:=SimaticDeviceType.S71500)
Dim block As PlcBlockInfo = device.GetBlock(PlcOperand.DataBlock(10))

If block.Exists Then _
    Console.WriteLine("DB10 has {0} bytes.", block.Size)

'DOC
For Each block As PlcBlockInfo In device.GetBlocks()
    Console.WriteLine("{0}: {1} bytes", block.Operand, block.Size)
Next
