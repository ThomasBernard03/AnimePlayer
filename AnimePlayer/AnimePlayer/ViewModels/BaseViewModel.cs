using ReactiveUI;

namespace AnimePlayer.ViewModels;

public class BaseViewModel : ReactiveObject, INavigatedAware, IInitializeAsync
{
    protected INavigationService NavigationService;
    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    public async Task InitializeAsync(INavigationParameters parameters)
    {
    }

    public virtual void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public virtual void OnNavigatedTo(INavigationParameters parameters)
    {
    }
}
