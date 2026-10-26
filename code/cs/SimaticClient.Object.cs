// DOC
MillJob job = client.ReadObject<MillJob>();
 
Console.WriteLine("Input: {0}", job.Input);
Console.WriteLine("Number: {0}", job.Number);
Console.WriteLine("Output: {0}", job.Output);
Console.WriteLine("Rotation speed: {0}", job.RotationSpeed);
Console.WriteLine("Tool diameter: {0}", job.ToolDiameter);

// DOC
var job = new MillJob();
job.Input = 1;
job.Number = "MJ:100012";
job.Output = 3;
job.RotationSpeed = 3500;
job.ToolDiameter = 12.8f;
 
client.WriteObject(job);
