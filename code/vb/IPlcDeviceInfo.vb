'DOC
Dim device = New SimaticDevice("192.168.0.80")
Dim deviceInfo = device.GetInfo()

If deviceInfo.HasName Then _
    Console.WriteLine($"Name:         {deviceInfo.Name}")

If deviceInfo.HasLocation Then _
    Console.WriteLine($"Location:     {deviceInfo.Location}")

If deviceInfo.HasModuleName Then _
    Console.WriteLine($"Modul Name:   {deviceInfo.ModuleName}")

If deviceInfo.HasModuleType Then _
    Console.WriteLine($"Modul Type:   {deviceInfo.ModuleType}")

If deviceInfo.HasModuleSerial Then _
    Console.WriteLine($"Modul Serial: {deviceInfo.ModuleSerial}")

If deviceInfo.HasPlantId Then _
    Console.WriteLine($"Plant ID:     {deviceInfo.PlantId}")

If deviceInfo.HasTime Then _
    Console.WriteLine($"Time:         {deviceInfo.Time}")

If deviceInfo.HasCopyright Then _
    Console.WriteLine($"Copyright:    {deviceInfo.Copyright}")

'DOC
Dim device = New SimaticDevice("192.168.0.80")
Dim info As IPlcDeviceInfo = device.GetInfo()

If info.HasName Then _
    Console.WriteLine("Name: {0}", info.Name)

If info.HasLocation Then _
    Console.WriteLine("Location: {0}", info.Location)

If info.HasModuleName Then _
    Console.WriteLine("Module name: {0}", info.ModuleName)

If info.HasModuleType Then _
    Console.WriteLine("Module type: {0}", info.ModuleType)

If info.HasModuleSerial Then _
    Console.WriteLine("Module serial: {0}", info.ModuleSerial)

If info.HasMemoryCardSerial Then _
    Console.WriteLine("Memory card serial: {0}", info.MemoryCardSerial)

If info.HasPlantId Then _
    Console.WriteLine("Plant ID: {0}", info.PlantId)

If info.HasTime Then _
    Console.WriteLine("Time: {0}", info.Time)

If info.HasCopyright Then _
    Console.WriteLine("Copyright: {0}", info.Copyright)
