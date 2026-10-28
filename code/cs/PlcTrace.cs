// DOC
PlcTracing.WriteEntry = HandleTraceEntry;
PlcTracing.Level = PlcTracingLevel.All;
PlcTracing.IsEnabled = true;

// DOC
private static void HandleTraceEntry(PlcTracingLevel type, string message)
{
    Console.WriteLine("{0}: {1}", type, message);
}

// DOC
PlcTracing.Level = PlcTracingLevel.Error | PlcTracingLevel.Warning | PlcTracingLevel.Information;
PlcTracing.WriteEntry = HandleTraceEntryQueued;
PlcTracing.IsEnabled = true;

// DOC
private static readonly BlockingCollection<string> traceEntries = new BlockingCollection<string>();
 
private static void HandleTraceEntryQueued(PlcTracingLevel type, string message)
{
    // Runs in the thread of the SDK call: queue the entry and write it elsewhere.
    traceEntries.Add(string.Format("{0}: {1}", type, message));
}
