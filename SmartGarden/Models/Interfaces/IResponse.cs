namespace SharedRequests.SmartGarden.Models;

public interface IResponse
{
    Guid RequestId { get; set; }
    bool Success { get; set; }
    string Message { get; set; }
    string ErrorMessage { get; set; }
    public DateTime ResponseDate { get; set; }
    string Type { get; set; }
}