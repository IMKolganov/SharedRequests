namespace SharedRequests.SmartGarden.Models.Responses;

public class PumpSwitcherResponse: IResponse
{
    public Guid RequestId { get; set; }
    public bool Success { get; set; }
    public int? PumpId { get; set; }
    public string? Message { get; set; }
    public DateTime ResponseDate { get; set; }
    public string Type { get; set; }
}
