'DOC
PlcNotifications.EvaluateStatus = AddressOf EvaluateMissingDataArea

Dim speedVariable = New PlcInt32("DB1.DBD 0")
Dim job = New MillJob()

'Reads when the results are enumerated, one result per entity.
For Each result As PlcEntityReadResult In connection.ReadEntities(speedVariable, job)
    Console.WriteLine("{0}: {1}", result.Entity.Type, result.Status.Code)
Next

'DOC
Private Shared Function EvaluateMissingDataArea(ByVal provider As IPlcStatusProvider) As Boolean
    'A missing data area is reported in the result instead of an exception.
    Return provider.Status.Code = PlcStatusCode.NoData
End Function

