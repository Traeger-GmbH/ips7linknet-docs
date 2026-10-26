// DOC
PlcTrace.WriteEntry = HandleTraceEntry;
PlcTrace.Level = PlcTraceLevel.All;
PlcTrace.IsEnabled = true;

// DOC
private static void HandleTraceEntry(PlcTraceLevel type, string message)
{
    Console.WriteLine("{0}: {1}", type, message);
}
