// DOC
PlcTrace.WriteEntry = HandleTraceEntry;
PlcTrace.Level = PlcTraceLevel.All;
PlcTrace.IsEnabled = true;

// DOC
private static void HandleTraceEntry(PlcTraceLevel type, string message)
{
    Console.WriteLine("{0}: {1}", type, message);
}

// DOC
PlcTrace.Level = PlcTraceLevel.Error | PlcTraceLevel.Warning | PlcTraceLevel.Information;
PlcTrace.WriteEntry = HandleTraceEntryQueued;
PlcTrace.IsEnabled = true;

// DOC
private static readonly BlockingCollection<string> traceEntries = new BlockingCollection<string>();
 
private static void HandleTraceEntryQueued(PlcTraceLevel type, string message)
{
    // Runs in the thread of the SDK call: queue the entry and write it elsewhere.
    traceEntries.Add(string.Format("{0}: {1}", type, message));
}
