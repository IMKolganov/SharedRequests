namespace SharedRequests.SmartGarden.Models.Responses;

public class TemperatureHumidityResponse : IResponse
{

    public TemperatureHumidityResponse()
    {
        
    }
    
    public TemperatureHumidityResponse(
        Guid requestId,
        bool success,
        string message,
        int sensorId,
        int temperature,
        int humidity)
    {
        RequestId = requestId;
        Success = success;
        Message = message;
        SensorId = sensorId;
        Temperature = temperature;
        Humidity = humidity;
        ResponseDate = DateTime.UtcNow;
    }
    
    public Guid RequestId { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }
    public DateTime ResponseDate { get; set; }
    public string Type { get; set; }
    public int SensorId { get; set; }
    public int Temperature { get; set; }
    public int Humidity { get; set; }
}