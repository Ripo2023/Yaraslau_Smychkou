using MobileStore.MauiClient.Bff.Connectors;
using MobileStore.MauiClient.Bff.Interfaces;
using MobileStore.MauiClient.Bll.Interfaces;
using MobileStore.MauiClient.Bll.Services;
namespace MobileStore.MauiClient;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		#endif
		
        builder.Services.AddSingleton<IOnboardingService, OnboardingService>();

        builder.Services.AddTransient<ICategoryService, CategoryService>();
		builder.Services.AddTransient<IOrderService, OrderService>();
		builder.Services.AddTransient<IProductService, ProductService>();

        builder.Services.AddTransient<ICategoryConnector, CategoryConnector>();
        builder.Services.AddTransient<IOrderConnector, OrderConnector>();
        builder.Services.AddTransient<IProductConnector, ProductConnector>();

        return builder.Build();
	}
}
