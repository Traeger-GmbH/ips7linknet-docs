// DOC
public class ProductionData : PlcObject
{
    [PlcMember("DB100.DBD 0", CanWrite = false)]
    public int Pieces;
 
    [PlcMember("DB100.DBD 4")]
    public int Setpoint;
}


// DOC
ProductionData data = connection.ReadObject<ProductionData>();
data.Setpoint = 1200;
 
// Writes Setpoint only, because Pieces is marked with CanWrite = false.
connection.WriteObject(data);
