using AnimePlayer.Wrappers.Interfaces;
using ReactiveUI;

namespace AnimePlayer.Wrappers;

public class TitleWrapper : ReactiveObject, ITitleWrapper
{
    public string Id { get; set; }


    private bool _isLiked;
    public bool IsLiked
    {
        get => _isLiked;
        set => this.RaiseAndSetIfChanged(ref _isLiked, value);
    }


    public string Title { get; set; }
    public string OriginalTitle { get; set; }
    public string OriginalTitleRomanised { get; set; }
    public string Image { get; set; }
    public string MovieBanner { get; set; }
    public string Description { get; set; }
    public string Director { get; set; }
    public string Producer { get; set; }
    public string ReleaseDate { get; set; }
    public string RunningTime { get; set; }
    public string RtScore { get; set; }


    public TitleWrapper()
    {

    }

    public TitleWrapper(ITitleWrapper titleWrapper)
    {
        Id = titleWrapper.Id;
        Title = titleWrapper.Title;
        OriginalTitle = titleWrapper.OriginalTitle;
        OriginalTitleRomanised = titleWrapper.OriginalTitleRomanised;
        Image = titleWrapper.Image;
        MovieBanner = titleWrapper.MovieBanner;
        Description = titleWrapper.Description;
        Director = titleWrapper.Director;
        Producer = titleWrapper.Producer;
        ReleaseDate = titleWrapper.ReleaseDate;
        RunningTime = titleWrapper.RunningTime;
        RtScore = titleWrapper.RtScore;
    }
}
