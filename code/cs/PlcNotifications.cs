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
