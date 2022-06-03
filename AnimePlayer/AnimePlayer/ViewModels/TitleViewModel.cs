using AnimePlayer.Services.Interfaces;
using AnimePlayer.Wrappers;
using ReactiveUI;
using System.Reactive;

namespace AnimePlayer.ViewModels;

public class TitleViewModel : BaseViewModel
{
    public TitleViewModel(ITitleService titleService, INavigationService navigationService) : base(navigationService)
    {
        LikeCommand = ReactiveCommand.Create(OnLikeCommand);
    }

    public override async void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);

        if (parameters.ContainsKey("title"))
        {
            Title = parameters.GetValue<TitleWrapper>("title");
            PageTitle = Title.Title;
        }
    }

    public ReactiveCommand<Unit, Unit> LikeCommand { get; set; }
    private void OnLikeCommand()
    {
        Title.IsLiked = !Title.IsLiked;
    }

    #region Title
    private TitleWrapper _title;
    public TitleWrapper Title
    {
        get => _title;
        set => this.RaiseAndSetIfChanged(ref _title, value);
    }
    #endregion
}
