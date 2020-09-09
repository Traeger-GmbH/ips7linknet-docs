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
