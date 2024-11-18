namespace SharedRequests.SmartGarden.Models.Responses;

public class SoilMoistureResponse: IResponse
{
    public Guid RequestId { get; set; }
    public bool Success { get; set; }
    public int SensorId { get; set; }
    public string Message { get; set; }
    public DateTime ResponseDate { get; set; }
    public double? SoilMoistureLevelPercent { get; set; }
    public string Type { get; set; }
}
