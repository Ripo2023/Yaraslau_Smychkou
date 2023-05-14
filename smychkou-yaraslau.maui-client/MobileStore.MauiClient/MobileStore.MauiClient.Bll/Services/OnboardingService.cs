using MobileStore.MauiClient.Bll.Models;

namespace MobileStore.MauiClient.Bll.Services;

public class OnboardingService
{
    private readonly OnboardingContent[] Onboarding = new[]
    {
        new OnboardingContent
        {
            Id = 1,
            Title = "Hello!",
            ImagePath = "Someimagepath1",
            Description = "Some description 1",
            PagesCount = 4,
        },
        new OnboardingContent
        {
            Id = 2,
            Title = "Search for a coffee shop!",
            ImagePath = "Someimagepath2",
            Description = "Some description 2",
            PagesCount = 4,
        },
        new OnboardingContent
        {
            Id = 3,
            Title = "Making an order!",
            ImagePath = "Someimagepath3",
            Description = "Some description 3",
            PagesCount = 4,
        },
        new OnboardingContent
        {
            Id = 4,
            Title = "Receiving an order!",
            ImagePath = "Someimagepath4",
            Description = "Some description 4",
            PagesCount = 4,
        },
    };

    public Task<OnboardingContent> GetOnboardingContentAsync(int index)
    {
        return Task.FromResult(Onboarding[index]);
    }
}
