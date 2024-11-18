namespace SharedRequests.SmartGarden.Models.Responses;

public class SoilMoistureResponse: IResponse
{
    public SoilMoistureResponse()
    {
        Type = nameof(SoilMoistureResponse);
    }
    public SoilMoistureResponse(
        Guid requestId,
        bool success,
        int sensorId,
        string message,
        double? soilMoistureLevelPercent)
    {
        RequestId = requestId;
        Success = success;
        SensorId = sensorId;
        Message = message;
        SoilMoistureLevelPercent = soilMoistureLevelPercent;
        ResponseDate = DateTime.UtcNow;
        Type = nameof(SoilMoistureResponse);
    }
    
    
    public Guid RequestId { get; set; }
    public bool Success { get; set; }
    public int SensorId { get; set; }
    public string Message { get; set; }
    public DateTime ResponseDate { get; set; }
    public double? SoilMoistureLevelPercent { get; set; }
    public string Type { get; set; }
}
