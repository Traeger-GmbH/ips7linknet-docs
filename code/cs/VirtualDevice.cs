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

// DOC
private static int ReadPieces(PlcDeviceConnection connection)
{
    return connection.ReadInt32("DB1.DBD 0");
}

// DOC
var device = new VirtualDevice();
 
// The simulation keeps its data per connection: write and read on the same one.
using (var connection = device.CreateConnection()) {
    connection.Open();
    connection.WriteInt32("DB1.DBD 0", 42);
 
    int pieces = ReadPieces(connection);
    Console.WriteLine("Pieces: {0}", pieces);
}
