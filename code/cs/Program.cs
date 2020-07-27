// DOC
using IPS7Lnk.Advanced;

// DOC
var device = new SiemensDevice("192.168.0.80");

// DOC
var connection = device.CreateConnection();
connection.Open();

// DOC
// Your code to interact with the controller.

// DOC
connection.Close();

// DOC
using (var connection = device.CreateConnection()) {
    connection.Open();
    // Your code to interact with the controller.
}
