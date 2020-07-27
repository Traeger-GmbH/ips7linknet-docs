// DOC
public class MillJob : PlcObject
{
    [PlcMember("DB1.DBD 20")]
    public int Input;

    [PlcMember("DB1.DBB 1")]
    public string Number;

    [PlcMember("DB1.DBD 25")]
    public int Output;

    [PlcMember("DB1.DBD 30")]
    public int RotationSpeed;

    [PlcMember("DB1.DBW 40")]
    public float ToolDiameter;
}
