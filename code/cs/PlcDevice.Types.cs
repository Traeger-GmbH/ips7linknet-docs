// DOC
var device = new SimaticDevice("192.168.0.80", type: SimaticDeviceType.S71500);
 
device.Types.Add(PlcType.Of<int>(PlcAddress.Parse("DB1.DBD 0"), name: "Speed"));
device.Types.Add(PlcType.Of<float>(PlcAddress.Parse("DB1.DBD 4"), name: "Temperature"));

// DOC
int speed = connection.ReadInt32("Speed");
 
IDictionary<string, object> values = connection.Read("Speed", "Temperature");
Console.WriteLine("Temperature: {0}", values["Temperature"]);
