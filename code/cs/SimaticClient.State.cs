// DOC
client.StateChanged += HandleClientStateChanged;

// DOC
private static void HandleClientStateChanged(
        object sender,
        SimaticClientStateChangedEventArgs e)
{
    Console.WriteLine(
            "Client state changed from {0} to {1}.",
            e.OldState,
            e.NewState);
}

// DOC
client.Disconnected += HandleClientDisconnected;
 
private static void HandleClientDisconnected(object sender, EventArgs e)
{
    // Your code to execute when the connection broke or has been closed.
}

// DOC
var speedVariable = new PlcInt32("DB1.DBD 0");
client.ReadValue(speedVariable);
 
if (speedVariable.Status.Code == PlcStatusCode.NoError) {
    // Your code to execute.
}
