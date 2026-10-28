// DOC
PlcDeviceConnection.UsePool = true;
 
var device = new SimaticDevice("192.168.0.80", type: SimaticDeviceType.S71500);
 
// Both connections share one connection to the PLC.
PlcDeviceConnection readConnection = device.CreateConnection(createNew: true);
PlcDeviceConnection writeConnection = device.CreateConnection(createNew: true);
 
readConnection.Open();
writeConnection.Open();
