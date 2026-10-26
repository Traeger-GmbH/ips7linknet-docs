// DOC
var device = new VirtualDevice();
 
using (var connection = device.CreateConnection()) {
    connection.Open();
 
    connection.WriteInt32("DB1.DBD 0", 1200);
    int speed = connection.ReadInt32("DB1.DBD 0");
}

// DOC
private static PlcDevice CreateDevice(bool simulate)
{
    if (simulate)
        return new VirtualDevice();
 
    return new SimaticDevice("192.168.0.80", type: SimaticDeviceType.S71500);
}
