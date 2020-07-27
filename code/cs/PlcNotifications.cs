// DOC
PlcNotifications.ConnectionCreated += HandleNotificationsConnectionCreated;

...

private static void HandleNotificationsConnectionCreated(
        object sender,
        PlcNotifications.PlcDeviceConnectionEventArgs e)
{
    var connection = e.Connection;

    if (...) {
        // ...
    }
}


// DOC
PlcNotifications.EvaluateStatus = EvaluateStatus;

...
        
private static bool EvaluateStatus(IPlcStatusProvider provider)
{
    if (provider is PlcDeviceConnection connection) {
        // ...
    }
    else if (provider is IPlcValue value) {
        // ...
    }

    // Fallback to "everything is okay".
    return true;
}
