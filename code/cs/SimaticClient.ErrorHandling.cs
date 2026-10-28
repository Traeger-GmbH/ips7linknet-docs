// DOC
try {
    int speed = client.ReadValue<int>("DB99.DBD 0");
}
catch (PlcException ex) when (ex.Code == PlcStatusCode.NoData) {
    Console.WriteLine("Missing data area: {0}", ex.Type.Address);
}

// DOC
try {
    client.Connect();
}
catch (PlcException ex) when (ex.Code == PlcStatusCode.Timeout) {
    Console.WriteLine("The PLC is not reachable: {0}", ex.Message);
 
    // The client stays usable; try again later.
    client.Connect();
}
