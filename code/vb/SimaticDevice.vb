'DOC
Dim device = New SimaticDevice("192.168.0.80")
device.Type = SimaticDeviceType.S71200
device.ChannelType = SimaticChannelType.ProgrammerDevice

'DOC
Dim device = New SimaticDevice()
device.Type = SimaticDeviceType.S71500
device.ChannelType = SimaticChannelType.OperationPanel
device.EndPoint = New IPDeviceEndPoint("192.168.0.80", rack:=0, slot:=2)

'DOC
Dim device = New SimaticDevice("192.168.0.80")
device.Type = SimaticDeviceType.S71200
device.ChannelType = SimaticChannelType.ProgrammerDevice

'DOC
Dim device = New SimaticDevice()
device.Type = SimaticDeviceType.S71500
device.ChannelType = SimaticChannelType.OperationPanel
device.EndPoint = New IPDeviceEndPoint("192.168.0.80", rack:=0, slot:=1)

'DOC
Dim endPoint = New IPDeviceEndPoint("192.168.0.80")
endPoint.Port = 1102

Dim device = New SimaticDevice(endPoint, type:=SimaticDeviceType.S71500)
