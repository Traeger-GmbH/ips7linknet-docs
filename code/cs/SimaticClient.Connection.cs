// DOC
var client = new SimaticClient("s7300://192.168.0.80?rack=0&slot=2");

// DOC
var client = new SimaticClient("s71200.pg://192.168.0.80");

// DOC
var client = new SimaticClient("s71500://plc-drill-001:1102");

// DOC
var client = new SimaticClient("s7300://192.168.0.80?local-tsap=AQA=&remote-tsap=AQI=");

// DOC
var client = new SimaticClient("s71500://192.168.0.80");
client.Configuration.ChannelType = SimaticChannelType.OperationPanel;

// DOC
client.ConnectTimeout = 10000;
client.OperationTimeout = 10000;

// DOC
client.UseBreakDetection = true;
client.BreakDetectionTimeout = 3000;

// DOC
client.UseWatchDog = true;
client.WatchDogInterval = 10000;
