'DOC
PlcDeviceConnection.UsePool = True

Dim device = New SimaticDevice("192.168.0.80", type:=SimaticDeviceType.S71500)

'Both connections share one connection to the PLC.
Dim readConnection As PlcDeviceConnection = device.CreateConnection(createNew:=True)
Dim writeConnection As PlcDeviceConnection = device.CreateConnection(createNew:=True)

readConnection.Open()
writeConnection.Open()
