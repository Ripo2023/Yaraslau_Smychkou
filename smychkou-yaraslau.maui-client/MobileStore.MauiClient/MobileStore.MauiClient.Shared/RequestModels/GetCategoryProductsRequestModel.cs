namespace MobileStore.MauiClient.Shared.RequestModels;

public class GetCategoryProductsRequestModel : GetByPageRequestModel
{
    public int CategoryId { get; set; }
}
