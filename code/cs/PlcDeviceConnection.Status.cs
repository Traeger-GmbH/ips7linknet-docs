// DOC
PlcStatus status = connection.Status;
status.Changed += HandleConnectionStatusChanged;

// DOC
private static void HandleConnectionStatusChanged(object sender, EventArgs e)
{
    var status = (PlcStatus)sender;

    Console.WriteLine(status.TimeStamp);
    Console.WriteLine("- Code=[{0}]", status.Code);
    Console.WriteLine("- Text=[{0}]", status.Text);
    Console.WriteLine("- Exception=[{0}]", status.Exception?.Message ?? "<none>");
}
