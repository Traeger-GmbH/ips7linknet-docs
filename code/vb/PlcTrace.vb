'DOC
PlcTrace.WriteEntry = AddressOf HandleTraceEntry
PlcTrace.Level = PlcTraceLevel.All
PlcTrace.IsEnabled = True

'DOC
Private Shared Sub HandleTraceEntry(ByVal type As PlcTraceLevel, ByVal message As String)
    Console.WriteLine("{0}: {1}", type, message)
End Sub

