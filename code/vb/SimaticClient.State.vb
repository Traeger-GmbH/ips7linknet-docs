'DOC
AddHandler client.StateChanged, AddressOf HandleClientStateChanged

'DOC
Private Shared Sub HandleClientStateChanged( _
        ByVal sender As Object, _
        ByVal e As SimaticClientStateChangedEventArgs)
    Console.WriteLine( _
            "Client state changed from {0} to {1}.", _
            e.OldState, _
            e.NewState)
End Sub


'DOC
AddHandler client.Disconnected, AddressOf HandleClientDisconnected

Private Shared Sub HandleClientDisconnected(ByVal sender As Object, ByVal e As EventArgs)
    'Your code to execute when the connection broke or has been closed.
End Sub


'DOC
Dim speedVariable = New PlcInt32("DB1.DBD 0")
client.ReadValue(speedVariable)

If speedVariable.Status.Code = PlcStatusCode.NoError Then
    'Your code to execute.
End If
