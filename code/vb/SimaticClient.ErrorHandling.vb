'DOC
Try
    Dim speed As Integer = client.ReadValue(Of Integer)("DB99.DBD 0")
Catch ex As PlcException When ex.Code = PlcStatusCode.NoData
    Console.WriteLine("Missing data area: {0}", ex.Type.Address)
End Try


'DOC
Try
    client.Connect()
Catch ex As PlcException When ex.Code = PlcStatusCode.Timeout
    Console.WriteLine("The PLC is not reachable: {0}", ex.Message)

    'The client stays usable; try again later.
    client.Connect()
End Try

