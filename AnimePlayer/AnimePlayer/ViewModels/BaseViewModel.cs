using ReactiveUI;

namespace AnimePlayer.ViewModels;

public abstract class BaseViewModel : ReactiveObject, INavigatedAware, IInitializeAsync
{
    protected INavigationService NavigationService;

    #region PageTitle
    private string _pageTitle;
    public string PageTitle
    {
        get => _pageTitle;
        set => this.RaiseAndSetIfChanged(ref _pageTitle, value);
    }
    #endregion

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
