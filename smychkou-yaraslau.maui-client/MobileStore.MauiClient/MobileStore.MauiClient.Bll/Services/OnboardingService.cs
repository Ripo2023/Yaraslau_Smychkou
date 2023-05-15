using MobileStore.MauiClient.Bll.Interfaces;
using MobileStore.MauiClient.Bll.Models;

namespace MobileStore.MauiClient.Bll.Services;

public class OnboardingService : IOnboardingService
{
    private readonly OnboardingContent[] Onboarding = new[]
    {
        new OnboardingContent
        {
            Id = 1,
            Title = "Hello!",
            ImagePath = "./assets/onboarding/Onboarding 1.png",
            Description = "Coffee to Go is an application in which you can order coffee online and pick up at the coffee shop closest to you. Now let's tell you how it works",
            PagesCount = 4,
        },
        new OnboardingContent
        {
            Id = 2,
            Title = "Search for a coffee shop!",
            ImagePath = "./assets/onboarding/Onboarding 2.png",
            Description = "The map shows the nearest coffee shops to you, choose the most convenient one for you. The app will tell you how long to to it",
            PagesCount = 4,
        },
        new OnboardingContent
        {
            Id = 3,
            Title = "Making an order!",
            ImagePath = "./assets/onboarding/Onboarding 3.png",
            Description = "Choose your favorite drinks and deserts. You can change their composition and choose the timewhen it will be convenient for you to pick them up",
            PagesCount = 4,
        },
        new OnboardingContent
        {
            Id = 4,
            Title = "Receiving an order!",
            ImagePath = "./assets/onboarding/Onboarding 4.png",
            Description = "At the specified time, come to the coffee shop and enjoy the taste of coffee, without queuing and waiting",
            PagesCount = 4,
        },
    };

    public Task<OnboardingContent> GetOnboardingContentAsync(int index)
    {
        return Task.FromResult(Onboarding[index]);
    }
}
