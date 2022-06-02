using AnimePlayer.Commons;
using AnimePlayer.Services.Interfaces;
using AnimePlayer.Wrappers;
using DynamicData;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace AnimePlayer.ViewModels;

public class HomeViewModel : BaseViewModel
{
    private readonly ITitleService _titleService;

    public HomeViewModel(ITitleService titleService, INavigationService navigationService):base(navigationService)
    {
        _titleService = titleService;

        TitleSelectedCommand = ReactiveCommand.Create<TitleWrapper, Task>(async titleWrapper => await OnTitleSelectedCommand(titleWrapper));

        _titlesCache.Connect().Bind(out _titles).ObserveOn(RxApp.MainThreadScheduler).Subscribe();
    }

    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        _titlesCache.AddOrUpdate(await _titleService.GetTitles());
    }

    public ReactiveCommand<TitleWrapper, Task> TitleSelectedCommand { get; set; }
    private async Task OnTitleSelectedCommand(TitleWrapper titleWrapper)
    {
        var navigationParameters = new NavigationParameters { { "title", titleWrapper } };
        await NavigationService.NavigateAsync(Constants.TitlePage, navigationParameters);
    }

    #region DynamicList Series
    private SourceCache<TitleWrapper, long> _titlesCache = new SourceCache<TitleWrapper, long>(l => l.Id);
    private readonly ReadOnlyObservableCollection<TitleWrapper> _titles;
    public ReadOnlyObservableCollection<TitleWrapper> Titles => _titles;
    #endregion
}
