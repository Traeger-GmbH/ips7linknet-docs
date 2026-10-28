'DOC
Dim device = New VirtualDevice()

Using connection = device.CreateConnection()
    connection.Open()

    connection.WriteInt32("DB1.DBD 0", 1200)
    Dim speed As Integer = connection.ReadInt32("DB1.DBD 0")
End Using

'DOC
Private Shared Function CreateDevice(ByVal simulate As Boolean) As PlcDevice
    If simulate Then _
        Return New VirtualDevice()

    Return New SimaticDevice("192.168.0.80", type:=SimaticDeviceType.S71500)
End Function


'DOC
Private Shared Function ReadPieces(ByVal connection As PlcDeviceConnection) As Integer
    Return connection.ReadInt32("DB1.DBD 0")
End Function


'DOC
Dim device = New VirtualDevice()

'The simulation keeps its data per connection: write and read on the same one.
Using connection = device.CreateConnection()
    connection.Open()
    connection.WriteInt32("DB1.DBD 0", 42)

    Dim pieces As Integer = ReadPieces(connection)
    Console.WriteLine("Pieces: {0}", pieces)
End Using
