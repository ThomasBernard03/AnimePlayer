using AnimePlayer.Services.Interfaces;
using AnimePlayer.Wrappers;
using ReactiveUI;

namespace AnimePlayer.ViewModels;

public class TitleViewModel : BaseViewModel
{
    private readonly ITitleService _titleService;

    public TitleViewModel(ITitleService titleService, INavigationService navigationService) : base(navigationService)
    {
        _titleService = titleService;
    }

    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        if (parameters.ContainsKey("title"))
        {
            Title = await _titleService.GetTitle(parameters.GetValue<TitleWrapper>("title").Id);

            EpisodesGroupedBySeasons = Title.Episodes
                .DistinctBy(e => e.SeasonNumber)
                .Select(episode => 
                    new EpisodeSeasonGroupWrapper(episode.SeasonNumber.ToString(), Title.Episodes.Where(e => e.SeasonNumber == episode.SeasonNumber)
                    .ToList()))
                .ToList();
        }
    }

    public List<EpisodeSeasonGroupWrapper> EpisodesGroupedBySeasons { get; set; }

    #region Title
    private TitleWrapper _title;
    public TitleWrapper Title
    {
        get => _title;
        set => this.RaiseAndSetIfChanged(ref _title, value);
    }
    #endregion
}
