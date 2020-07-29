'DOC
PlcNotifications.ConnectionCreated += AddressOf HandleNotificationsConnectionCreated

...

Private Shared Sub HandleNotificationsConnectionCreated( _
        ByVal sender As Object, _
        ByVal e As PlcNotifications.PlcDeviceConnectionEventArgs)
    Dim connection = e.Connection

    If ... Then
        ' ...
    End If
End Sub



'DOC
PlcNotifications.EvaluateStatus = AddressOf EvaluateStatus

...

Private Shared Function EvaluateStatus(ByVal provider As IPlcStatusProvider) As Boolean
    Dim connection As PlcDeviceConnection = TryCast(provider, PlcDeviceConnection)
    Dim value As IPlcValue = TryCast(provider, IPlcValue)

    If connection IsNot Nothing Then
        ' ...
    ElseIf value IsNot Nothing Then
        ' ...
    End If

    Return True
End Function
