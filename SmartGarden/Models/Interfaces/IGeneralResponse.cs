namespace SharedRequests.SmartGarden.Models;

public interface IGeneralResponse<out T> : IResponse
{
    T? Data { get; }
}