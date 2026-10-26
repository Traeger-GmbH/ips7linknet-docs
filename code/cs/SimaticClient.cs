// DOC
using IPS7Lnk.Advanced;

// DOC
var client = new SimaticClient("s71500://192.168.0.80");

// DOC
client.Connect();

// DOC
// Your code to interact with the controller.

// DOC
client.Disconnect();

// DOC
using (var client = new SimaticClient("s71500://192.168.0.80")) {
    client.Connect();
    // Your code to interact with the controller.
}

// DOC
using (var client = new SimaticClient("s71500://192.168.0.80")) {
    client.Connect();
 
    float temperature = client.ReadValue<float>("DB10.DBD 20");
    Console.WriteLine("Temperature: {0}", temperature);
}
