// DOC
var device = new SimaticDevice("192.168.0.80");
device.Type = SimaticDeviceType.S71200;
device.ChannelType = SiemensChannelType.ProgrammerDevice;

// DOC
var device = new SimaticDevice();
device.Type = SimaticDeviceType.S71500;
device.ChannelType = SiemensChannelType.OperationPanel;
device.EndPoint = new IPDeviceEndPoint("192.168.0.80", rack: 0, slot: 2);

// DOC
var device = new SimaticDevice("192.168.0.80");
device.Type = SimaticDeviceType.S71200;
device.ChannelType = SimaticChannelType.ProgrammerDevice;

// DOC
var device = new SimaticDevice();
device.Type = SimaticDeviceType.S71500;
device.ChannelType = SimaticChannelType.OperationPanel;
device.EndPoint = new IPDeviceEndPoint("192.168.0.80", rack: 0, slot: 1);

// DOC
var endPoint = new IPDeviceEndPoint("192.168.0.80");
endPoint.Port = 1102;
 
var device = new SimaticDevice(endPoint, type: SimaticDeviceType.S71500);
