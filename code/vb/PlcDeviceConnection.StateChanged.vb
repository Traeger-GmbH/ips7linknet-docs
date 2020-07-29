'DOC
AddHandler connection.StateChanged, AddressOf HandleConnectionStateChanged

Private Shared Sub HandleConnectionStateChanged( _
        ByVal sender As Object, _
        ByVal e As PlcDeviceConnectionStateChangedEventArgs)
    If connection.State = PlcDeviceConnectionState.Connected Then
        ' ...
    End If
End Sub
