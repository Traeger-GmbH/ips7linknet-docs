'DOC
Imports IPS7Lnk.Advanced

'DOC
Dim client = New SimaticClient("s71500://192.168.0.80")

'DOC
client.Connect()

'DOC
'Your code to interact with the controller.

'DOC
client.Disconnect()

'DOC
Using client = New SimaticClient("s71500://192.168.0.80")
    client.Connect()
    'Your code to interact with the controller.
End Using

'DOC
Using client = New SimaticClient("s71500://192.168.0.80")
    client.Connect()

    Dim temperature As Single = client.ReadValue(Of Single)("DB10.DBD 20")
    Console.WriteLine("Temperature: {0}", temperature)
End Using
