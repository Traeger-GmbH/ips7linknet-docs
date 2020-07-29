'DOC
Dim status As PlcStatus = connection.Status
status.Changed += AddressOf HandleConnectionStatusChanged

'DOC
Private Shared Sub HandleConnectionStatusChanged(ByVal sender As Object, ByVal e As EventArgs)
    Dim status = CType(sender, PlcStatus)

    Console.WriteLine(status.TimeStamp)
    Console.WriteLine("- Code=[{0}]", status.Code)
    Console.WriteLine("- Text=[{0}]", status.Text)
    Console.WriteLine("- Exception=[{0}]", If(status.Exception?.Message, "<none>"))
End Sub
