// DOC
var device = new SiemensDevice("192.168.0.80");
var deviceInfo = device.GetInfo();

if (deviceInfo.HasName)
    Console.WriteLine($"Name:         {deviceInfo.Name}");

if (deviceInfo.HasLocation)
    Console.WriteLine($"Location:     {deviceInfo.Location}");

if (deviceInfo.HasModuleName)
    Console.WriteLine($"Modul Name:   {deviceInfo.ModuleName}");

if (deviceInfo.HasModuleType)
    Console.WriteLine($"Modul Type:   {deviceInfo.ModuleType}");

if (deviceInfo.HasModuleSerial)
    Console.WriteLine($"Modul Serial: {deviceInfo.ModuleSerial}");

if (deviceInfo.HasPlantId)
    Console.WriteLine($"Plant ID:     {deviceInfo.PlantId}");

if (deviceInfo.HasTime)
    Console.WriteLine($"Time:         {deviceInfo.Time}");

if (deviceInfo.HasCopyright)
    Console.WriteLine($"Copyright:    {deviceInfo.Copyright}");
