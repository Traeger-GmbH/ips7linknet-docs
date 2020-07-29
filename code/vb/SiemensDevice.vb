'DOC
Dim device = New SiemensDevice("192.168.0.80")
device.Type = SiemensDeviceType.S71200
device.ChannelType = SiemensChannelType.ProgrammerDevice

'DOC
Dim device = New SiemensDevice()
device.Type = SiemensDeviceType.S71500
device.ChannelType = SiemensChannelType.OperationPanel
device.EndPoint = New IPDeviceEndPoint("192.168.0.80", rack:=0, slot:=2)
