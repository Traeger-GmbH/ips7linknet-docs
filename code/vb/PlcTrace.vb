'DOC
PlcTrace.WriteEntry = AddressOf HandleTraceEntry
PlcTrace.Level = PlcTraceLevel.All
PlcTrace.IsEnabled = True

'DOC
Private Shared Sub HandleTraceEntry(ByVal type As PlcTraceLevel, ByVal message As String)
    Console.WriteLine("{0}: {1}", type, message)
End Sub


'DOC
PlcTrace.Level = PlcTraceLevel.Error Or PlcTraceLevel.Warning Or PlcTraceLevel.Information
PlcTrace.WriteEntry = AddressOf HandleTraceEntryQueued
PlcTrace.IsEnabled = True

'DOC
Private Shared ReadOnly traceEntries As New BlockingCollection(Of String)()

Private Shared Sub HandleTraceEntryQueued(ByVal type As PlcTraceLevel, ByVal message As String)
    'Runs in the thread of the SDK call: queue the entry and write it elsewhere.
    traceEntries.Add(String.Format("{0}: {1}", type, message))
End Sub

