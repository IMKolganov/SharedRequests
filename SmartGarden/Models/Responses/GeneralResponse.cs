namespace SharedRequests.SmartGarden.Models.Responses;

public class GeneralResponse<T> : IResponse
{
    public GeneralResponse()
    {
        Type = nameof(GeneralResponse<T>);
    }
    
    public Guid RequestId { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; }
    public DateTime ResponseDate { get; set; }
    public string ErrorMessage { get; set; }
    public T Data { get; set; }
    public string Type { get; set; }
}