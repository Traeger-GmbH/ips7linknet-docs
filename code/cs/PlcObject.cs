// DOC
public class MillJob : PlcObject
{
    [PlcMember("DB1.DBD 20")]
    public int Input;

    [PlcMember("DB1.DBB 1", Length = 16)]
    public string Number;

    [PlcMember("DB1.DBD 25")]
    public int Output;

    [PlcMember("DB1.DBD 30")]
    public int RotationSpeed;

    [PlcMember("DB1.DBW 40")]
    public float ToolDiameter;
}

// DOC
public class MachineData : PlcObject
{
    [PlcMember("DB1.DBX 100.0", Length = 7)]
    private bool[] toolConfigurations;

    public MachineData()
        : base()
    {
    }

    [PlcMember("DB1.DBB 120")]
    public DateTime EstimatedFinishDate { get; set; }

    [PlcMember("DB1.DBB 1", Length = 16)]
    public string JobNumber { get; set; }
    
    [PlcMember("DB1.DBD 100")]
    public int Speed { get; set; }
    
    [PlcMember("DB1.DBW 50")]
    public float Temperature { get; set; }
        
    [PlcMember("DB1.DBX 100.0")]
    public bool UseCuttingTool { get; set; }

    public bool IsToolConfigured(int toolIndex)
    {
        return this.toolConfigurations[toolIndex];
    }
}

// DOC
public class MillJob : PlcObject
{
    [PlcMember("DB1.DBD 0")]
    public int Input;
 
    [PlcMember("DB1.DBB 4", Length = 16)]
    public string Number;
 
    [PlcMember("DB1.DBD 22")]
    public int Output;
 
    [PlcMember("DB1.DBD 26")]
    public int RotationSpeed;
 
    [PlcMember("DB1.DBD 30")]
    public float ToolDiameter;
}


// DOC
public class MachineData : PlcObject
{
    [PlcMember("DB1.DBX 100.0", Length = 7)]
    private bool[] toolConfigurations;
 
    public MachineData()
        : base()
    {
    }
 
    [PlcMember("DB1.DBX 100.7")]
    public bool UseCuttingTool { get; set; }
 
    [PlcMember("DB1.DBD 102")]
    public int Speed { get; set; }
 
    [PlcMember("DB1.DBD 106")]
    public float Temperature { get; set; }
 
    [PlcMember("DB1.DBB 110", Length = 16)]
    public string JobNumber { get; set; }
 
    [PlcMember("DB1.DBB 128")]
    public DateTime EstimatedFinishDate { get; set; }
 
    public bool IsToolConfigured(int toolIndex)
    {
        return this.toolConfigurations[toolIndex];
    }
}
