'DOC
Do
    Try
        client.Connect()
        Exit Do
    Catch ex As PlcException
        Console.WriteLine("Connecting failed ({0}), trying again.", ex.Code)
        Thread.Sleep(TimeSpan.FromSeconds(10))
    End Try
Loop


'DOC
Do
    Try
        Dim speed As Integer = client.ReadValue(Of Integer)("DB10.DBD 20")
        Console.WriteLine("Speed: {0}", speed)
    Catch ex As PlcException
        'The next pass connects again.
        Console.WriteLine("Reading failed ({0}).", ex.Code)
    End Try

    Thread.Sleep(TimeSpan.FromSeconds(1))
Loop

