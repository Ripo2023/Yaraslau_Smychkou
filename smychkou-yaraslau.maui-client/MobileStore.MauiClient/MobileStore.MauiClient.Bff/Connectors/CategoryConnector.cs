using MobileStore.MauiClient.Bff.Interfaces;
using MobileStore.MauiClient.Shared.RequestModels;
using MobileStore.MauiClient.Shared.ResponseModels;
using System.Text.Json;

namespace MobileStore.MauiClient.Bff.Connectors;

public class CategoryConnector : ICategoryConnector
{
    public async Task<IEnumerable<Category>> GetAllCategories()
    {
        using var client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:42143"),
        };

        using var request = new HttpRequestMessage(HttpMethod.Get, "api/categories");
        using var response = await client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<IEnumerable<Category>>(json);
    }

    public async Task<IEnumerable<ProductPreview>> GetCategoryProductsByPage(GetCategoryProductsRequestModel model)
    {
		using var client = new HttpClient
		{
			BaseAddress = new Uri("http://localhost:42143"),
		};

		using var request = new HttpRequestMessage(HttpMethod.Get, $"api/categories/{model.CategoryId}/products?pageSize={model.PageSize}&lastViewedId={model.LastViewedId}");
		using var response = await client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<IEnumerable<ProductPreview>>(response.Content.ToString());
	}
}
