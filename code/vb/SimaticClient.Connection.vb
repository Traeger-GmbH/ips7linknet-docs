'DOC
Dim client = New SimaticClient("s7300://192.168.0.80?rack=0&slot=2")

'DOC
Dim client = New SimaticClient("s71200.pg://192.168.0.80")

'DOC
Dim client = New SimaticClient("s71500://plc-drill-001:1102")

'DOC
Dim client = New SimaticClient("s7300://192.168.0.80?local-tsap=AQA=&remote-tsap=AQI=")

'DOC
Dim client = New SimaticClient("s71500://192.168.0.80")
client.Configuration.ChannelType = SimaticChannelType.OperationPanel

'DOC
client.ConnectTimeout = 10000
client.OperationTimeout = 10000

'DOC
client.UseBreakDetection = True
client.BreakDetectionTimeout = 3000

'DOC
client.UseWatchDog = True
client.WatchDogInterval = 10000
