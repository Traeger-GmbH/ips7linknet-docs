'DOC
PlcTracing.WriteEntry = AddressOf HandleTraceEntry
PlcTracing.Level = PlcTracingLevel.All
PlcTracing.IsEnabled = True

'DOC
Private Shared Sub HandleTraceEntry(ByVal type As PlcTracingLevel, ByVal message As String)
    Console.WriteLine("{0}: {1}", type, message)
End Sub


'DOC
PlcTracing.Level = PlcTracingLevel.Error Or PlcTracingLevel.Warning Or PlcTracingLevel.Information
PlcTracing.WriteEntry = AddressOf HandleTraceEntryQueued
PlcTracing.IsEnabled = True

'DOC
Private Shared ReadOnly traceEntries As New BlockingCollection(Of String)()

Private Shared Sub HandleTraceEntryQueued(ByVal type As PlcTracingLevel, ByVal message As String)
    'Runs in the thread of the SDK call: queue the entry and write it elsewhere.
    traceEntries.Add(String.Format("{0}: {1}", type, message))
End Sub

