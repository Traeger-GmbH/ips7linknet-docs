'DOC
Dim device = New SimaticDevice("192.168.0.80", type:=SimaticDeviceType.S71500)

device.Types.Add(PlcType.Of(Of Integer)(PlcAddress.Parse("DB1.DBD 0"), name:="Speed"))
device.Types.Add(PlcType.Of(Of Single)(PlcAddress.Parse("DB1.DBD 4"), name:="Temperature"))

'DOC
Dim speed As Integer = connection.ReadInt32("Speed")

Dim values As IDictionary(Of String, Object) = connection.Read("Speed", "Temperature")
Console.WriteLine("Temperature: {0}", values("Temperature"))
