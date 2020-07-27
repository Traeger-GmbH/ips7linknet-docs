// DOC
var device = new SiemensDevice("192.168.0.80");
device.Type = SiemensDeviceType.S71200;
device.ChannelType = SiemensChannelType.ProgrammerDevice;

// DOC
var device = new SiemensDevice();
device.Type = SiemensDeviceType.S71500;
device.ChannelType = SiemensChannelType.OperationPanel;
device.EndPoint = new IPDeviceEndPoint("192.168.0.80", rack: 0, slot: 2);
