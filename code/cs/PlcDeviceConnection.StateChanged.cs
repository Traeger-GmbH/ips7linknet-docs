// DOC
connection.StateChanged += HandleConnectionStateChanged;

private static void HandleConnectionStateChanged(
        object sender,
        PlcDeviceConnectionStateChangedEventArgs e)
{
    if (connection.State == PlcDeviceConnectionState.Connected) {
        // ...
    }
}
