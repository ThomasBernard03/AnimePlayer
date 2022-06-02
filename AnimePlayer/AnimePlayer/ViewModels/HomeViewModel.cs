using AnimePlayer.Wrappers;
using DynamicData;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace AnimePlayer.ViewModels;

public class HomeViewModel : BaseViewModel
{
    public HomeViewModel()
    {
        _seriesCache.AddOrUpdate(new List<SerieWrapper>() 
        { 
            new SerieWrapper() { Id = 1, Name = "Stanger things" },
            new SerieWrapper() { Id = 2, Name = "Peaky blinders" },
            new SerieWrapper() { Id = 3, Name = "Breaking bad" },
            new SerieWrapper() { Id = 4, Name = "Vikings" },
            new SerieWrapper() { Id = 5, Name = "Game of trones" },
        });

        _seriesCache.Connect().Bind(out _series).ObserveOn(RxApp.MainThreadScheduler).Subscribe();
   }


    #region DynamicList Series
    private SourceCache<SerieWrapper, long> _seriesCache = new SourceCache<SerieWrapper, long>(l => l.Id);
    private readonly ReadOnlyObservableCollection<SerieWrapper> _series;
    public ReadOnlyObservableCollection<SerieWrapper> Series => _series;
    #endregion
}
