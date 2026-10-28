// DOC
PlcNotifications.EvaluateStatus = EvaluateMissingDataArea;
 
var speedVariable = new PlcInt32("DB1.DBD 0");
var job = new MillJob();
 
// Reads when the results are enumerated, one result per entity.
foreach (PlcEntityReadResult result in connection.ReadEntities(speedVariable, job)) {
    Console.WriteLine("{0}: {1}", result.Entity.Type, result.Status.Code);
}

// DOC
private static bool EvaluateMissingDataArea(IPlcStatusProvider provider)
{
    // A missing data area is reported in the result instead of an exception.
    return provider.Status.Code == PlcStatusCode.NoData;
}
