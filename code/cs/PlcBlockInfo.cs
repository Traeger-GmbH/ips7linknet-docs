// DOC
var device = new SimaticDevice("192.168.0.80", type: SimaticDeviceType.S71500);
PlcBlockInfo block = device.GetBlock(PlcOperand.DataBlock(10));
 
if (block.Exists)
    Console.WriteLine("DB10 has {0} bytes.", block.Size);

// DOC
foreach (PlcBlockInfo block in device.GetBlocks()) {
    Console.WriteLine("{0}: {1} bytes", block.Operand, block.Size);
}
