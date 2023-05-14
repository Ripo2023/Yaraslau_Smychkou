using MobileStore.MauiClient.Bll.Models;

namespace MobileStore.MauiClient.Bll.Interfaces;

public interface IOnboardingService
{
    Task<OnboardingContent> GetOnboardingContentAsync(int index);
}
