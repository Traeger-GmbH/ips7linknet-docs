'DOC
Dim job As MillJob = client.ReadObject(Of MillJob)()

Console.WriteLine("Input: {0}", job.Input)
Console.WriteLine("Number: {0}", job.Number)
Console.WriteLine("Output: {0}", job.Output)
Console.WriteLine("Rotation speed: {0}", job.RotationSpeed)
Console.WriteLine("Tool diameter: {0}", job.ToolDiameter)

'DOC
Dim job = New MillJob()
job.Input = 1
job.Number = "MJ:100012"
job.Output = 3
job.RotationSpeed = 3500
job.ToolDiameter = 12.8F

client.WriteObject(job)

'DOC
Dim machine = New MachineData()
AddHandler machine.PropertyChanged, AddressOf HandleMachinePropertyChanged

'Raises PropertyChanged for each property whose value has changed.
client.ReadObject(machine)

'DOC
Private Shared Sub HandleMachinePropertyChanged( _
        ByVal sender As Object, _
        ByVal e As PropertyChangedEventArgs)
    Dim machine = CType(sender, MachineData)

    Console.WriteLine("{0}: {1}", e.PropertyName, machine(e.PropertyName))
End Sub

