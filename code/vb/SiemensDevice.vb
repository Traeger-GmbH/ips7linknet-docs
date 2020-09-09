'DOC
Dim device = New SimaticDevice("192.168.0.80")
device.Type = SimaticDeviceType.S71200
device.ChannelType = SiemensChannelType.ProgrammerDevice

'DOC
Dim device = New SimaticDevice()
device.Type = SimaticDeviceType.S71500
device.ChannelType = SiemensChannelType.OperationPanel
device.EndPoint = New IPDeviceEndPoint("192.168.0.80", rack:=0, slot:=2)
