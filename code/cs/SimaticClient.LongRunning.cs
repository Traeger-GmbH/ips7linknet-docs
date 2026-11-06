// DOC
while (true) {
    try {
        client.Connect();
        break;
    }
    catch (PlcException ex) {
        Console.WriteLine("Connecting failed ({0}), trying again.", ex.Code);
        Thread.Sleep(TimeSpan.FromSeconds(10));
    }
}

// DOC
while (true) {
    try {
        int speed = client.ReadValue<int>("DB10.DBD 20");
        Console.WriteLine("Speed: {0}", speed);
    }
    catch (PlcException ex) {
        // The next pass connects again.
        Console.WriteLine("Reading failed ({0}).", ex.Code);
    }
 
    Thread.Sleep(TimeSpan.FromSeconds(1));
}
