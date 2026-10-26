// DOC
var device = new SimaticDevice("192.168.0.80");
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

// DOC
var device = new SimaticDevice("192.168.0.80");
IPlcDeviceInfo info = device.GetInfo();
 
if (info.HasName)
    Console.WriteLine("Name: {0}", info.Name);
 
if (info.HasLocation)
    Console.WriteLine("Location: {0}", info.Location);
 
if (info.HasModuleName)
    Console.WriteLine("Module name: {0}", info.ModuleName);
 
if (info.HasModuleType)
    Console.WriteLine("Module type: {0}", info.ModuleType);
 
if (info.HasModuleSerial)
    Console.WriteLine("Module serial: {0}", info.ModuleSerial);
 
if (info.HasMemoryCardSerial)
    Console.WriteLine("Memory card serial: {0}", info.MemoryCardSerial);
 
if (info.HasPlantId)
    Console.WriteLine("Plant ID: {0}", info.PlantId);
 
if (info.HasTime)
    Console.WriteLine("Time: {0}", info.Time);
 
if (info.HasCopyright)
    Console.WriteLine("Copyright: {0}", info.Copyright);
