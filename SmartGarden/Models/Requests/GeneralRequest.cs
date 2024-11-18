namespace SharedRequests.SmartGarden.Models.Requests;

public class GeneralRequest : IRequest
{
    public Guid RequestId { get; set; }
    public bool UseRandomValuesFotTest { get; set; }
    public DateTime RequestDate { get; set; }
    public string RequestType { get; set; }
    public object Data { get; set; }
}