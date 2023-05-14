namespace MobileStore.MauiClient.Shared.RequestModels;

public class GetByPageRequestModel
{
    public int? LastViewedId { get; set; }

    public byte PageSize { get; set; }
}
